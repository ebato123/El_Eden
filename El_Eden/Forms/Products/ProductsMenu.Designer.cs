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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsMenu));
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
            tp2Add = new TabPage();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            btnAddClientTp2 = new Button();
            tbLastNameTp2 = new TextBox();
            tbNameTp2 = new TextBox();
            lbLastNameTp2 = new Label();
            lbNameTp2 = new Label();
            gbSelectOption = new GroupBox();
            pictureBox1 = new PictureBox();
            lbOptions = new Label();
            pnlUpperTool.SuspendLayout();
            gpWelcome.SuspendLayout();
            tcClients.SuspendLayout();
            tp1Search.SuspendLayout();
            tp2Add.SuspendLayout();
            gbSelectOption.SuspendLayout();
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
            tcClients.Location = new Point(17, 25);
            tcClients.Name = "tcClients";
            tcClients.SelectedIndex = 0;
            tcClients.Size = new Size(577, 205);
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
            tp1Search.Size = new Size(569, 173);
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
            btnDeleteTp1.Location = new Point(344, 102);
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
            btnModifyTp1.Location = new Point(213, 102);
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
            btnSearchTp1.Location = new Point(85, 102);
            btnSearchTp1.Name = "btnSearchTp1";
            btnSearchTp1.Size = new Size(115, 34);
            btnSearchTp1.TabIndex = 20;
            btnSearchTp1.Text = "BUSCAR";
            btnSearchTp1.UseVisualStyleBackColor = false;
            // 
            // tbNeighborhoodTp1
            // 
            tbNeighborhoodTp1.Location = new Point(164, 58);
            tbNeighborhoodTp1.Name = "tbNeighborhoodTp1";
            tbNeighborhoodTp1.Size = new Size(339, 26);
            tbNeighborhoodTp1.TabIndex = 28;
            // 
            // tbNameTp1
            // 
            tbNameTp1.Location = new Point(55, 58);
            tbNameTp1.Name = "tbNameTp1";
            tbNameTp1.Size = new Size(88, 26);
            tbNameTp1.TabIndex = 20;
            // 
            // lbNeighborhoodTp1
            // 
            lbNeighborhoodTp1.Font = new Font("Oswald", 9.75F);
            lbNeighborhoodTp1.ForeColor = Color.LemonChiffon;
            lbNeighborhoodTp1.ImeMode = ImeMode.NoControl;
            lbNeighborhoodTp1.Location = new Point(164, 31);
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
            lbNameTp1.Location = new Point(55, 32);
            lbNameTp1.Name = "lbNameTp1";
            lbNameTp1.Size = new Size(88, 24);
            lbNameTp1.TabIndex = 21;
            lbNameTp1.Text = "ID del Producto";
            lbNameTp1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tp2Add
            // 
            tp2Add.BackColor = Color.Black;
            tp2Add.Controls.Add(label2);
            tp2Add.Controls.Add(textBox1);
            tp2Add.Controls.Add(label1);
            tp2Add.Controls.Add(richTextBox1);
            tp2Add.Controls.Add(button1);
            tp2Add.Controls.Add(btnAddClientTp2);
            tp2Add.Controls.Add(tbLastNameTp2);
            tp2Add.Controls.Add(tbNameTp2);
            tp2Add.Controls.Add(lbLastNameTp2);
            tp2Add.Controls.Add(lbNameTp2);
            tp2Add.Location = new Point(4, 28);
            tp2Add.Name = "tp2Add";
            tp2Add.Padding = new Padding(3);
            tp2Add.Size = new Size(569, 173);
            tp2Add.TabIndex = 1;
            tp2Add.Text = "AGREGAR";
            tp2Add.Click += tp2Add_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Oswald", 9.75F);
            label2.ForeColor = Color.LemonChiffon;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(78, 132);
            label2.Name = "label2";
            label2.Size = new Size(40, 24);
            label2.TabIndex = 45;
            label2.Text = "Stock";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(40, 26);
            textBox1.TabIndex = 44;
            // 
            // label1
            // 
            label1.Font = new Font("Oswald", 9.75F);
            label1.ForeColor = Color.LemonChiffon;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(255, 1);
            label1.Name = "label1";
            label1.Size = new Size(296, 24);
            label1.TabIndex = 43;
            label1.Text = "Descripción";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(255, 28);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(296, 82);
            richTextBox1.TabIndex = 42;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.LemonChiffon;
            button1.FlatAppearance.BorderSize = 2;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(255, 124);
            button1.Name = "button1";
            button1.Size = new Size(137, 34);
            button1.TabIndex = 41;
            button1.Text = "Subir Imágen";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnAddClientTp2
            // 
            btnAddClientTp2.BackColor = Color.LemonChiffon;
            btnAddClientTp2.FlatAppearance.BorderSize = 2;
            btnAddClientTp2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnAddClientTp2.ForeColor = Color.Black;
            btnAddClientTp2.Location = new Point(414, 124);
            btnAddClientTp2.Name = "btnAddClientTp2";
            btnAddClientTp2.Size = new Size(137, 34);
            btnAddClientTp2.TabIndex = 40;
            btnAddClientTp2.Text = "Agregar Producto";
            btnAddClientTp2.UseVisualStyleBackColor = false;
            // 
            // tbLastNameTp2
            // 
            tbLastNameTp2.Location = new Point(22, 84);
            tbLastNameTp2.Name = "tbLastNameTp2";
            tbLastNameTp2.Size = new Size(215, 26);
            tbLastNameTp2.TabIndex = 32;
            // 
            // tbNameTp2
            // 
            tbNameTp2.Location = new Point(22, 28);
            tbNameTp2.Name = "tbNameTp2";
            tbNameTp2.Size = new Size(215, 26);
            tbNameTp2.TabIndex = 30;
            // 
            // lbLastNameTp2
            // 
            lbLastNameTp2.Font = new Font("Oswald", 9.75F);
            lbLastNameTp2.ForeColor = Color.LemonChiffon;
            lbLastNameTp2.ImeMode = ImeMode.NoControl;
            lbLastNameTp2.Location = new Point(22, 57);
            lbLastNameTp2.Name = "lbLastNameTp2";
            lbLastNameTp2.Size = new Size(215, 24);
            lbLastNameTp2.TabIndex = 33;
            lbLastNameTp2.Text = "Nombre";
            lbLastNameTp2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbNameTp2
            // 
            lbNameTp2.Font = new Font("Oswald", 9.75F);
            lbNameTp2.ForeColor = Color.LemonChiffon;
            lbNameTp2.ImeMode = ImeMode.NoControl;
            lbNameTp2.Location = new Point(22, 2);
            lbNameTp2.Name = "lbNameTp2";
            lbNameTp2.Size = new Size(215, 24);
            lbNameTp2.TabIndex = 31;
            lbNameTp2.Text = "ID del Producto";
            lbNameTp2.TextAlign = ContentAlignment.MiddleLeft;
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
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.InactiveCaption;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(613, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 205);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
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
            lbOptions.Text = "- Productos -";
            lbOptions.TextAlign = ContentAlignment.MiddleCenter;
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
            tp2Add.ResumeLayout(false);
            tp2Add.PerformLayout();
            gbSelectOption.ResumeLayout(false);
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
        private Label label1;
        private RichTextBox richTextBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
    }
}