namespace El_Eden.Forms.Clients
{
    partial class ClientsMenu
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            pnlUpperTool = new Panel();
            btnReturn = new Button();
            btnMinimize = new Button();
            btnClose = new Button();
            lbClients = new Label();
            lbElEden = new Label();
            gbSelectOption = new GroupBox();
            lbHelp = new Label();
            tcClients = new TabControl();
            tp1Search = new TabPage();
            btnDeleteTp1 = new Button();
            btnModifyTp1 = new Button();
            btnSearchTp1 = new Button();
            tbNeighborhoodTp1 = new TextBox();
            tbLastNameTp1 = new TextBox();
            tbNameTp1 = new TextBox();
            lbNeighborhoodTp1 = new Label();
            lbLastNameTp1 = new Label();
            lbNameTp1 = new Label();
            tp2Add = new TabPage();
            tbEmailTp2 = new TextBox();
            lbEmailTp2 = new Label();
            btnAddClientTp2 = new Button();
            tbPhoneTp2 = new TextBox();
            tbNeighborhoodTp2 = new TextBox();
            tbAddressTp2 = new TextBox();
            tbLastNameTp2 = new TextBox();
            tbNameTp2 = new TextBox();
            lbPhoneTp2 = new Label();
            lbNeighborhoodTp2 = new Label();
            lbAddressTp2 = new Label();
            lbLastNameTp2 = new Label();
            lbNameTp2 = new Label();
            dgvClients = new DataGridView();
            dgvCol0 = new DataGridViewTextBoxColumn();
            dgvCol1 = new DataGridViewTextBoxColumn();
            dgvCol2 = new DataGridViewTextBoxColumn();
            dgvCol3 = new DataGridViewTextBoxColumn();
            dgvCol4 = new DataGridViewTextBoxColumn();
            dgvCol5 = new DataGridViewTextBoxColumn();
            dgvCol6 = new DataGridViewTextBoxColumn();
            dgvCol7 = new DataGridViewTextBoxColumn();
            dgvCol8 = new DataGridViewCheckBoxColumn();
            lbOptions = new Label();
            gpWelcome = new GroupBox();
            lbWelcome = new Label();
            lbDateTime = new Label();
            timerDateTime = new System.Windows.Forms.Timer(components);
            pnlUpperTool.SuspendLayout();
            gbSelectOption.SuspendLayout();
            tcClients.SuspendLayout();
            tp1Search.SuspendLayout();
            tp2Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            gpWelcome.SuspendLayout();
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
            pnlUpperTool.TabIndex = 19;
            pnlUpperTool.MouseDown += pnlUpperTool_MouseDown;
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
            btnReturn.Click += btnReturn_Click;
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
            btnMinimize.Click += btnMinimize_Click;
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
            btnClose.Click += btnClose_Click;
            // 
            // lbClients
            // 
            lbClients.AutoSize = true;
            lbClients.Font = new Font("Oswald", 9.75F);
            lbClients.ForeColor = Color.LemonChiffon;
            lbClients.ImeMode = ImeMode.NoControl;
            lbClients.Location = new Point(696, 112);
            lbClients.Name = "lbClients";
            lbClients.Size = new Size(50, 20);
            lbClients.TabIndex = 21;
            lbClients.Text = "Clientes";
            // 
            // lbElEden
            // 
            lbElEden.AutoSize = true;
            lbElEden.Font = new Font("Times New Roman", 36F, FontStyle.Bold);
            lbElEden.ForeColor = Color.LemonChiffon;
            lbElEden.ImeMode = ImeMode.NoControl;
            lbElEden.Location = new Point(605, 57);
            lbElEden.Name = "lbElEden";
            lbElEden.Size = new Size(243, 55);
            lbElEden.TabIndex = 20;
            lbElEden.Text = "- El Eden -";
            // 
            // gbSelectOption
            // 
            gbSelectOption.Controls.Add(lbHelp);
            gbSelectOption.Controls.Add(tcClients);
            gbSelectOption.Controls.Add(dgvClients);
            gbSelectOption.Font = new Font("Times New Roman", 12F, FontStyle.Italic);
            gbSelectOption.ForeColor = Color.LemonChiffon;
            gbSelectOption.Location = new Point(12, 148);
            gbSelectOption.Name = "gbSelectOption";
            gbSelectOption.Size = new Size(836, 590);
            gbSelectOption.TabIndex = 22;
            gbSelectOption.TabStop = false;
            gbSelectOption.Text = "Seleccione una opción:";
            // 
            // lbHelp
            // 
            lbHelp.Font = new Font("Oswald", 9.75F);
            lbHelp.ForeColor = Color.LemonChiffon;
            lbHelp.ImeMode = ImeMode.NoControl;
            lbHelp.Location = new Point(663, 22);
            lbHelp.Name = "lbHelp";
            lbHelp.Size = new Size(155, 24);
            lbHelp.TabIndex = 35;
            lbHelp.Text = "( * ) CAMPOS OBLIGATORIOS";
            lbHelp.TextAlign = ContentAlignment.MiddleLeft;
            lbHelp.Visible = false;
            // 
            // tcClients
            // 
            tcClients.Controls.Add(tp1Search);
            tcClients.Controls.Add(tp2Add);
            tcClients.Location = new Point(16, 25);
            tcClients.Name = "tcClients";
            tcClients.SelectedIndex = 0;
            tcClients.Size = new Size(802, 174);
            tcClients.TabIndex = 25;
            tcClients.SelectedIndexChanged += tcClients_SelectedIndexChanged;
            // 
            // tp1Search
            // 
            tp1Search.BackColor = Color.Black;
            tp1Search.Controls.Add(btnDeleteTp1);
            tp1Search.Controls.Add(btnModifyTp1);
            tp1Search.Controls.Add(btnSearchTp1);
            tp1Search.Controls.Add(tbNeighborhoodTp1);
            tp1Search.Controls.Add(tbLastNameTp1);
            tp1Search.Controls.Add(tbNameTp1);
            tp1Search.Controls.Add(lbNeighborhoodTp1);
            tp1Search.Controls.Add(lbLastNameTp1);
            tp1Search.Controls.Add(lbNameTp1);
            tp1Search.Location = new Point(4, 28);
            tp1Search.Name = "tp1Search";
            tp1Search.Padding = new Padding(3);
            tp1Search.Size = new Size(794, 142);
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
            btnDeleteTp1.Location = new Point(664, 87);
            btnDeleteTp1.Name = "btnDeleteTp1";
            btnDeleteTp1.Size = new Size(115, 34);
            btnDeleteTp1.TabIndex = 32;
            btnDeleteTp1.Text = "ELIMINAR";
            btnDeleteTp1.UseVisualStyleBackColor = false;
            btnDeleteTp1.Click += btnDeleteTp1_Click;
            // 
            // btnModifyTp1
            // 
            btnModifyTp1.BackColor = Color.Black;
            btnModifyTp1.FlatAppearance.BorderSize = 2;
            btnModifyTp1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifyTp1.ForeColor = Color.LemonChiffon;
            btnModifyTp1.Location = new Point(533, 87);
            btnModifyTp1.Name = "btnModifyTp1";
            btnModifyTp1.Size = new Size(115, 34);
            btnModifyTp1.TabIndex = 31;
            btnModifyTp1.Text = "MODIFICAR";
            btnModifyTp1.UseVisualStyleBackColor = false;
            btnModifyTp1.Click += btnModifyTp1_Click;
            // 
            // btnSearchTp1
            // 
            btnSearchTp1.BackColor = Color.LemonChiffon;
            btnSearchTp1.FlatAppearance.BorderSize = 2;
            btnSearchTp1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSearchTp1.ForeColor = Color.Black;
            btnSearchTp1.Location = new Point(405, 87);
            btnSearchTp1.Name = "btnSearchTp1";
            btnSearchTp1.Size = new Size(115, 34);
            btnSearchTp1.TabIndex = 20;
            btnSearchTp1.Text = "BUSCAR";
            btnSearchTp1.UseVisualStyleBackColor = false;
            btnSearchTp1.Click += btnSearchTp1_Click;
            // 
            // tbNeighborhoodTp1
            // 
            tbNeighborhoodTp1.Location = new Point(405, 40);
            tbNeighborhoodTp1.Name = "tbNeighborhoodTp1";
            tbNeighborhoodTp1.Size = new Size(374, 26);
            tbNeighborhoodTp1.TabIndex = 28;
            tbNeighborhoodTp1.TextChanged += textBox_TextChanged;
            // 
            // tbLastNameTp1
            // 
            tbLastNameTp1.Location = new Point(15, 95);
            tbLastNameTp1.Name = "tbLastNameTp1";
            tbLastNameTp1.Size = new Size(374, 26);
            tbLastNameTp1.TabIndex = 22;
            tbLastNameTp1.TextChanged += textBox_TextChanged;
            // 
            // tbNameTp1
            // 
            tbNameTp1.Location = new Point(15, 40);
            tbNameTp1.Name = "tbNameTp1";
            tbNameTp1.Size = new Size(374, 26);
            tbNameTp1.TabIndex = 20;
            tbNameTp1.TextChanged += textBox_TextChanged;
            // 
            // lbNeighborhoodTp1
            // 
            lbNeighborhoodTp1.Font = new Font("Oswald", 9.75F);
            lbNeighborhoodTp1.ForeColor = Color.LemonChiffon;
            lbNeighborhoodTp1.ImeMode = ImeMode.NoControl;
            lbNeighborhoodTp1.Location = new Point(405, 13);
            lbNeighborhoodTp1.Name = "lbNeighborhoodTp1";
            lbNeighborhoodTp1.Size = new Size(374, 24);
            lbNeighborhoodTp1.TabIndex = 27;
            lbNeighborhoodTp1.Text = "Barrrio";
            lbNeighborhoodTp1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbLastNameTp1
            // 
            lbLastNameTp1.Font = new Font("Oswald", 9.75F);
            lbLastNameTp1.ForeColor = Color.LemonChiffon;
            lbLastNameTp1.ImeMode = ImeMode.NoControl;
            lbLastNameTp1.Location = new Point(15, 68);
            lbLastNameTp1.Name = "lbLastNameTp1";
            lbLastNameTp1.Size = new Size(374, 24);
            lbLastNameTp1.TabIndex = 23;
            lbLastNameTp1.Text = "Apellido";
            lbLastNameTp1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbNameTp1
            // 
            lbNameTp1.Font = new Font("Oswald", 9.75F);
            lbNameTp1.ForeColor = Color.LemonChiffon;
            lbNameTp1.ImeMode = ImeMode.NoControl;
            lbNameTp1.Location = new Point(15, 14);
            lbNameTp1.Name = "lbNameTp1";
            lbNameTp1.Size = new Size(374, 24);
            lbNameTp1.TabIndex = 21;
            lbNameTp1.Text = "Nombre";
            lbNameTp1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tp2Add
            // 
            tp2Add.BackColor = Color.Black;
            tp2Add.Controls.Add(tbEmailTp2);
            tp2Add.Controls.Add(lbEmailTp2);
            tp2Add.Controls.Add(btnAddClientTp2);
            tp2Add.Controls.Add(tbPhoneTp2);
            tp2Add.Controls.Add(tbNeighborhoodTp2);
            tp2Add.Controls.Add(tbAddressTp2);
            tp2Add.Controls.Add(tbLastNameTp2);
            tp2Add.Controls.Add(tbNameTp2);
            tp2Add.Controls.Add(lbPhoneTp2);
            tp2Add.Controls.Add(lbNeighborhoodTp2);
            tp2Add.Controls.Add(lbAddressTp2);
            tp2Add.Controls.Add(lbLastNameTp2);
            tp2Add.Controls.Add(lbNameTp2);
            tp2Add.Location = new Point(4, 28);
            tp2Add.Name = "tp2Add";
            tp2Add.Padding = new Padding(3);
            tp2Add.Size = new Size(794, 142);
            tp2Add.TabIndex = 1;
            tp2Add.Text = "AGREGAR";
            // 
            // tbEmailTp2
            // 
            tbEmailTp2.Location = new Point(441, 94);
            tbEmailTp2.Name = "tbEmailTp2";
            tbEmailTp2.Size = new Size(331, 26);
            tbEmailTp2.TabIndex = 42;
            tbEmailTp2.TextChanged += textBox_TextChanged;
            // 
            // lbEmailTp2
            // 
            lbEmailTp2.Font = new Font("Oswald", 9.75F);
            lbEmailTp2.ForeColor = Color.LemonChiffon;
            lbEmailTp2.ImeMode = ImeMode.NoControl;
            lbEmailTp2.Location = new Point(441, 67);
            lbEmailTp2.Name = "lbEmailTp2";
            lbEmailTp2.Size = new Size(331, 24);
            lbEmailTp2.TabIndex = 41;
            lbEmailTp2.Text = "Email";
            lbEmailTp2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAddClientTp2
            // 
            btnAddClientTp2.BackColor = Color.LemonChiffon;
            btnAddClientTp2.FlatAppearance.BorderSize = 2;
            btnAddClientTp2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnAddClientTp2.ForeColor = Color.Black;
            btnAddClientTp2.Location = new Point(642, 30);
            btnAddClientTp2.Name = "btnAddClientTp2";
            btnAddClientTp2.Size = new Size(130, 34);
            btnAddClientTp2.TabIndex = 40;
            btnAddClientTp2.Text = "Agregar Cliente";
            btnAddClientTp2.UseVisualStyleBackColor = false;
            btnAddClientTp2.Click += btnAddClientTp2_Click;
            // 
            // tbPhoneTp2
            // 
            tbPhoneTp2.Location = new Point(441, 38);
            tbPhoneTp2.Name = "tbPhoneTp2";
            tbPhoneTp2.Size = new Size(183, 26);
            tbPhoneTp2.TabIndex = 39;
            tbPhoneTp2.TextChanged += textBox_TextChanged;
            // 
            // tbNeighborhoodTp2
            // 
            tbNeighborhoodTp2.Location = new Point(197, 94);
            tbNeighborhoodTp2.Name = "tbNeighborhoodTp2";
            tbNeighborhoodTp2.Size = new Size(227, 26);
            tbNeighborhoodTp2.TabIndex = 37;
            tbNeighborhoodTp2.TextChanged += textBox_TextChanged;
            // 
            // tbAddressTp2
            // 
            tbAddressTp2.Location = new Point(197, 38);
            tbAddressTp2.Name = "tbAddressTp2";
            tbAddressTp2.Size = new Size(227, 26);
            tbAddressTp2.TabIndex = 35;
            tbAddressTp2.TextChanged += textBox_TextChanged;
            // 
            // tbLastNameTp2
            // 
            tbLastNameTp2.Location = new Point(18, 94);
            tbLastNameTp2.Name = "tbLastNameTp2";
            tbLastNameTp2.Size = new Size(166, 26);
            tbLastNameTp2.TabIndex = 32;
            tbLastNameTp2.TextChanged += textBox_TextChanged;
            // 
            // tbNameTp2
            // 
            tbNameTp2.Location = new Point(18, 38);
            tbNameTp2.Name = "tbNameTp2";
            tbNameTp2.Size = new Size(166, 26);
            tbNameTp2.TabIndex = 30;
            tbNameTp2.TextChanged += textBox_TextChanged;
            // 
            // lbPhoneTp2
            // 
            lbPhoneTp2.Font = new Font("Oswald", 9.75F);
            lbPhoneTp2.ForeColor = Color.LemonChiffon;
            lbPhoneTp2.ImeMode = ImeMode.NoControl;
            lbPhoneTp2.Location = new Point(441, 11);
            lbPhoneTp2.Name = "lbPhoneTp2";
            lbPhoneTp2.Size = new Size(166, 24);
            lbPhoneTp2.TabIndex = 38;
            lbPhoneTp2.Text = "Teléfono *";
            lbPhoneTp2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbNeighborhoodTp2
            // 
            lbNeighborhoodTp2.Font = new Font("Oswald", 9.75F);
            lbNeighborhoodTp2.ForeColor = Color.LemonChiffon;
            lbNeighborhoodTp2.ImeMode = ImeMode.NoControl;
            lbNeighborhoodTp2.Location = new Point(197, 67);
            lbNeighborhoodTp2.Name = "lbNeighborhoodTp2";
            lbNeighborhoodTp2.Size = new Size(227, 24);
            lbNeighborhoodTp2.TabIndex = 36;
            lbNeighborhoodTp2.Text = "Barrrio";
            lbNeighborhoodTp2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbAddressTp2
            // 
            lbAddressTp2.Font = new Font("Oswald", 9.75F);
            lbAddressTp2.ForeColor = Color.LemonChiffon;
            lbAddressTp2.ImeMode = ImeMode.NoControl;
            lbAddressTp2.Location = new Point(197, 10);
            lbAddressTp2.Name = "lbAddressTp2";
            lbAddressTp2.Size = new Size(227, 24);
            lbAddressTp2.TabIndex = 34;
            lbAddressTp2.Text = "Dirección *";
            lbAddressTp2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbLastNameTp2
            // 
            lbLastNameTp2.Font = new Font("Oswald", 9.75F);
            lbLastNameTp2.ForeColor = Color.LemonChiffon;
            lbLastNameTp2.ImeMode = ImeMode.NoControl;
            lbLastNameTp2.Location = new Point(18, 67);
            lbLastNameTp2.Name = "lbLastNameTp2";
            lbLastNameTp2.Size = new Size(166, 24);
            lbLastNameTp2.TabIndex = 33;
            lbLastNameTp2.Text = "Apellido";
            lbLastNameTp2.TextAlign = ContentAlignment.MiddleLeft;
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
            lbNameTp2.Text = "Nombre *";
            lbNameTp2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvClients
            // 
            dgvClients.BackgroundColor = Color.LemonChiffon;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Columns.AddRange(new DataGridViewColumn[] { dgvCol0, dgvCol1, dgvCol2, dgvCol3, dgvCol4, dgvCol5, dgvCol6, dgvCol7, dgvCol8 });
            dgvClients.Location = new Point(16, 216);
            dgvClients.Name = "dgvClients";
            dgvClients.Size = new Size(802, 359);
            dgvClients.TabIndex = 17;
            dgvClients.CellValueChanged += dgvClients_CellValueChanged;
            // 
            // dgvCol0
            // 
            dgvCol0.HeaderText = "Cliente_ID";
            dgvCol0.Name = "dgvCol0";
            dgvCol0.ReadOnly = true;
            dgvCol0.Resizable = DataGridViewTriState.False;
            dgvCol0.Visible = false;
            // 
            // dgvCol1
            // 
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dgvCol1.DefaultCellStyle = dataGridViewCellStyle8;
            dgvCol1.HeaderText = "Nombre";
            dgvCol1.Name = "dgvCol1";
            dgvCol1.ReadOnly = true;
            // 
            // dgvCol2
            // 
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dgvCol2.DefaultCellStyle = dataGridViewCellStyle9;
            dgvCol2.HeaderText = "Apellido";
            dgvCol2.Name = "dgvCol2";
            dgvCol2.ReadOnly = true;
            // 
            // dgvCol3
            // 
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dgvCol3.DefaultCellStyle = dataGridViewCellStyle10;
            dgvCol3.HeaderText = "Número (Tel)";
            dgvCol3.Name = "dgvCol3";
            dgvCol3.ReadOnly = true;
            dgvCol3.Width = 160;
            // 
            // dgvCol4
            // 
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dgvCol4.DefaultCellStyle = dataGridViewCellStyle11;
            dgvCol4.HeaderText = "Email";
            dgvCol4.Name = "dgvCol4";
            dgvCol4.ReadOnly = true;
            dgvCol4.Width = 250;
            // 
            // dgvCol5
            // 
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dgvCol5.DefaultCellStyle = dataGridViewCellStyle12;
            dgvCol5.HeaderText = "Dirección";
            dgvCol5.Name = "dgvCol5";
            dgvCol5.ReadOnly = true;
            // 
            // dgvCol6
            // 
            dataGridViewCellStyle13.ForeColor = Color.Black;
            dgvCol6.DefaultCellStyle = dataGridViewCellStyle13;
            dgvCol6.HeaderText = "Barrio";
            dgvCol6.Name = "dgvCol6";
            dgvCol6.ReadOnly = true;
            // 
            // dgvCol7
            // 
            dataGridViewCellStyle14.ForeColor = Color.Black;
            dgvCol7.DefaultCellStyle = dataGridViewCellStyle14;
            dgvCol7.HeaderText = "Total Facturado";
            dgvCol7.Name = "dgvCol7";
            dgvCol7.ReadOnly = true;
            dgvCol7.Width = 160;
            // 
            // dgvCol8
            // 
            dgvCol8.FalseValue = "false";
            dgvCol8.HeaderText = "";
            dgvCol8.IndeterminateValue = "false";
            dgvCol8.Name = "dgvCol8";
            dgvCol8.Resizable = DataGridViewTriState.True;
            dgvCol8.SortMode = DataGridViewColumnSortMode.Automatic;
            dgvCol8.TrueValue = "true";
            dgvCol8.Visible = false;
            dgvCol8.Width = 40;
            // 
            // lbOptions
            // 
            lbOptions.BackColor = Color.Transparent;
            lbOptions.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbOptions.ForeColor = Color.LemonChiffon;
            lbOptions.ImeMode = ImeMode.NoControl;
            lbOptions.Location = new Point(0, 73);
            lbOptions.Name = "lbOptions";
            lbOptions.Size = new Size(866, 38);
            lbOptions.TabIndex = 15;
            lbOptions.Text = "- Buscar Clientes -";
            lbOptions.TextAlign = ContentAlignment.MiddleCenter;
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
            gpWelcome.TabIndex = 23;
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
            // timerDateTime
            // 
            timerDateTime.Interval = 1000;
            timerDateTime.Tick += timerDateTime_Tick;
            // 
            // ClientsMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(860, 754);
            Controls.Add(lbElEden);
            Controls.Add(gpWelcome);
            Controls.Add(lbOptions);
            Controls.Add(gbSelectOption);
            Controls.Add(lbClients);
            Controls.Add(pnlUpperTool);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "ClientsMenu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ClientesMenu";
            pnlUpperTool.ResumeLayout(false);
            gbSelectOption.ResumeLayout(false);
            tcClients.ResumeLayout(false);
            tp1Search.ResumeLayout(false);
            tp1Search.PerformLayout();
            tp2Add.ResumeLayout(false);
            tp2Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            gpWelcome.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlUpperTool;
        private Button btnReturn;
        private Button btnMinimize;
        private Button btnClose;
        private Label lbClients;
        private Label lbElEden;
        private GroupBox gbSelectOption;
        private Label lbOptions;
        private GroupBox gpWelcome;
        private Label lbWelcome;
        private Label lbDateTime;
        private System.Windows.Forms.Timer timerDateTime;
        private ComboBox cbOptions;
        private DataGridView dgvClients;
        private Label lbHelp;
        private TabControl tcClients;
        private TabPage tp1Search;
        private Button btnDeleteTp1;
        private Button btnModifyTp1;
        private Button btnSearchTp1;
        private TextBox tbNeighborhoodTp1;
        private TextBox tbLastNameTp1;
        private TextBox tbNameTp1;
        private Label lbNeighborhoodTp1;
        private Label lbLastNameTp1;
        private Label lbNameTp1;
        private TabPage tp2Add;
        private Button btnAddClientTp2;
        private TextBox tbPhoneTp2;
        private TextBox tbNeighborhoodTp2;
        private TextBox tbAddressTp2;
        private TextBox tbLastNameTp2;
        private TextBox tbNameTp2;
        private Label lbPhoneTp2;
        private Label lbNeighborhoodTp2;
        private Label lbAddressTp2;
        private Label lbLastNameTp2;
        private Label lbNameTp2;
        private TextBox tbEmailTp2;
        private Label lbEmailTp2;
        private DataGridViewTextBoxColumn dgvCol0;
        private DataGridViewTextBoxColumn dgvCol1;
        private DataGridViewTextBoxColumn dgvCol2;
        private DataGridViewTextBoxColumn dgvCol3;
        private DataGridViewTextBoxColumn dgvCol4;
        private DataGridViewTextBoxColumn dgvCol5;
        private DataGridViewTextBoxColumn dgvCol6;
        private DataGridViewTextBoxColumn dgvCol7;
        private DataGridViewCheckBoxColumn dgvCol8;
    }
}