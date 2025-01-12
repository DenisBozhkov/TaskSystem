using TaskSystem.Models;

namespace TaskSystem
{
    public partial class TaskListBox : UserControl
    {
        private ProfileModel? loggedInProfile;
        public TaskListBox()
        {
            InitializeComponent();
        }

        public void SetLoggedInProfile(ProfileModel? profile)
        {
            loggedInProfile = profile;
            foreach(Control control in Controls)
                if(control is TaskDescriptionBox descriptionBox)
                    descriptionBox.CanEdit = descriptionBox.TaskAuthor?.CompareTo(profile?.UserName) == 0;
        }

        public void Rebind(List<TaskModel> tasks)
        {
            TaskVisualBox box;
            TaskDescriptionBox description;
            Controls.Clear();
            for(int i=tasks.Count-1; i>=0;i--)
            {
                description = new(tasks[i])
                {
                    AutoSize = true,
                    Dock = DockStyle.Top,
                    Tag = i,
                    Visible = false
                };
                box = new(tasks[i])
                {
                    AutoSize = true,
                    Dock = DockStyle.Top,
                    Tag = description
                };
                description.CanEdit = tasks[i].CreatedBy.Equals(loggedInProfile?.UserName);
                description.EditItem += Description_EditItem;
                description.DeleteItem += Description_DeleteItem;
                box.CollapseDescription += Box_CollapseDescription;
                box.ExpandDescription += Box_ExpandDescription;
                Controls.Add(description);
                Controls.Add(box);
            }
        }

        private void Description_DeleteItem(object? sender, TaskDescriptionBox.ManItemEventArgs e)
        {
            if (sender is TaskDescriptionBox description && description.Tag is int index)
                DeleteItem?.Invoke(this, new(e.Task, index));
        }

        private void Description_EditItem(object? sender, TaskDescriptionBox.ManItemEventArgs e)
        {
            if (sender is TaskDescriptionBox description && description.Tag is int index)
                EditItem?.Invoke(this, new(e.Task, index));
        }

        public event EventHandler<ChangeItemEventArgs>? EditItem;
        public event EventHandler<ChangeItemEventArgs>? DeleteItem;

        private void Box_ExpandDescription(object? sender, EventArgs e)
        {
            if (sender is TaskVisualBox box && box.Tag is Control description)
                description.Visible = true;
        }

        private void Box_CollapseDescription(object? sender, EventArgs e)
        {
            if (sender is TaskVisualBox box && box.Tag is Control description)
                description.Visible = false;
        }

        public class ChangeItemEventArgs(TaskModel task, int index)
        {
            public TaskModel Item { get; set; } = task;
            public int Index { get; set; } = index;
        }
    }
}
