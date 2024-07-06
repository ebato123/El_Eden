namespace El_Eden
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbElEden = new Label();
            tbUser = new TextBox();
            tbPassword = new TextBox();
            lbUser = new Label();
            lbPassword = new Label();
            lbPasteleria = new Label();
            btnLogIn = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lbElEden
            // 
            lbElEden.AutoSize = true;
            lbElEden.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbElEden.ForeColor = Color.LemonChiffon;
            lbElEden.Location = new Point(41, 9);
            lbElEden.Name = "lbElEden";
            lbElEden.Size = new Size(243, 55);
            lbElEden.TabIndex = 0;
            lbElEden.Text = "- El Eden -";
            // 
            // tbUser
            // 
            tbUser.Location = new Point(12, 111);
            tbUser.Name = "tbUser";
            tbUser.PlaceholderText = "Ingrese su usuario.";
            tbUser.Size = new Size(142, 23);
            tbUser.TabIndex = 1;
            tbUser.TextChanged += tbUsuario_TextChanged;
            tbUser.KeyDown += tbUsuario_KeyDown;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(169, 111);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "Ingrese su contraseña.";
            tbPassword.Size = new Size(142, 23);
            tbPassword.TabIndex = 2;
            tbPassword.TextChanged += tbContraseña_TextChanged;
            tbPassword.KeyDown += tbContraseña_KeyDown;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Oswald", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUser.ForeColor = Color.LemonChiffon;
            lbUser.Location = new Point(12, 88);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(48, 20);
            lbUser.TabIndex = 3;
            lbUser.Text = "Usuario";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Oswald", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPassword.ForeColor = Color.LemonChiffon;
            lbPassword.Location = new Point(245, 88);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(66, 20);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Contraseña";
            // 
            // lbPasteleria
            // 
            lbPasteleria.AutoSize = true;
            lbPasteleria.Font = new Font("Oswald", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPasteleria.ForeColor = Color.LemonChiffon;
            lbPasteleria.Location = new Point(131, 64);
            lbPasteleria.Name = "lbPasteleria";
            lbPasteleria.Size = new Size(60, 20);
            lbPasteleria.TabIndex = 5;
            lbPasteleria.Text = "Pastelería";
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.LemonChiffon;
            btnLogIn.FlatAppearance.BorderSize = 2;
            btnLogIn.ForeColor = Color.Black;
            btnLogIn.Location = new Point(251, 161);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(60, 27);
            btnLogIn.TabIndex = 6;
            btnLogIn.Text = "Iniciar";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Black;
            btnClose.FlatAppearance.BorderSize = 2;
            btnClose.ForeColor = Color.LemonChiffon;
            btnClose.Location = new Point(12, 161);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(60, 27);
            btnClose.TabIndex = 7;
            btnClose.Text = "Cerrar";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnCerrar_Click;
            // 
            // LogIn
            // 
            BackColor = Color.Black;
            ClientSize = new Size(325, 203);
            Controls.Add(btnClose);
            Controls.Add(btnLogIn);
            Controls.Add(lbPasteleria);
            Controls.Add(lbPassword);
            Controls.Add(lbUser);
            Controls.Add(tbPassword);
            Controls.Add(tbUser);
            Controls.Add(lbElEden);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "El Eden";
            VisibleChanged += LogIn_VisibleChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbElEden;
        private TextBox tbUser;
        private TextBox tbPassword;
        private Label lbUser;
        private Label lbPassword;
        private Label lbPasteleria;
        private Button btnLogIn;
        private Button btnClose;
    }
}
