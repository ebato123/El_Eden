using El_Eden.MySQL.TablesObjects;

namespace El_Eden
{
    public partial class LogIn : Form
    {
        private string name;
        private string password;
        private int iAux = 0;

        private List<User> users = new List<User>();
        private UserDao userDao = new UserDao();

        public LogIn()
        {
            InitializeComponent();
            tbUser.Focus();
        }

        #region METHODS
        private void logIn()
        {
            users.Clear();
            users = userDao.getUsers($" * FROM user WHERE name LIKE '{name}' AND password LIKE '{password}';");

            if (users.Count >= 1)
            {
                Config.user_id = users[0].user_id;
                Config.name = users[0].name;
                Config.type = users[0].type;

                this.Visible = false;
                users.Clear();
                tbUser.Text = "";
                tbPassword.Text = "";
                MainMenu mainMenu = new MainMenu();
                mainMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Los valores ingresados son incorrectos.", "ERROR");
                users.Clear();
            }
        }
        #endregion

        #region EVENTS

        #region CLICK EVENTS
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            logIn();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region KEY DOWN EVENTS
        private void tbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void tbContraseña_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                tbUser.Focus();
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                logIn();
                e.SuppressKeyPress = true;
            }
        }
        #endregion

        #region TEXT CHANGED EVENTS
        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            name = tbUser.Text;
        }
        private void tbContraseña_TextChanged(object sender, EventArgs e)
        {
            password = tbPassword.Text;
        }
        #endregion

        #endregion

        private void LogIn_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false && iAux == 2)
            {
                Close();
            }
            else
            {
                iAux++;
            }
        }
    }
}
