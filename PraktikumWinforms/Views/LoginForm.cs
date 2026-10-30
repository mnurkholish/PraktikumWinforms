using PraktikumWinforms;

namespace PraktikumWinForms
{
    public partial class LoginForm : Form
    {
        private string Username;
        private string Password;
        private FormUtama _induk;
        public LoginForm(FormUtama form)
        {
            InitializeComponent();
            this.Username = "andromok";
            this.Password = "agusandro";
            this._induk = form;

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
                _induk.BukaFormDiPanel(dashboard);
                //dashboard.Show();


            }
            else
            {
                MessageBox.Show($"Login Gagal", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
