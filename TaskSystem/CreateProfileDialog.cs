using TaskSystem.Models;

namespace TaskSystem
{
    public partial class CreateProfileDialog : Form
    {
        private ProfileModel? profile;

        public CreateProfileDialog()
        {
            InitializeComponent();
        }

        public ProfileModel? Profile => profile;
        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (usernameTextBox.Text.Length == 0)
                    throw new InvalidDataException("Please, enter a username!");
                if (passwordTextBox.Text.Length == 0)
                    throw new InvalidDataException("Please, enter a password!");
                if (emailTextBox.Text.Length == 0)
                    throw new InvalidDataException("Please, enter an e-mail address!");
                if (ProfilesService.GetProfile(usernameTextBox.Text) != null)
                    throw new InvalidDataException($"The user \"{usernameTextBox.Text}\" already exists!");
                if (!passwordTextBox.Text.Equals(confirmPasswordTextBox.Text))
                    throw new InvalidDataException("The passwords does not match!");
                profile = new()
                {
                    UserName = usernameTextBox.Text,
                    Password = ProfilesService.HashPassword(passwordTextBox.Text),
                    Email = emailTextBox.Text
                };
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            profile = null;
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
