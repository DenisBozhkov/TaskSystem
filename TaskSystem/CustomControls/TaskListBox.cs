using TaskSystem.Models;

namespace TaskSystem
{
    public partial class TaskListBox : UserControl
    {
        private ProfileModel? loggedInProfile;
        public TaskListBox()
        {
            InitializeComponent();
            Headings = new(true)
            {
                AutoSize = true,
                Dock = DockStyle.Top
            };
        }

        private readonly TaskVisualBox Headings;

        public void SetLoggedInProfile(ProfileModel? profile)
        {
            loggedInProfile = profile;
            GlobalService.LoggedInProfile = profile;
            foreach (Control control in Controls)
                if (control is TaskDescriptionBox descriptionBox)
                    descriptionBox.CanEdit = descriptionBox.TaskAuthor?.CompareTo(profile?.UserName) == 0;
                else if (control is TaskVisualBox box && box.Tag is TaskDescriptionBox descriptionBox1)
                    box.CanEdit = descriptionBox1.TaskAuthor?.CompareTo(profile?.UserName) == 0;
        }

        public void Rebind(List<TaskModel> tasks)
        {
            TaskVisualBox box;
            TaskDescriptionBox description;
            List<Control> controls = [];
            for (int i = tasks.Count - 1; i >= 0; i--)
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
                description.CanEdit = box.CanEdit = tasks[i].CreatedBy.Equals(loggedInProfile?.UserName);
                description.EditItem += Description_EditItem;
                description.DeleteItem += Description_DeleteItem;
                box.CollapseDescription += Box_CollapseDescription;
                box.ExpandDescription += Box_ExpandDescription;
                box.StatusClicked += Box_StatusClicked;
                controls.Add(description);
                controls.Add(box);
            }
            Controls.Clear();
            Controls.AddRange([.. controls]);
            Controls.Add(Headings);
        }

        private void Box_StatusClicked(object? sender, TaskVisualBox.StatusClickedEventArgs e)
        {
            if (sender is TaskVisualBox box && box.Tag is TaskDescriptionBox description && description.Tag is int index)
                SwitchStatus?.Invoke(this, new(e.Task, index));
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
        public event EventHandler<ChangeItemEventArgs>? SwitchStatus;

        private void Box_ExpandDescription(object? sender, EventArgs e)
        {
            if (sender is TaskVisualBox box && box.Tag is Control description)
            {
                description.Visible = true;
                ScrollControlIntoView(description);
            }
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
