namespace El_Eden
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            lbElEden = new Label();
            lbWelcome = new Label();
            lbDateTime = new Label();
            lbSells = new Label();
            lbClients = new Label();
            lbPromotions = new Label();
            lbProducts = new Label();
            lbHome = new Label();
            lbUsers = new Label();
            gbSelectOption = new GroupBox();
            pnlUpperTool = new Panel();
            btnReturn = new Button();
            btnMinimize = new Button();
            btnClose = new Button();
            timerDateTime = new System.Windows.Forms.Timer(components);
            gbWelcome = new GroupBox();
            gbSelectOption.SuspendLayout();
            pnlUpperTool.SuspendLayout();
            gbWelcome.SuspendLayout();
            SuspendLayout();
            // 
            // lbElEden
            // 
            resources.ApplyResources(lbElEden, "lbElEden");
            lbElEden.ForeColor = Color.LemonChiffon;
            lbElEden.Name = "lbElEden";
            // 
            // lbWelcome
            // 
            resources.ApplyResources(lbWelcome, "lbWelcome");
            lbWelcome.ForeColor = Color.LemonChiffon;
            lbWelcome.Name = "lbWelcome";
            // 
            // lbDateTime
            // 
            resources.ApplyResources(lbDateTime, "lbDateTime");
            lbDateTime.ForeColor = Color.LemonChiffon;
            lbDateTime.Name = "lbDateTime";
            // 
            // lbSells
            // 
            resources.ApplyResources(lbSells, "lbSells");
            lbSells.ForeColor = Color.LemonChiffon;
            lbSells.Name = "lbSells";
            lbSells.MouseEnter += label_MouseEnter;
            lbSells.MouseLeave += label_MouseLeave;
            // 
            // lbClients
            // 
            resources.ApplyResources(lbClients, "lbClients");
            lbClients.ForeColor = Color.LemonChiffon;
            lbClients.Name = "lbClients";
            lbClients.Click += lbClientes_Click;
            lbClients.MouseEnter += label_MouseEnter;
            lbClients.MouseLeave += label_MouseLeave;
            // 
            // lbPromotions
            // 
            resources.ApplyResources(lbPromotions, "lbPromotions");
            lbPromotions.ForeColor = Color.LemonChiffon;
            lbPromotions.Name = "lbPromotions";
            lbPromotions.MouseEnter += label_MouseEnter;
            lbPromotions.MouseLeave += label_MouseLeave;
            // 
            // lbProducts
            // 
            resources.ApplyResources(lbProducts, "lbProducts");
            lbProducts.ForeColor = Color.LemonChiffon;
            lbProducts.Name = "lbProducts";
            lbProducts.MouseEnter += label_MouseEnter;
            lbProducts.MouseLeave += label_MouseLeave;
            // 
            // lbHome
            // 
            resources.ApplyResources(lbHome, "lbHome");
            lbHome.ForeColor = Color.LemonChiffon;
            lbHome.Name = "lbHome";
            // 
            // lbUsers
            // 
            resources.ApplyResources(lbUsers, "lbUsers");
            lbUsers.ForeColor = Color.LemonChiffon;
            lbUsers.Name = "lbUsers";
            lbUsers.MouseEnter += label_MouseEnter;
            lbUsers.MouseLeave += label_MouseLeave;
            // 
            // gbSelectOption
            // 
            gbSelectOption.Controls.Add(lbSells);
            gbSelectOption.Controls.Add(lbUsers);
            gbSelectOption.Controls.Add(lbClients);
            gbSelectOption.Controls.Add(lbProducts);
            gbSelectOption.Controls.Add(lbPromotions);
            resources.ApplyResources(gbSelectOption, "gbSelectOption");
            gbSelectOption.ForeColor = Color.LemonChiffon;
            gbSelectOption.Name = "gbSelectOption";
            gbSelectOption.TabStop = false;
            // 
            // pnlUpperTool
            // 
            pnlUpperTool.BackColor = Color.LemonChiffon;
            pnlUpperTool.Controls.Add(btnReturn);
            pnlUpperTool.Controls.Add(btnMinimize);
            pnlUpperTool.Controls.Add(btnClose);
            resources.ApplyResources(pnlUpperTool, "pnlUpperTool");
            pnlUpperTool.Name = "pnlUpperTool";
            pnlUpperTool.MouseDown += pnlUpperTool_MouseDown;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Black;
            btnReturn.ForeColor = Color.LemonChiffon;
            resources.ApplyResources(btnReturn, "btnReturn");
            btnReturn.Name = "btnReturn";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Black;
            resources.ApplyResources(btnMinimize, "btnMinimize");
            btnMinimize.ForeColor = Color.LemonChiffon;
            btnMinimize.Name = "btnMinimize";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Black;
            btnClose.ForeColor = Color.LemonChiffon;
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.Name = "btnClose";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // timerDateTime
            // 
            timerDateTime.Interval = 1000;
            timerDateTime.Tick += timerDateTime_Tick;
            // 
            // gbWelcome
            // 
            gbWelcome.Controls.Add(lbWelcome);
            gbWelcome.Controls.Add(lbDateTime);
            resources.ApplyResources(gbWelcome, "gbWelcome");
            gbWelcome.ForeColor = Color.LemonChiffon;
            gbWelcome.Name = "gbWelcome";
            gbWelcome.TabStop = false;
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(gbWelcome);
            Controls.Add(pnlUpperTool);
            Controls.Add(gbSelectOption);
            Controls.Add(lbHome);
            Controls.Add(lbElEden);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "MainMenu";
            VisibleChanged += MainMenu_VisibleChanged;
            gbSelectOption.ResumeLayout(false);
            gbSelectOption.PerformLayout();
            pnlUpperTool.ResumeLayout(false);
            gbWelcome.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbElEden;
        private Label lbWelcome;
        private Label lbDateTime;
        private Label lbSells;
        private Label lbClients;
        private Label lbPromotions;
        private Label lbProducts;
        private Label lbHome;
        private Label lbUsers;
        private GroupBox gbSelectOption;
        private Panel pnlUpperTool;
        private Button btnClose;
        private Button btnMinimize;
        private Button button1;
        private Button btnReturn;
        private System.Windows.Forms.Timer timerDateTime;
        private GroupBox gbWelcome;
    }
}