namespace NewsPortal.Forms
{
    partial class Portal_Home_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portal_Home_Form));
            this.title_bar_panel = new System.Windows.Forms.Panel();
            this.title_label = new System.Windows.Forms.Label();
            this.info_button = new System.Windows.Forms.Button();
            this.minimize_button = new System.Windows.Forms.Button();
            this.resize_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.Menu_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.home_button = new System.Windows.Forms.Button();
            this.personal_info_button = new System.Windows.Forms.Button();
            this.favorite_list_button = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.home_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.personal_info_panel = new System.Windows.Forms.Panel();
            this.lower_bar_pi_panel = new System.Windows.Forms.Panel();
            this.Save_pi_button = new System.Windows.Forms.Button();
            this.personal_info_close_button = new System.Windows.Forms.Button();
            this.page_pi_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.title_pi_panel = new System.Windows.Forms.Panel();
            this.first_name_panel = new System.Windows.Forms.Panel();
            this.first_name_textBox = new System.Windows.Forms.TextBox();
            this.fn_label = new System.Windows.Forms.Label();
            this.last_name_panel = new System.Windows.Forms.Panel();
            this.last_name_textBox = new System.Windows.Forms.TextBox();
            this.ln_label = new System.Windows.Forms.Label();
            this.password_panel = new System.Windows.Forms.Panel();
            this.pi_dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass_label = new System.Windows.Forms.Label();
            this.favorite_list_panel = new System.Windows.Forms.Panel();
            this.lower_bar_fl_panel = new System.Windows.Forms.Panel();
            this.favorite_list_close_button = new System.Windows.Forms.Button();
            this.page_fl_panel = new System.Windows.Forms.Panel();
            this.fl_listView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.info_panel = new System.Windows.Forms.Panel();
            this.home_quote = new System.Windows.Forms.Label();
            this.info_close_button = new System.Windows.Forms.Button();
            this.title_bar_panel.SuspendLayout();
            this.Menu_Panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.home_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.personal_info_panel.SuspendLayout();
            this.lower_bar_pi_panel.SuspendLayout();
            this.page_pi_Panel.SuspendLayout();
            this.first_name_panel.SuspendLayout();
            this.last_name_panel.SuspendLayout();
            this.password_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pi_dataGridView)).BeginInit();
            this.favorite_list_panel.SuspendLayout();
            this.lower_bar_fl_panel.SuspendLayout();
            this.page_fl_panel.SuspendLayout();
            this.info_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_bar_panel
            // 
            this.title_bar_panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.title_bar_panel.Controls.Add(this.title_label);
            this.title_bar_panel.Controls.Add(this.info_button);
            this.title_bar_panel.Controls.Add(this.minimize_button);
            this.title_bar_panel.Controls.Add(this.resize_button);
            this.title_bar_panel.Controls.Add(this.close_button);
            this.title_bar_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_bar_panel.Location = new System.Drawing.Point(0, 0);
            this.title_bar_panel.Margin = new System.Windows.Forms.Padding(2);
            this.title_bar_panel.Name = "title_bar_panel";
            this.title_bar_panel.Size = new System.Drawing.Size(836, 42);
            this.title_bar_panel.TabIndex = 0;
            this.title_bar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.title_bar_panel_Paint);
            this.title_bar_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_bar_panel_MouseDown);
            this.title_bar_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_bar_panel_MouseMove);
            this.title_bar_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_bar_panel_MouseUp);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(285, 6);
            this.title_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(270, 31);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "The Daily Chronicle";
            // 
            // info_button
            // 
            this.info_button.BackgroundImage = global::NewsPortal.Properties.Resources.info;
            this.info_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.info_button.FlatAppearance.BorderSize = 0;
            this.info_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info_button.Location = new System.Drawing.Point(8, 4);
            this.info_button.Margin = new System.Windows.Forms.Padding(2);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(41, 36);
            this.info_button.TabIndex = 0;
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // minimize_button
            // 
            this.minimize_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_button.BackgroundImage = global::NewsPortal.Properties.Resources.minus;
            this.minimize_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize_button.FlatAppearance.BorderSize = 0;
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_button.Location = new System.Drawing.Point(699, 4);
            this.minimize_button.Margin = new System.Windows.Forms.Padding(2);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(41, 36);
            this.minimize_button.TabIndex = 0;
            this.minimize_button.UseVisualStyleBackColor = true;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            // 
            // resize_button
            // 
            this.resize_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resize_button.BackgroundImage = global::NewsPortal.Properties.Resources.resize;
            this.resize_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.resize_button.FlatAppearance.BorderSize = 0;
            this.resize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resize_button.Location = new System.Drawing.Point(743, 4);
            this.resize_button.Margin = new System.Windows.Forms.Padding(2);
            this.resize_button.Name = "resize_button";
            this.resize_button.Size = new System.Drawing.Size(41, 36);
            this.resize_button.TabIndex = 0;
            this.resize_button.UseVisualStyleBackColor = true;
            this.resize_button.Click += new System.EventHandler(this.resize_button_Click);
            // 
            // close_button
            // 
            this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_button.BackgroundImage = global::NewsPortal.Properties.Resources.cross;
            this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Location = new System.Drawing.Point(787, 4);
            this.close_button.Margin = new System.Windows.Forms.Padding(2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(41, 36);
            this.close_button.TabIndex = 0;
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Menu_Panel
            // 
            this.Menu_Panel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Menu_Panel.Controls.Add(this.home_button);
            this.Menu_Panel.Controls.Add(this.personal_info_button);
            this.Menu_Panel.Controls.Add(this.favorite_list_button);
            this.Menu_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Menu_Panel.Location = new System.Drawing.Point(0, 42);
            this.Menu_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Menu_Panel.Name = "Menu_Panel";
            this.Menu_Panel.Size = new System.Drawing.Size(170, 450);
            this.Menu_Panel.TabIndex = 3;
            // 
            // home_button
            // 
            this.home_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.home_button.FlatAppearance.BorderSize = 0;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.home_button.Image = global::NewsPortal.Properties.Resources.home_64;
            this.home_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.home_button.Location = new System.Drawing.Point(2, 13);
            this.home_button.Margin = new System.Windows.Forms.Padding(2, 13, 2, 2);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(168, 143);
            this.home_button.TabIndex = 1;
            this.home_button.Text = "Home";
            this.home_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.home_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // personal_info_button
            // 
            this.personal_info_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.personal_info_button.FlatAppearance.BorderSize = 0;
            this.personal_info_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personal_info_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personal_info_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.personal_info_button.Image = global::NewsPortal.Properties.Resources.personal_info_64;
            this.personal_info_button.Location = new System.Drawing.Point(2, 160);
            this.personal_info_button.Margin = new System.Windows.Forms.Padding(2);
            this.personal_info_button.Name = "personal_info_button";
            this.personal_info_button.Size = new System.Drawing.Size(168, 120);
            this.personal_info_button.TabIndex = 0;
            this.personal_info_button.Text = "Personal Info";
            this.personal_info_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.personal_info_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.personal_info_button.UseVisualStyleBackColor = true;
            this.personal_info_button.Click += new System.EventHandler(this.personal_info_button_Click);
            // 
            // favorite_list_button
            // 
            this.favorite_list_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.favorite_list_button.FlatAppearance.BorderSize = 0;
            this.favorite_list_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favorite_list_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favorite_list_button.ForeColor = System.Drawing.Color.IndianRed;
            this.favorite_list_button.Image = global::NewsPortal.Properties.Resources.lover_64;
            this.favorite_list_button.Location = new System.Drawing.Point(2, 284);
            this.favorite_list_button.Margin = new System.Windows.Forms.Padding(2);
            this.favorite_list_button.Name = "favorite_list_button";
            this.favorite_list_button.Size = new System.Drawing.Size(168, 120);
            this.favorite_list_button.TabIndex = 1;
            this.favorite_list_button.Text = "Favorite List";
            this.favorite_list_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.favorite_list_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.favorite_list_button.UseVisualStyleBackColor = true;
            this.favorite_list_button.Click += new System.EventHandler(this.favorite_list_button_Click);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.main_panel.Controls.Add(this.home_panel);
            this.main_panel.Controls.Add(this.personal_info_panel);
            this.main_panel.Controls.Add(this.favorite_list_panel);
            this.main_panel.Controls.Add(this.info_panel);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(170, 42);
            this.main_panel.Margin = new System.Windows.Forms.Padding(2);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(666, 450);
            this.main_panel.TabIndex = 4;
            // 
            // home_panel
            // 
            this.home_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.home_panel.Controls.Add(this.button1);
            this.home_panel.Controls.Add(this.dataGridView1);
            this.home_panel.Controls.Add(this.radioButton1);
            this.home_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_panel.Location = new System.Drawing.Point(0, 0);
            this.home_panel.Margin = new System.Windows.Forms.Padding(2);
            this.home_panel.Name = "home_panel";
            this.home_panel.Size = new System.Drawing.Size(666, 450);
            this.home_panel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(480, 288);
            this.dataGridView1.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(76, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Articles ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // personal_info_panel
            // 
            this.personal_info_panel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.personal_info_panel.Controls.Add(this.lower_bar_pi_panel);
            this.personal_info_panel.Controls.Add(this.page_pi_Panel);
            this.personal_info_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personal_info_panel.Location = new System.Drawing.Point(0, 0);
            this.personal_info_panel.Margin = new System.Windows.Forms.Padding(2);
            this.personal_info_panel.Name = "personal_info_panel";
            this.personal_info_panel.Size = new System.Drawing.Size(666, 450);
            this.personal_info_panel.TabIndex = 1;
            // 
            // lower_bar_pi_panel
            // 
            this.lower_bar_pi_panel.Controls.Add(this.Save_pi_button);
            this.lower_bar_pi_panel.Controls.Add(this.personal_info_close_button);
            this.lower_bar_pi_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lower_bar_pi_panel.Location = new System.Drawing.Point(0, 383);
            this.lower_bar_pi_panel.Margin = new System.Windows.Forms.Padding(2);
            this.lower_bar_pi_panel.Name = "lower_bar_pi_panel";
            this.lower_bar_pi_panel.Size = new System.Drawing.Size(666, 67);
            this.lower_bar_pi_panel.TabIndex = 1;
            // 
            // Save_pi_button
            // 
            this.Save_pi_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save_pi_button.BackColor = System.Drawing.Color.Black;
            this.Save_pi_button.FlatAppearance.BorderSize = 0;
            this.Save_pi_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_pi_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_pi_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Save_pi_button.Location = new System.Drawing.Point(262, 1);
            this.Save_pi_button.Margin = new System.Windows.Forms.Padding(2, 19, 2, 2);
            this.Save_pi_button.Name = "Save_pi_button";
            this.Save_pi_button.Size = new System.Drawing.Size(122, 49);
            this.Save_pi_button.TabIndex = 2;
            this.Save_pi_button.Text = "Save";
            this.Save_pi_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save_pi_button.UseVisualStyleBackColor = false;
            this.Save_pi_button.Click += new System.EventHandler(this.save_pi_button_Click);
            // 
            // personal_info_close_button
            // 
            this.personal_info_close_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.personal_info_close_button.BackColor = System.Drawing.Color.Black;
            this.personal_info_close_button.FlatAppearance.BorderSize = 0;
            this.personal_info_close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personal_info_close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personal_info_close_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.personal_info_close_button.Location = new System.Drawing.Point(540, 4);
            this.personal_info_close_button.Margin = new System.Windows.Forms.Padding(2, 19, 2, 2);
            this.personal_info_close_button.Name = "personal_info_close_button";
            this.personal_info_close_button.Size = new System.Drawing.Size(96, 44);
            this.personal_info_close_button.TabIndex = 2;
            this.personal_info_close_button.Text = "Close";
            this.personal_info_close_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.personal_info_close_button.UseVisualStyleBackColor = false;
            this.personal_info_close_button.Click += new System.EventHandler(this.personal_info_close_button_Click);
            // 
            // page_pi_Panel
            // 
            this.page_pi_Panel.Controls.Add(this.title_pi_panel);
            this.page_pi_Panel.Controls.Add(this.first_name_panel);
            this.page_pi_Panel.Controls.Add(this.last_name_panel);
            this.page_pi_Panel.Controls.Add(this.password_panel);
            this.page_pi_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.page_pi_Panel.Location = new System.Drawing.Point(0, 0);
            this.page_pi_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.page_pi_Panel.Name = "page_pi_Panel";
            this.page_pi_Panel.Size = new System.Drawing.Size(666, 383);
            this.page_pi_Panel.TabIndex = 0;
            // 
            // title_pi_panel
            // 
            this.title_pi_panel.Location = new System.Drawing.Point(2, 2);
            this.title_pi_panel.Margin = new System.Windows.Forms.Padding(2);
            this.title_pi_panel.Name = "title_pi_panel";
            this.title_pi_panel.Size = new System.Drawing.Size(664, 29);
            this.title_pi_panel.TabIndex = 0;
            // 
            // first_name_panel
            // 
            this.first_name_panel.Controls.Add(this.first_name_textBox);
            this.first_name_panel.Controls.Add(this.fn_label);
            this.first_name_panel.Location = new System.Drawing.Point(2, 35);
            this.first_name_panel.Margin = new System.Windows.Forms.Padding(2);
            this.first_name_panel.Name = "first_name_panel";
            this.first_name_panel.Size = new System.Drawing.Size(664, 104);
            this.first_name_panel.TabIndex = 0;
            // 
            // first_name_textBox
            // 
            this.first_name_textBox.Location = new System.Drawing.Point(301, 40);
            this.first_name_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.first_name_textBox.Name = "first_name_textBox";
            this.first_name_textBox.Size = new System.Drawing.Size(258, 22);
            this.first_name_textBox.TabIndex = 2;
            // 
            // fn_label
            // 
            this.fn_label.AutoSize = true;
            this.fn_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fn_label.Location = new System.Drawing.Point(19, 34);
            this.fn_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fn_label.Name = "fn_label";
            this.fn_label.Size = new System.Drawing.Size(147, 31);
            this.fn_label.TabIndex = 1;
            this.fn_label.Text = "First Name";
            // 
            // last_name_panel
            // 
            this.last_name_panel.Controls.Add(this.last_name_textBox);
            this.last_name_panel.Controls.Add(this.ln_label);
            this.last_name_panel.Location = new System.Drawing.Point(2, 143);
            this.last_name_panel.Margin = new System.Windows.Forms.Padding(2);
            this.last_name_panel.Name = "last_name_panel";
            this.last_name_panel.Size = new System.Drawing.Size(664, 104);
            this.last_name_panel.TabIndex = 0;
            // 
            // last_name_textBox
            // 
            this.last_name_textBox.Location = new System.Drawing.Point(301, 38);
            this.last_name_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.last_name_textBox.Name = "last_name_textBox";
            this.last_name_textBox.Size = new System.Drawing.Size(258, 22);
            this.last_name_textBox.TabIndex = 2;
            // 
            // ln_label
            // 
            this.ln_label.AutoSize = true;
            this.ln_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln_label.Location = new System.Drawing.Point(19, 32);
            this.ln_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ln_label.Name = "ln_label";
            this.ln_label.Size = new System.Drawing.Size(145, 31);
            this.ln_label.TabIndex = 1;
            this.ln_label.Text = "Last Name";
            // 
            // password_panel
            // 
            this.password_panel.Controls.Add(this.pi_dataGridView);
            this.password_panel.Controls.Add(this.pass_label);
            this.password_panel.Location = new System.Drawing.Point(2, 251);
            this.password_panel.Margin = new System.Windows.Forms.Padding(2);
            this.password_panel.Name = "password_panel";
            this.password_panel.Size = new System.Drawing.Size(664, 113);
            this.password_panel.TabIndex = 1;
            // 
            // pi_dataGridView
            // 
            this.pi_dataGridView.AllowUserToAddRows = false;
            this.pi_dataGridView.AllowUserToDeleteRows = false;
            this.pi_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pi_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.pi_dataGridView.Location = new System.Drawing.Point(301, 15);
            this.pi_dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.pi_dataGridView.Name = "pi_dataGridView";
            this.pi_dataGridView.RowHeadersWidth = 82;
            this.pi_dataGridView.RowTemplate.Height = 33;
            this.pi_dataGridView.Size = new System.Drawing.Size(257, 83);
            this.pi_dataGridView.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PASSWORD_";
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 300;
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_label.Location = new System.Drawing.Point(25, 33);
            this.pass_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(134, 31);
            this.pass_label.TabIndex = 1;
            this.pass_label.Text = "Password";
            // 
            // favorite_list_panel
            // 
            this.favorite_list_panel.BackColor = System.Drawing.Color.IndianRed;
            this.favorite_list_panel.Controls.Add(this.lower_bar_fl_panel);
            this.favorite_list_panel.Controls.Add(this.page_fl_panel);
            this.favorite_list_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favorite_list_panel.Location = new System.Drawing.Point(0, 0);
            this.favorite_list_panel.Margin = new System.Windows.Forms.Padding(2);
            this.favorite_list_panel.Name = "favorite_list_panel";
            this.favorite_list_panel.Size = new System.Drawing.Size(666, 450);
            this.favorite_list_panel.TabIndex = 2;
            // 
            // lower_bar_fl_panel
            // 
            this.lower_bar_fl_panel.Controls.Add(this.favorite_list_close_button);
            this.lower_bar_fl_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lower_bar_fl_panel.Location = new System.Drawing.Point(0, 379);
            this.lower_bar_fl_panel.Margin = new System.Windows.Forms.Padding(2);
            this.lower_bar_fl_panel.Name = "lower_bar_fl_panel";
            this.lower_bar_fl_panel.Size = new System.Drawing.Size(666, 71);
            this.lower_bar_fl_panel.TabIndex = 6;
            // 
            // favorite_list_close_button
            // 
            this.favorite_list_close_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.favorite_list_close_button.BackColor = System.Drawing.Color.Black;
            this.favorite_list_close_button.FlatAppearance.BorderSize = 0;
            this.favorite_list_close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favorite_list_close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favorite_list_close_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.favorite_list_close_button.Location = new System.Drawing.Point(529, 11);
            this.favorite_list_close_button.Margin = new System.Windows.Forms.Padding(2, 19, 2, 2);
            this.favorite_list_close_button.Name = "favorite_list_close_button";
            this.favorite_list_close_button.Size = new System.Drawing.Size(96, 44);
            this.favorite_list_close_button.TabIndex = 3;
            this.favorite_list_close_button.Text = "Close";
            this.favorite_list_close_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.favorite_list_close_button.UseVisualStyleBackColor = false;
            this.favorite_list_close_button.Click += new System.EventHandler(this.favorite_list_close_button_Click);
            // 
            // page_fl_panel
            // 
            this.page_fl_panel.Controls.Add(this.fl_listView);
            this.page_fl_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.page_fl_panel.Location = new System.Drawing.Point(0, 0);
            this.page_fl_panel.Margin = new System.Windows.Forms.Padding(2);
            this.page_fl_panel.Name = "page_fl_panel";
            this.page_fl_panel.Size = new System.Drawing.Size(666, 379);
            this.page_fl_panel.TabIndex = 5;
            // 
            // fl_listView
            // 
            this.fl_listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fl_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.description});
            this.fl_listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fl_listView.FullRowSelect = true;
            this.fl_listView.GridLines = true;
            this.fl_listView.HideSelection = false;
            this.fl_listView.Location = new System.Drawing.Point(11, 29);
            this.fl_listView.Margin = new System.Windows.Forms.Padding(2);
            this.fl_listView.Name = "fl_listView";
            this.fl_listView.Size = new System.Drawing.Size(625, 296);
            this.fl_listView.TabIndex = 0;
            this.fl_listView.UseCompatibleStateImageBehavior = false;
            this.fl_listView.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Article Name";
            this.name.Width = 400;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 10000;
            // 
            // info_panel
            // 
            this.info_panel.BackColor = System.Drawing.Color.LightPink;
            this.info_panel.Controls.Add(this.home_quote);
            this.info_panel.Controls.Add(this.info_close_button);
            this.info_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info_panel.Location = new System.Drawing.Point(0, 0);
            this.info_panel.Margin = new System.Windows.Forms.Padding(2);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(666, 450);
            this.info_panel.TabIndex = 5;
            // 
            // home_quote
            // 
            this.home_quote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.home_quote.AutoSize = true;
            this.home_quote.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_quote.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.home_quote.Location = new System.Drawing.Point(30, 22);
            this.home_quote.Name = "home_quote";
            this.home_quote.Size = new System.Drawing.Size(568, 322);
            this.home_quote.TabIndex = 2;
            this.home_quote.Text = resources.GetString("home_quote.Text");
            this.home_quote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_close_button
            // 
            this.info_close_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.info_close_button.BackColor = System.Drawing.Color.Black;
            this.info_close_button.FlatAppearance.BorderSize = 0;
            this.info_close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info_close_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.info_close_button.Location = new System.Drawing.Point(276, 380);
            this.info_close_button.Margin = new System.Windows.Forms.Padding(2, 19, 2, 2);
            this.info_close_button.Name = "info_close_button";
            this.info_close_button.Size = new System.Drawing.Size(114, 43);
            this.info_close_button.TabIndex = 1;
            this.info_close_button.Text = "Close";
            this.info_close_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.info_close_button.UseVisualStyleBackColor = false;
            this.info_close_button.Click += new System.EventHandler(this.info_close_button_Click);
            // 
            // Portal_Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 492);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.Menu_Panel);
            this.Controls.Add(this.title_bar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Portal_Home_Form";
            this.Text = "Form1";
            this.title_bar_panel.ResumeLayout(false);
            this.title_bar_panel.PerformLayout();
            this.Menu_Panel.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            this.home_panel.ResumeLayout(false);
            this.home_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.personal_info_panel.ResumeLayout(false);
            this.lower_bar_pi_panel.ResumeLayout(false);
            this.page_pi_Panel.ResumeLayout(false);
            this.first_name_panel.ResumeLayout(false);
            this.first_name_panel.PerformLayout();
            this.last_name_panel.ResumeLayout(false);
            this.last_name_panel.PerformLayout();
            this.password_panel.ResumeLayout(false);
            this.password_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pi_dataGridView)).EndInit();
            this.favorite_list_panel.ResumeLayout(false);
            this.lower_bar_fl_panel.ResumeLayout(false);
            this.page_fl_panel.ResumeLayout(false);
            this.info_panel.ResumeLayout(false);
            this.info_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title_bar_panel;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button minimize_button;
        private System.Windows.Forms.Button resize_button;
        private System.Windows.Forms.Button info_button;
        private System.Windows.Forms.FlowLayoutPanel Menu_Panel;
        private System.Windows.Forms.Button personal_info_button;
        private System.Windows.Forms.Button favorite_list_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel home_panel;
        private System.Windows.Forms.Panel favorite_list_panel;
        private System.Windows.Forms.Panel personal_info_panel;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.Button info_close_button;
        private System.Windows.Forms.Panel lower_bar_pi_panel;
        private System.Windows.Forms.FlowLayoutPanel page_pi_Panel;
        private System.Windows.Forms.Panel title_pi_panel;
        private System.Windows.Forms.Panel first_name_panel;
        private System.Windows.Forms.Panel last_name_panel;
        private System.Windows.Forms.Panel password_panel;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.TextBox first_name_textBox;
        private System.Windows.Forms.Label fn_label;
        private System.Windows.Forms.TextBox last_name_textBox;
        private System.Windows.Forms.Label ln_label;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.Button personal_info_close_button;
        private System.Windows.Forms.Button Save_pi_button;
        private System.Windows.Forms.Button favorite_list_close_button;
        private System.Windows.Forms.Panel lower_bar_fl_panel;
        private System.Windows.Forms.Panel page_fl_panel;
        private System.Windows.Forms.ListView fl_listView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.DataGridView pi_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.Label home_quote;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}