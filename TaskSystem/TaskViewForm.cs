using TaskSystem.Models;

namespace TaskSystem
{
    public partial class TaskViewForm : Form
    {
        private readonly CreateProfileDialog createProfileDialog = new();

        public TaskViewForm()
        {
            InitializeComponent();
            taskList.Rebind(GetTestData());
            // taskList е потребителска контрола.
            // Методът Rebind() попълва taskList с List<TaskModel>, елементите на който да се визуализират.
            // Засега той трябва да се извиква с подходящ параметър всеки път,
            // когато се променя съдържанието или подредбата на елементите на контролата.
            //
            // Когато стартираш програмата, ще видиш, че в контролата на всеки ред има един '+' накрая.
            // При натискането му ще се покажат описанието на задачата, кой я е добавил и бутоните "Edit" и "Delete".
        }

        // Метод, който генерира тестови данни.
        // Ще бъде премахнат, след като имплементираме базата данни.
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
                    CreatedBy = "admin"
                },
                new()
                {
                    Title = "Test task 2",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Deadline = DateTime.Now,
                    IsDone = false,
                    Priority = Priority.LessImportant,
                    CreatedBy = "test123"
                },
                new()
                {
                    Title = "Test task 3",
                    Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Deadline = DateTime.Now.AddDays(1),
                    IsDone = false,
                    Priority = Priority.Important,
                    CreatedBy = "admin"
                },
                new()
                {
                    Title = "Test task 4",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Deadline = DateTime.Now.AddDays(-1),
                    IsDone = true,
                    Priority = Priority.VeryImportant,
                    CreatedBy = "test123"
                },
                new()
                {
                    Title = "Test task 5",
                    Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Deadline = DateTime.Now.AddDays(1),
                    IsDone = true,
                    Priority = Priority.Urgent,
                    CreatedBy = "admin"
                }
                ];
        }

        // Контролата има и 2 потребителски събития: EditItem и DeleteItem,
        // които се извикват при натискането на съответните бутони. В обекта 'e'
        // се съхранява кой запис ще бъде засегнат (стойство Task), както и на кой индекс е в списъка
        // (ствойство Index, добавил съм го само в случай че нещо се обърка със свойството Task).
        private void taskList_DeleteItem(object sender, TaskSystem.TaskListBox.ChangeItemEventArgs e)
        {
            MessageBox.Show($"Deleting {e.Index}: {e.Item.Title}");
        }

        private void taskList_EditItem(object sender, TaskSystem.TaskListBox.ChangeItemEventArgs e)
        {
            MessageBox.Show($"Editing {e.Index}: {e.Item.Title}");
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (usernameTextBox.Text.Length == 0 || passwordTextBox.Text.Length == 0)
                    throw new InvalidDataException("Enter both username and password!");
                ProfileModel profile = new()
                {
                    UserName = usernameTextBox.Text,
                    Password = ProfilesService.HashPassword(passwordTextBox.Text)
                };
                if (GlobalService.Profiles.CheckProfilePassword(profile))
                    LogIn(GlobalService.Profiles.GetProfile(profile.UserName));
                else throw new InvalidDataException("The username and the password do not match!");
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message, "Invalid log in attempt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogIn(ProfileModel profile)
        {
            userLabel.Text = profile.UserName;
            loggedInPanel.Visible = true;
            nonLoggedPanel.Visible = false;
            passwordTextBox.Text = string.Empty;
            createButton.Visible = true;
            taskList.SetLoggedInProfile(GlobalService.Profiles.GetProfile(profile.UserName));
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            nonLoggedPanel.Visible = true;
            loggedInPanel.Visible = false;
            createButton.Visible = false;
            taskList.SetLoggedInProfile(null);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (createProfileDialog.ShowDialog(this) == DialogResult.OK && createProfileDialog.Profile != null)
                GlobalService.Profiles.CreateProfile(createProfileDialog.Profile);
        }
    }
}
