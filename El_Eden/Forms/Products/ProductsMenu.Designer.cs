namespace El_Eden.Forms.Products
{
    partial class ProductsMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlUpperTool = new Panel();
            btnReturn = new Button();
            btnMinimize = new Button();
            btnClose = new Button();
            gpWelcome = new GroupBox();
            lbWelcome = new Label();
            lbDateTime = new Label();
            lbElEden = new Label();
            lbClients = new Label();
            tcClients = new TabControl();
            tp1Search = new TabPage();
            btnDeleteTp1 = new Button();
            btnModifyTp1 = new Button();
            btnSearchTp1 = new Button();
            tbNeighborhoodTp1 = new TextBox();
            tbNameTp1 = new TextBox();
            lbNeighborhoodTp1 = new Label();
            lbNameTp1 = new Label();
            gbSelectOption = new GroupBox();
            lbOptions = new Label();
            lbNameTp2 = new Label();
            lbLastNameTp2 = new Label();
            tbNameTp2 = new TextBox();
            tbLastNameTp2 = new TextBox();
            btnAddClientTp2 = new Button();
            tp2Add = new TabPage();
            pictureBox1 = new PictureBox();
            pnlUpperTool.SuspendLayout();
            gpWelcome.SuspendLayout();
            tcClients.SuspendLayout();
            tp1Search.SuspendLayout();
            gbSelectOption.SuspendLayout();
            tp2Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlUpperTool
            // 
            pnlUpperTool.BackColor = Color.LemonChiffon;
            pnlUpperTool.Controls.Add(btnReturn);
            pnlUpperTool.Controls.Add(btnMinimize);
            pnlUpperTool.Controls.Add(btnClose);
            pnlUpperTool.Location = new Point(0, 0);
            pnlUpperTool.Name = "pnlUpperTool";
            pnlUpperTool.Size = new Size(861, 28);
            pnlUpperTool.TabIndex = 20;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Black;
            btnReturn.ForeColor = Color.LemonChiffon;
            btnReturn.ImeMode = ImeMode.NoControl;
            btnReturn.Location = new Point(720, 3);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(44, 22);
            btnReturn.TabIndex = 0;
            btnReturn.Text = "↩";
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Black;
            btnMinimize.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnMinimize.ForeColor = Color.LemonChiffon;
            btnMinimize.ImeMode = ImeMode.NoControl;
            btnMinimize.Location = new Point(765, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(44, 22);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "¯";
            btnMinimize.TextAlign = ContentAlignment.TopCenter;
            btnMinimize.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Black;
            btnClose.ForeColor = Color.LemonChiffon;
            btnClose.ImeMode = ImeMode.NoControl;
            btnClose.Location = new Point(809, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(44, 22);
            btnClose.TabIndex = 0;
            btnClose.Text = "✖";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // gpWelcome
            // 
            gpWelcome.Controls.Add(lbWelcome);
            gpWelcome.Controls.Add(lbDateTime);
            gpWelcome.Font = new Font("Times New Roman", 12F, FontStyle.Italic);
            gpWelcome.ForeColor = Color.LemonChiffon;
            gpWelcome.Location = new Point(12, 34);
            gpWelcome.Name = "gpWelcome";
            gpWelcome.Size = new Size(237, 108);
            gpWelcome.TabIndex = 24;
            gpWelcome.TabStop = false;
            // 
            // lbWelcome
            // 
            lbWelcome.Font = new Font("Oswald", 9.75F);
            lbWelcome.ForeColor = Color.LemonChiffon;
            lbWelcome.ImeMode = ImeMode.NoControl;
            lbWelcome.Location = new Point(6, 22);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(225, 24);
            lbWelcome.TabIndex = 8;
            lbWelcome.Text = "Bienvenid@ ";
            lbWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbDateTime
            // 
            lbDateTime.Font = new Font("Oswald", 9.75F);
            lbDateTime.ForeColor = Color.LemonChiffon;
            lbDateTime.ImeMode = ImeMode.NoControl;
            lbDateTime.Location = new Point(6, 46);
            lbDateTime.Name = "lbDateTime";
            lbDateTime.Size = new Size(225, 31);
            lbDateTime.TabIndex = 9;
            lbDateTime.Text = "FECHA / HORA ";
            lbDateTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbElEden
            // 
            lbElEden.AutoSize = true;
            lbElEden.Font = new Font("Times New Roman", 36F, FontStyle.Bold);
            lbElEden.ForeColor = Color.LemonChiffon;
            lbElEden.ImeMode = ImeMode.NoControl;
            lbElEden.Location = new Point(605, 56);
            lbElEden.Name = "lbElEden";
            lbElEden.Size = new Size(243, 55);
            lbElEden.TabIndex = 25;
            lbElEden.Text = "- El Eden -";
            // 
            // lbClients
            // 
            lbClients.AutoSize = true;
            lbClients.Font = new Font("Oswald", 9.75F);
            lbClients.ForeColor = Color.LemonChiffon;
            lbClients.ImeMode = ImeMode.NoControl;
            lbClients.Location = new Point(696, 111);
            lbClients.Name = "lbClients";
            lbClients.Size = new Size(60, 20);
            lbClients.TabIndex = 26;
            lbClients.Text = "Productos";
            // 
            // tcClients
            // 
            tcClients.Controls.Add(tp1Search);
            tcClients.Controls.Add(tp2Add);
            tcClients.Location = new Point(16, 25);
            tcClients.Name = "tcClients";
            tcClients.SelectedIndex = 0;
            tcClients.Size = new Size(537, 174);
            tcClients.TabIndex = 25;
            // 
            // tp1Search
            // 
            tp1Search.BackColor = Color.Black;
            tp1Search.Controls.Add(btnDeleteTp1);
            tp1Search.Controls.Add(btnModifyTp1);
            tp1Search.Controls.Add(btnSearchTp1);
            tp1Search.Controls.Add(tbNeighborhoodTp1);
            tp1Search.Controls.Add(tbNameTp1);
            tp1Search.Controls.Add(lbNeighborhoodTp1);
            tp1Search.Controls.Add(lbNameTp1);
            tp1Search.Location = new Point(4, 28);
            tp1Search.Name = "tp1Search";
            tp1Search.Padding = new Padding(3);
            tp1Search.Size = new Size(529, 142);
            tp1Search.TabIndex = 0;
            tp1Search.Text = "BUSCAR";
            // 
            // btnDeleteTp1
            // 
            btnDeleteTp1.BackColor = Color.Black;
            btnDeleteTp1.Enabled = false;
            btnDeleteTp1.FlatAppearance.BorderSize = 2;
            btnDeleteTp1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteTp1.ForeColor = Color.Red;
            btnDeleteTp1.Location = new Point(335, 87);
            btnDeleteTp1.Name = "btnDeleteTp1";
            btnDeleteTp1.Size = new Size(115, 34);
            btnDeleteTp1.TabIndex = 32;
            btnDeleteTp1.Text = "ELIMINAR";
            btnDeleteTp1.UseVisualStyleBackColor = false;
            // 
            // btnModifyTp1
            // 
            btnModifyTp1.BackColor = Color.Black;
            btnModifyTp1.FlatAppearance.BorderSize = 2;
            btnModifyTp1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifyTp1.ForeColor = Color.LemonChiffon;
            btnModifyTp1.Location = new Point(204, 87);
            btnModifyTp1.Name = "btnModifyTp1";
            btnModifyTp1.Size = new Size(115, 34);
            btnModifyTp1.TabIndex = 31;
            btnModifyTp1.Text = "MODIFICAR";
            btnModifyTp1.UseVisualStyleBackColor = false;
            // 
            // btnSearchTp1
            // 
            btnSearchTp1.BackColor = Color.LemonChiffon;
            btnSearchTp1.FlatAppearance.BorderSize = 2;
            btnSearchTp1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSearchTp1.ForeColor = Color.Black;
            btnSearchTp1.Location = new Point(76, 87);
            btnSearchTp1.Name = "btnSearchTp1";
            btnSearchTp1.Size = new Size(115, 34);
            btnSearchTp1.TabIndex = 20;
            btnSearchTp1.Text = "BUSCAR";
            btnSearchTp1.UseVisualStyleBackColor = false;
            // 
            // tbNeighborhoodTp1
            // 
            tbNeighborhoodTp1.Location = new Point(148, 42);
            tbNeighborhoodTp1.Name = "tbNeighborhoodTp1";
            tbNeighborhoodTp1.Size = new Size(339, 26);
            tbNeighborhoodTp1.TabIndex = 28;
            // 
            // tbNameTp1
            // 
            tbNameTp1.Location = new Point(39, 42);
            tbNameTp1.Name = "tbNameTp1";
            tbNameTp1.Size = new Size(88, 26);
            tbNameTp1.TabIndex = 20;
            // 
            // lbNeighborhoodTp1
            // 
            lbNeighborhoodTp1.Font = new Font("Oswald", 9.75F);
            lbNeighborhoodTp1.ForeColor = Color.LemonChiffon;
            lbNeighborhoodTp1.ImeMode = ImeMode.NoControl;
            lbNeighborhoodTp1.Location = new Point(148, 15);
            lbNeighborhoodTp1.Name = "lbNeighborhoodTp1";
            lbNeighborhoodTp1.Size = new Size(339, 24);
            lbNeighborhoodTp1.TabIndex = 27;
            lbNeighborhoodTp1.Text = "Nombre";
            lbNeighborhoodTp1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbNameTp1
            // 
            lbNameTp1.Font = new Font("Oswald", 9.75F);
            lbNameTp1.ForeColor = Color.LemonChiffon;
            lbNameTp1.ImeMode = ImeMode.NoControl;
            lbNameTp1.Location = new Point(39, 16);
            lbNameTp1.Name = "lbNameTp1";
            lbNameTp1.Size = new Size(88, 24);
            lbNameTp1.TabIndex = 21;
            lbNameTp1.Text = "ID del Producto";
            lbNameTp1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gbSelectOption
            // 
            gbSelectOption.Controls.Add(pictureBox1);
            gbSelectOption.Controls.Add(tcClients);
            gbSelectOption.Font = new Font("Times New Roman", 12F, FontStyle.Italic);
            gbSelectOption.ForeColor = Color.LemonChiffon;
            gbSelectOption.Location = new Point(12, 152);
            gbSelectOption.Name = "gbSelectOption";
            gbSelectOption.Size = new Size(836, 590);
            gbSelectOption.TabIndex = 27;
            gbSelectOption.TabStop = false;
            gbSelectOption.Text = "Seleccione una opción:";
            // 
            // lbOptions
            // 
            lbOptions.BackColor = Color.Transparent;
            lbOptions.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbOptions.ForeColor = Color.LemonChiffon;
            lbOptions.ImeMode = ImeMode.NoControl;
            lbOptions.Location = new Point(0, 73);
            lbOptions.Name = "lbOptions";
            lbOptions.Size = new Size(861, 38);
            lbOptions.TabIndex = 28;
            lbOptions.Text = "- Buscar Clientes -";
            lbOptions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbNameTp2
            // 
            lbNameTp2.Font = new Font("Oswald", 9.75F);
            lbNameTp2.ForeColor = Color.LemonChiffon;
            lbNameTp2.ImeMode = ImeMode.NoControl;
            lbNameTp2.Location = new Point(18, 12);
            lbNameTp2.Name = "lbNameTp2";
            lbNameTp2.Size = new Size(166, 24);
            lbNameTp2.TabIndex = 31;
            lbNameTp2.Text = "ID del Producto";
            lbNameTp2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbLastNameTp2
            // 
            lbLastNameTp2.Font = new Font("Oswald", 9.75F);
            lbLastNameTp2.ForeColor = Color.LemonChiffon;
            lbLastNameTp2.ImeMode = ImeMode.NoControl;
            lbLastNameTp2.Location = new Point(199, 11);
            lbLastNameTp2.Name = "lbLastNameTp2";
            lbLastNameTp2.Size = new Size(166, 24);
            lbLastNameTp2.TabIndex = 33;
            lbLastNameTp2.Text = "Nombre";
            lbLastNameTp2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbNameTp2
            // 
            tbNameTp2.Location = new Point(18, 38);
            tbNameTp2.Name = "tbNameTp2";
            tbNameTp2.Size = new Size(166, 26);
            tbNameTp2.TabIndex = 30;
            // 
            // tbLastNameTp2
            // 
            tbLastNameTp2.Location = new Point(199, 38);
            tbLastNameTp2.Name = "tbLastNameTp2";
            tbLastNameTp2.Size = new Size(166, 26);
            tbLastNameTp2.TabIndex = 32;
            // 
            // btnAddClientTp2
            // 
            btnAddClientTp2.BackColor = Color.LemonChiffon;
            btnAddClientTp2.FlatAppearance.BorderSize = 2;
            btnAddClientTp2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnAddClientTp2.ForeColor = Color.Black;
            btnAddClientTp2.Location = new Point(381, 30);
            btnAddClientTp2.Name = "btnAddClientTp2";
            btnAddClientTp2.Size = new Size(130, 34);
            btnAddClientTp2.TabIndex = 40;
            btnAddClientTp2.Text = "Agregar Cliente";
            btnAddClientTp2.UseVisualStyleBackColor = false;
            // 
            // tp2Add
            // 
            tp2Add.BackColor = Color.Black;
            tp2Add.Controls.Add(btnAddClientTp2);
            tp2Add.Controls.Add(tbLastNameTp2);
            tp2Add.Controls.Add(tbNameTp2);
            tp2Add.Controls.Add(lbLastNameTp2);
            tp2Add.Controls.Add(lbNameTp2);
            tp2Add.Location = new Point(4, 28);
            tp2Add.Name = "tp2Add";
            tp2Add.Padding = new Padding(3);
            tp2Add.Size = new Size(529, 142);
            tp2Add.TabIndex = 1;
            tp2Add.Text = "AGREGAR";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.InactiveCaption;
            pictureBox1.Location = new Point(569, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // ProductsMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(860, 754);
            Controls.Add(gpWelcome);
            Controls.Add(lbElEden);
            Controls.Add(lbOptions);
            Controls.Add(gbSelectOption);
            Controls.Add(lbClients);
            Controls.Add(pnlUpperTool);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductsMenu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductsMenu";
            pnlUpperTool.ResumeLayout(false);
            gpWelcome.ResumeLayout(false);
            tcClients.ResumeLayout(false);
            tp1Search.ResumeLayout(false);
            tp1Search.PerformLayout();
            gbSelectOption.ResumeLayout(false);
            tp2Add.ResumeLayout(false);
            tp2Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlUpperTool;
        private Button btnReturn;
        private Button btnMinimize;
        private Button btnClose;
        private GroupBox gpWelcome;
        private Label lbWelcome;
        private Label lbDateTime;
        private Label lbElEden;
        private Label lbClients;
        private TabControl tcClients;
        private TabPage tp1Search;
        private Button btnDeleteTp1;
        private Button btnModifyTp1;
        private Button btnSearchTp1;
        private TextBox tbNeighborhoodTp1;
        private TextBox tbNameTp1;
        private Label lbNeighborhoodTp1;
        private Label lbNameTp1;
        private GroupBox gbSelectOption;
        private Label lbOptions;
        private TabPage tp2Add;
        private Button btnAddClientTp2;
        private TextBox tbLastNameTp2;
        private TextBox tbNameTp2;
        private Label lbLastNameTp2;
        private Label lbNameTp2;
        private PictureBox pictureBox1;
    }
}