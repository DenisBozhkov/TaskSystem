using TaskSystem.Models;

namespace TaskSystem
{
    public partial class TaskViewForm : Form
    {
        public TaskViewForm()
        {
            InitializeComponent();
            taskList.Rebind(GetTestData());
            // taskList � ������������� ��������.
            // ������� Rebind() ������� taskList � List<TaskModel>, ���������� �� ����� �� �� ������������.
            // ������ ��� ������ �� �� ������� � �������� ��������� ����� ���,
            // ������ �� ������� ������������ ��� ���������� �� ���������� �� ����������.
            //
            // ������ ��������� ����������, �� �����, �� � ���������� �� ����� ��� ��� ���� '+' ������.
            // ��� ����������� �� �� �� ������� ���������� �� ��������, ��� � � ������� � �������� "Edit" � "Delete".
        }

        // �����, ����� �������� ������� �����.
        // �� ���� ���������, ���� ���� �������������� ������ �����.
        static List<TaskModel> GetTestData()
        {
            return [
                new()
                {
                    Title = "Test task 1",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Deadline = DateTime.Now.AddDays(-1),
                    IsDone = false,
                    Priority = Priority.NotImportant,
                    CreatedBy = "user"
                },
                new()
                {
                    Title = "Test task 2",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Deadline = DateTime.Now,
                    IsDone = false,
                    Priority = Priority.LessImportant,
                    CreatedBy = "user"
                },
                new()
                {
                    Title = "Test task 3",
                    Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Deadline = DateTime.Now.AddDays(1),
                    IsDone = false,
                    Priority = Priority.Important,
                    CreatedBy = "user"
                },
                new()
                {
                    Title = "Test task 4",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Deadline = DateTime.Now.AddDays(-1),
                    IsDone = true,
                    Priority = Priority.VeryImportant,
                    CreatedBy = "user"
                },
                new()
                {
                    Title = "Test task 5",
                    Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Deadline = DateTime.Now.AddDays(1),
                    IsDone = true,
                    Priority = Priority.Urgent,
                    CreatedBy = "user"
                }
                ];
        }

        // ���������� ��� � 2 ������������� �������: EditItem � DeleteItem,
        // ����� �� �������� ��� ����������� �� ����������� ������. � ������ 'e'
        // �� ��������� ��� ����� �� ���� �������� (�������� Task), ����� � �� ��� ������ � � �������
        // (��������� Index, ������� ��� �� ���� � ������ �� ���� �� ������ ��� ���������� Task).
        private void taskList_DeleteItem(object sender, TaskSystem.TaskListBox.ChangeItemEventArgs e)
        {
            MessageBox.Show($"Deleting {e.Index}: {e.Item.Title}");
        }

        private void taskList_EditItem(object sender, TaskSystem.TaskListBox.ChangeItemEventArgs e)
        {
            MessageBox.Show($"Editing {e.Index}: {e.Item.Title}");
        }
    }
}
