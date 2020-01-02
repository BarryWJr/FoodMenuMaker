namespace foodMenuMaker
{
    partial class frmMenuMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuMaker));
            this.butAddItem = new System.Windows.Forms.Button();
            this.butCreateXML = new System.Windows.Forms.Button();
            this.cmbMenuType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panBurgerInfo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFoodPrice = new System.Windows.Forms.TextBox();
            this.txtFoodDescrip = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.butClear = new System.Windows.Forms.Button();
            this.lblMaker = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.clmFoodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFoodDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNumDataItems = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picImageAbout = new System.Windows.Forms.PictureBox();
            this.lblFileXMLName = new System.Windows.Forms.Label();
            this.panBurgerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // butAddItem
            // 
            this.butAddItem.Location = new System.Drawing.Point(59, 291);
            this.butAddItem.Name = "butAddItem";
            this.butAddItem.Size = new System.Drawing.Size(103, 40);
            this.butAddItem.TabIndex = 0;
            this.butAddItem.Text = "Add Item";
            this.butAddItem.UseVisualStyleBackColor = true;
            this.butAddItem.Click += new System.EventHandler(this.butAddItem_Click);
            // 
            // butCreateXML
            // 
            this.butCreateXML.Location = new System.Drawing.Point(856, 278);
            this.butCreateXML.Name = "butCreateXML";
            this.butCreateXML.Size = new System.Drawing.Size(97, 41);
            this.butCreateXML.TabIndex = 1;
            this.butCreateXML.Text = "Create XML";
            this.butCreateXML.UseVisualStyleBackColor = true;
            this.butCreateXML.Click += new System.EventHandler(this.butCreateXML_Click);
            // 
            // cmbMenuType
            // 
            this.cmbMenuType.FormattingEnabled = true;
            this.cmbMenuType.Items.AddRange(new object[] {
            "Burgers",
            "Appetizers",
            "Salads",
            "Drinks"});
            this.cmbMenuType.Location = new System.Drawing.Point(16, 28);
            this.cmbMenuType.Name = "cmbMenuType";
            this.cmbMenuType.Size = new System.Drawing.Size(121, 21);
            this.cmbMenuType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Menu Type";
            // 
            // panBurgerInfo
            // 
            this.panBurgerInfo.BackColor = System.Drawing.Color.DarkGray;
            this.panBurgerInfo.Controls.Add(this.label4);
            this.panBurgerInfo.Controls.Add(this.label3);
            this.panBurgerInfo.Controls.Add(this.label1);
            this.panBurgerInfo.Controls.Add(this.label2);
            this.panBurgerInfo.Controls.Add(this.cmbMenuType);
            this.panBurgerInfo.Controls.Add(this.txtFoodPrice);
            this.panBurgerInfo.Controls.Add(this.txtFoodDescrip);
            this.panBurgerInfo.Controls.Add(this.txtFoodName);
            this.panBurgerInfo.Location = new System.Drawing.Point(59, 60);
            this.panBurgerInfo.Name = "panBurgerInfo";
            this.panBurgerInfo.Size = new System.Drawing.Size(427, 212);
            this.panBurgerInfo.TabIndex = 4;
            this.panBurgerInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panBurgerInfo_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description of Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name Of Menu Item";
            // 
            // txtFoodPrice
            // 
            this.txtFoodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodPrice.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtFoodPrice.Location = new System.Drawing.Point(19, 157);
            this.txtFoodPrice.Name = "txtFoodPrice";
            this.txtFoodPrice.Size = new System.Drawing.Size(100, 26);
            this.txtFoodPrice.TabIndex = 2;
            this.txtFoodPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFoodDescrip
            // 
            this.txtFoodDescrip.Location = new System.Drawing.Point(16, 77);
            this.txtFoodDescrip.Multiline = true;
            this.txtFoodDescrip.Name = "txtFoodDescrip";
            this.txtFoodDescrip.Size = new System.Drawing.Size(195, 54);
            this.txtFoodDescrip.TabIndex = 1;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(165, 29);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(100, 20);
            this.txtFoodName.TabIndex = 0;
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(168, 291);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(89, 40);
            this.butClear.TabIndex = 5;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // lblMaker
            // 
            this.lblMaker.AutoSize = true;
            this.lblMaker.Font = new System.Drawing.Font("Narkisim", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaker.Location = new System.Drawing.Point(53, 25);
            this.lblMaker.Name = "lblMaker";
            this.lblMaker.Size = new System.Drawing.Size(261, 32);
            this.lblMaker.TabIndex = 6;
            this.lblMaker.Text = "Food Menu Maker";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFoodType,
            this.clmFoodName,
            this.clmFoodDescrip,
            this.clmFoodPrice});
            this.dataGridView.Location = new System.Drawing.Point(492, 60);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(461, 209);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            // 
            // clmFoodType
            // 
            this.clmFoodType.HeaderText = "Food Type";
            this.clmFoodType.Name = "clmFoodType";
            // 
            // clmFoodName
            // 
            this.clmFoodName.HeaderText = "Food Name";
            this.clmFoodName.Name = "clmFoodName";
            // 
            // clmFoodDescrip
            // 
            this.clmFoodDescrip.HeaderText = "Food Description";
            this.clmFoodDescrip.Name = "clmFoodDescrip";
            // 
            // clmFoodPrice
            // 
            this.clmFoodPrice.HeaderText = "Food Price";
            this.clmFoodPrice.Name = "clmFoodPrice";
            // 
            // lblNumDataItems
            // 
            this.lblNumDataItems.AutoSize = true;
            this.lblNumDataItems.Location = new System.Drawing.Point(502, 278);
            this.lblNumDataItems.Name = "lblNumDataItems";
            this.lblNumDataItems.Size = new System.Drawing.Size(35, 13);
            this.lblNumDataItems.TabIndex = 8;
            this.lblNumDataItems.Text = "label5";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1017, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // picImageAbout
            // 
            this.picImageAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picImageAbout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImageAbout.Image = ((System.Drawing.Image)(resources.GetObject("picImageAbout.Image")));
            this.picImageAbout.Location = new System.Drawing.Point(325, 121);
            this.picImageAbout.Name = "picImageAbout";
            this.picImageAbout.Size = new System.Drawing.Size(359, 259);
            this.picImageAbout.TabIndex = 6;
            this.picImageAbout.TabStop = false;
            this.picImageAbout.Visible = false;
            this.picImageAbout.Click += new System.EventHandler(this.picImageAbout_Click);
            // 
            // lblFileXMLName
            // 
            this.lblFileXMLName.AutoSize = true;
            this.lblFileXMLName.Location = new System.Drawing.Point(492, 41);
            this.lblFileXMLName.Name = "lblFileXMLName";
            this.lblFileXMLName.Size = new System.Drawing.Size(0, 13);
            this.lblFileXMLName.TabIndex = 10;
            // 
            // frmMenuMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1017, 435);
            this.Controls.Add(this.lblFileXMLName);
            this.Controls.Add(this.lblNumDataItems);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblMaker);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.panBurgerInfo);
            this.Controls.Add(this.butCreateXML);
            this.Controls.Add(this.butAddItem);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picImageAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMenuMaker";
            this.Text = "Food Menu Maker";
            this.Load += new System.EventHandler(this.frmMenuMaker_Load);
            this.Click += new System.EventHandler(this.frmMenuMaker_Click);
            this.Enter += new System.EventHandler(this.frmMenuMaker_Enter);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmMenuMaker_MouseClick);
            this.panBurgerInfo.ResumeLayout(false);
            this.panBurgerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAddItem;
        private System.Windows.Forms.Button butCreateXML;
        private System.Windows.Forms.ComboBox cmbMenuType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panBurgerInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFoodPrice;
        private System.Windows.Forms.TextBox txtFoodDescrip;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaker;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFoodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFoodDescrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFoodPrice;
        private System.Windows.Forms.Label lblNumDataItems;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.PictureBox picImageAbout;
        private System.Windows.Forms.Label lblFileXMLName;
    }
}

