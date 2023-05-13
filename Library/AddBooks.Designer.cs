namespace Library
{
    partial class AddBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dvg1 = new System.Windows.Forms.DataGridView();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.txtaddQTY = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.btnAddQty = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnAddNew = new Guna.UI.WinForms.GunaButton();
            this.txtPrice = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txtFloor = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtQty = new Guna.UI.WinForms.GunaTextBox();
            this.CboCompare = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.BookImage = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.txtBookID = new Guna.UI.WinForms.GunaTextBox();
            this.CboType = new Guna.UI.WinForms.GunaComboBox();
            this.CboAuthor = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtYear = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtBookName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookImage)).BeginInit();
            this.guna2ShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1942, 74);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Content", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(866, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Books";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.dvg1);
            this.panel2.Controls.Add(this.guna2ShadowPanel1);
            this.panel2.Controls.Add(this.guna2ShadowPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1942, 1028);
            this.panel2.TabIndex = 2;
            // 
            // dvg1
            // 
            this.dvg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg1.Location = new System.Drawing.Point(21, 407);
            this.dvg1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvg1.Name = "dvg1";
            this.dvg1.RowHeadersWidth = 51;
            this.dvg1.RowTemplate.Height = 24;
            this.dvg1.Size = new System.Drawing.Size(1857, 445);
            this.dvg1.TabIndex = 32;
            this.dvg1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.txtaddQTY);
            this.guna2ShadowPanel1.Controls.Add(this.gunaLabel11);
            this.guna2ShadowPanel1.Controls.Add(this.btnAddQty);
            this.guna2ShadowPanel1.Controls.Add(this.btnUpdate);
            this.guna2ShadowPanel1.Controls.Add(this.txtSearch);
            this.guna2ShadowPanel1.Controls.Add(this.gunaLabel9);
            this.guna2ShadowPanel1.Controls.Add(this.btnDelete);
            this.guna2ShadowPanel1.Controls.Add(this.btnAddNew);
            this.guna2ShadowPanel1.Controls.Add(this.txtPrice);
            this.guna2ShadowPanel1.Controls.Add(this.gunaLabel5);
            this.guna2ShadowPanel1.Controls.Add(this.gunaLabel6);
            this.guna2ShadowPanel1.Controls.Add(this.txtFloor);
            this.guna2ShadowPanel1.Controls.Add(this.gunaLabel7);
            this.guna2ShadowPanel1.Controls.Add(this.txtQty);
            this.guna2ShadowPanel1.Controls.Add(this.CboCompare);
            this.guna2ShadowPanel1.Controls.Add(this.gunaLabel8);
            this.guna2ShadowPanel1.Controls.Add(this.BookImage);
            this.guna2ShadowPanel1.Controls.Add(this.gunaButton1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Font = new System.Drawing.Font("Kh Battambang", 10F);
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(801, 23);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 25;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(997, 367);
            this.guna2ShadowPanel1.TabIndex = 61;
            // 
            // txtaddQTY
            // 
            this.txtaddQTY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtaddQTY.BackColor = System.Drawing.Color.Transparent;
            this.txtaddQTY.BaseColor = System.Drawing.Color.White;
            this.txtaddQTY.BorderColor = System.Drawing.Color.Silver;
            this.txtaddQTY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaddQTY.FocusedBaseColor = System.Drawing.Color.White;
            this.txtaddQTY.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtaddQTY.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtaddQTY.Font = new System.Drawing.Font("Kh Battambang", 10F);
            this.txtaddQTY.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtaddQTY.Location = new System.Drawing.Point(208, 242);
            this.txtaddQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtaddQTY.Name = "txtaddQTY";
            this.txtaddQTY.PasswordChar = '\0';
            this.txtaddQTY.Radius = 8;
            this.txtaddQTY.SelectedText = "";
            this.txtaddQTY.Size = new System.Drawing.Size(313, 52);
            this.txtaddQTY.TabIndex = 33;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.Location = new System.Drawing.Point(84, 251);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(112, 31);
            this.gunaLabel11.TabIndex = 32;
            this.gunaLabel11.Text = "Add QTY";
            this.gunaLabel11.Click += new System.EventHandler(this.gunaLabel11_Click);
            // 
            // btnAddQty
            // 
            this.btnAddQty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddQty.AnimationHoverSpeed = 0.07F;
            this.btnAddQty.AnimationSpeed = 0.03F;
            this.btnAddQty.BackColor = System.Drawing.Color.Transparent;
            this.btnAddQty.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnAddQty.BorderColor = System.Drawing.Color.Black;
            this.btnAddQty.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddQty.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddQty.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQty.ForeColor = System.Drawing.Color.White;
            this.btnAddQty.Image = ((System.Drawing.Image)(resources.GetObject("btnAddQty.Image")));
            this.btnAddQty.ImageSize = new System.Drawing.Size(0, 0);
            this.btnAddQty.Location = new System.Drawing.Point(791, 239);
            this.btnAddQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddQty.Name = "btnAddQty";
            this.btnAddQty.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAddQty.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddQty.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddQty.OnHoverImage = null;
            this.btnAddQty.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddQty.Radius = 8;
            this.btnAddQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddQty.Size = new System.Drawing.Size(173, 52);
            this.btnAddQty.TabIndex = 31;
            this.btnAddQty.Text = "Add Book QTY";
            this.btnAddQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddQty.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageSize = new System.Drawing.Size(0, 0);
            this.btnUpdate.Location = new System.Drawing.Point(791, 172);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 8;
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdate.Size = new System.Drawing.Size(173, 52);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Kh Battambang", 10F);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSearch.Location = new System.Drawing.Point(160, 308);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 8;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(573, 52);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(68, 320);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(90, 31);
            this.gunaLabel9.TabIndex = 22;
            this.gunaLabel9.Text = "Search";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(0, 0);
            this.btnDelete.Location = new System.Drawing.Point(791, 105);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 8;
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelete.Size = new System.Drawing.Size(173, 52);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.AnimationHoverSpeed = 0.07F;
            this.btnAddNew.AnimationSpeed = 0.03F;
            this.btnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnAddNew.BorderColor = System.Drawing.Color.Black;
            this.btnAddNew.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNew.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNew.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImageSize = new System.Drawing.Size(0, 0);
            this.btnAddNew.Location = new System.Drawing.Point(791, 36);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAddNew.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNew.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNew.OnHoverImage = null;
            this.btnAddNew.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddNew.Radius = 8;
            this.btnAddNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddNew.Size = new System.Drawing.Size(173, 52);
            this.btnAddNew.TabIndex = 28;
            this.btnAddNew.Text = "Add Book";
            this.btnAddNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click_1);
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.BaseColor = System.Drawing.Color.White;
            this.txtPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrice.Font = new System.Drawing.Font("Kh Battambang", 10F);
            this.txtPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrice.Location = new System.Drawing.Point(208, 181);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.Radius = 8;
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(313, 52);
            this.txtPrice.TabIndex = 18;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(81, 25);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(83, 31);
            this.gunaLabel5.TabIndex = 8;
            this.gunaLabel5.Text = "Closet";
            this.gunaLabel5.Click += new System.EventHandler(this.gunaLabel5_Click);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(121, 82);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(71, 31);
            this.gunaLabel6.TabIndex = 10;
            this.gunaLabel6.Text = "Floor";
            // 
            // txtFloor
            // 
            this.txtFloor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFloor.BackColor = System.Drawing.Color.Transparent;
            this.txtFloor.BaseColor = System.Drawing.Color.White;
            this.txtFloor.BorderColor = System.Drawing.Color.Silver;
            this.txtFloor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFloor.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFloor.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFloor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFloor.Font = new System.Drawing.Font("Kh Battambang", 10F);
            this.txtFloor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFloor.Location = new System.Drawing.Point(208, 63);
            this.txtFloor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.PasswordChar = '\0';
            this.txtFloor.Radius = 8;
            this.txtFloor.SelectedText = "";
            this.txtFloor.Size = new System.Drawing.Size(313, 52);
            this.txtFloor.TabIndex = 11;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(128, 140);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(65, 31);
            this.gunaLabel7.TabIndex = 12;
            this.gunaLabel7.Text = "QTY";
            // 
            // txtQty
            // 
            this.txtQty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQty.BackColor = System.Drawing.Color.Transparent;
            this.txtQty.BaseColor = System.Drawing.Color.White;
            this.txtQty.BorderColor = System.Drawing.Color.Silver;
            this.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.FocusedBaseColor = System.Drawing.Color.White;
            this.txtQty.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtQty.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQty.Font = new System.Drawing.Font("Kh Battambang", 10F);
            this.txtQty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtQty.Location = new System.Drawing.Point(208, 121);
            this.txtQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.Radius = 8;
            this.txtQty.SelectedText = "";
            this.txtQty.Size = new System.Drawing.Size(313, 52);
            this.txtQty.TabIndex = 13;
            // 
            // CboCompare
            // 
            this.CboCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboCompare.BackColor = System.Drawing.Color.Transparent;
            this.CboCompare.BaseColor = System.Drawing.Color.White;
            this.CboCompare.BorderColor = System.Drawing.Color.Silver;
            this.CboCompare.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CboCompare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCompare.FocusedColor = System.Drawing.Color.Empty;
            this.CboCompare.Font = new System.Drawing.Font("Kh Battambang", 10F);
            this.CboCompare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CboCompare.FormattingEnabled = true;
            this.CboCompare.Location = new System.Drawing.Point(208, 15);
            this.CboCompare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboCompare.Name = "CboCompare";
            this.CboCompare.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CboCompare.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CboCompare.Radius = 8;
            this.CboCompare.Size = new System.Drawing.Size(312, 40);
            this.CboCompare.TabIndex = 16;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(43, 196);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(152, 31);
            this.gunaLabel8.TabIndex = 17;
            this.gunaLabel8.Text = "Borrow Price";
            // 
            // BookImage
            // 
            this.BookImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookImage.BaseColor = System.Drawing.Color.White;
            this.BookImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookImage.Image = ((System.Drawing.Image)(resources.GetObject("BookImage.Image")));
            this.BookImage.Location = new System.Drawing.Point(557, 10);
            this.BookImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookImage.Name = "BookImage";
            this.BookImage.Size = new System.Drawing.Size(210, 214);
            this.BookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookImage.TabIndex = 19;
            this.BookImage.TabStop = false;
            this.BookImage.UseTransfarantBackground = false;
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(0, 0);
            this.gunaButton1.Location = new System.Drawing.Point(575, 239);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 8;
            this.gunaButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gunaButton1.Size = new System.Drawing.Size(176, 52);
            this.gunaButton1.TabIndex = 20;
            this.gunaButton1.Text = "Browse...";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.gunaLabel10);
            this.guna2ShadowPanel2.Controls.Add(this.txtBookID);
            this.guna2ShadowPanel2.Controls.Add(this.CboType);
            this.guna2ShadowPanel2.Controls.Add(this.CboAuthor);
            this.guna2ShadowPanel2.Controls.Add(this.gunaLabel4);
            this.guna2ShadowPanel2.Controls.Add(this.txtYear);
            this.guna2ShadowPanel2.Controls.Add(this.gunaLabel3);
            this.guna2ShadowPanel2.Controls.Add(this.gunaLabel2);
            this.guna2ShadowPanel2.Controls.Add(this.txtBookName);
            this.guna2ShadowPanel2.Controls.Add(this.gunaLabel1);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Font = new System.Drawing.Font("Kh Battambang", 10F);
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(180, 23);
            this.guna2ShadowPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 25;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(540, 367);
            this.guna2ShadowPanel2.TabIndex = 60;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.Location = new System.Drawing.Point(95, 36);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(97, 31);
            this.gunaLabel10.TabIndex = 39;
            this.gunaLabel10.Text = "Book ID";
            // 
            // txtBookID
            // 
            this.txtBookID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookID.BackColor = System.Drawing.Color.Transparent;
            this.txtBookID.BaseColor = System.Drawing.Color.White;
            this.txtBookID.BorderColor = System.Drawing.Color.Silver;
            this.txtBookID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookID.Enabled = false;
            this.txtBookID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBookID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBookID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBookID.Font = new System.Drawing.Font("Kh Battambang", 10F);
            this.txtBookID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBookID.Location = new System.Drawing.Point(208, 25);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.PasswordChar = '\0';
            this.txtBookID.Radius = 8;
            this.txtBookID.SelectedText = "";
            this.txtBookID.Size = new System.Drawing.Size(224, 52);
            this.txtBookID.TabIndex = 38;
            // 
            // CboType
            // 
            this.CboType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboType.BackColor = System.Drawing.Color.Transparent;
            this.CboType.BaseColor = System.Drawing.Color.White;
            this.CboType.BorderColor = System.Drawing.Color.Silver;
            this.CboType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboType.FocusedColor = System.Drawing.Color.Empty;
            this.CboType.Font = new System.Drawing.Font("Kh Battambang", 10F);
            this.CboType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CboType.FormattingEnabled = true;
            this.CboType.Location = new System.Drawing.Point(207, 148);
            this.CboType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboType.Name = "CboType";
            this.CboType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CboType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CboType.Radius = 8;
            this.CboType.Size = new System.Drawing.Size(224, 40);
            this.CboType.TabIndex = 37;
            // 
            // CboAuthor
            // 
            this.CboAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboAuthor.BackColor = System.Drawing.Color.Transparent;
            this.CboAuthor.BaseColor = System.Drawing.Color.White;
            this.CboAuthor.BorderColor = System.Drawing.Color.Silver;
            this.CboAuthor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CboAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAuthor.FocusedColor = System.Drawing.Color.Empty;
            this.CboAuthor.Font = new System.Drawing.Font("Kh Battambang", 10F);
            this.CboAuthor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CboAuthor.FormattingEnabled = true;
            this.CboAuthor.Location = new System.Drawing.Point(208, 262);
            this.CboAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboAuthor.Name = "CboAuthor";
            this.CboAuthor.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CboAuthor.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CboAuthor.Radius = 8;
            this.CboAuthor.Size = new System.Drawing.Size(223, 40);
            this.CboAuthor.TabIndex = 36;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(44, 266);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(152, 31);
            this.gunaLabel4.TabIndex = 35;
            this.gunaLabel4.Text = "Author Name";
            // 
            // txtYear
            // 
            this.txtYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYear.BackColor = System.Drawing.Color.Transparent;
            this.txtYear.BaseColor = System.Drawing.Color.White;
            this.txtYear.BorderColor = System.Drawing.Color.Silver;
            this.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYear.FocusedBaseColor = System.Drawing.Color.White;
            this.txtYear.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtYear.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtYear.Font = new System.Drawing.Font("Kh Battambang", 10F);
            this.txtYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtYear.Location = new System.Drawing.Point(208, 197);
            this.txtYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYear.Name = "txtYear";
            this.txtYear.PasswordChar = '\0';
            this.txtYear.Radius = 8;
            this.txtYear.SelectedText = "";
            this.txtYear.Size = new System.Drawing.Size(224, 52);
            this.txtYear.TabIndex = 34;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(72, 217);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(125, 31);
            this.gunaLabel3.TabIndex = 33;
            this.gunaLabel3.Text = "Book Year";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(75, 154);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(125, 31);
            this.gunaLabel2.TabIndex = 32;
            this.gunaLabel2.Text = "BookType";
            // 
            // txtBookName
            // 
            this.txtBookName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookName.BackColor = System.Drawing.Color.Transparent;
            this.txtBookName.BaseColor = System.Drawing.Color.White;
            this.txtBookName.BorderColor = System.Drawing.Color.Silver;
            this.txtBookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBookName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBookName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBookName.Font = new System.Drawing.Font("Kh Battambang", 10F);
            this.txtBookName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBookName.Location = new System.Drawing.Point(208, 89);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.PasswordChar = '\0';
            this.txtBookName.Radius = 8;
            this.txtBookName.SelectedText = "";
            this.txtBookName.Size = new System.Drawing.Size(224, 52);
            this.txtBookName.TabIndex = 31;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(59, 89);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(139, 31);
            this.gunaLabel1.TabIndex = 30;
            this.gunaLabel1.Text = "Book Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddBooks";
            this.Text = "AddBooks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg1)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookImage)).EndInit();
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaCirclePictureBox BookImage;
        private Guna.UI.WinForms.GunaTextBox txtPrice;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaComboBox CboCompare;
        private Guna.UI.WinForms.GunaTextBox txtQty;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox txtFloor;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaButton btnAddNew;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaTextBox txtBookID;
        private Guna.UI.WinForms.GunaComboBox CboType;
        private Guna.UI.WinForms.GunaComboBox CboAuthor;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtYear;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtBookName;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.DataGridView dvg1;
        private Guna.UI.WinForms.GunaButton btnAddQty;
        private Guna.UI.WinForms.GunaTextBox txtaddQTY;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
    }
}