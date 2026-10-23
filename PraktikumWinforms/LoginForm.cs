namespace PraktikumWinForms
{
    public partial class LoginForm : Form
    {
        private string Username;
        private string Password;
        public LoginForm()
        {
            InitializeComponent();
            this.Username = "andromok";
            this.Password = "agusandro";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            String UsernameInput = TbUsername.Text;
            String PasswordInput = TbPassword.Text;


            //MessageBox.Show($"Username : {UsernameInput}, Password : {PasswordInput}", "Coba", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (UsernameInput == this.Username && PasswordInput == Password)
            {
                MessageBox.Show($"Login Berhasil", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormDashboard dashboard = new FormDashboard();
                dashboard.Show();
                this.Hide();
                //dashboard.Show();


            }
            else
            {
                MessageBox.Show($"Login Gagal", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
