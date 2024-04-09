namespace BatchTestLogin
{
    partial class BatchTestLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchTestLogin));
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "מספר אצווה");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "תיאור אצווה");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "הערות");
            Telerik.WinControls.UI.ListViewDataItemGroup listViewDataItemGroup1 = new Telerik.WinControls.UI.ListViewDataItemGroup("אצוות");
            this.lblHeader = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.lblNumOfBatches = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new Telerik.WinControls.UI.RadButton();
            this.btnLoginBatches = new Telerik.WinControls.UI.RadButton();
            this.lsvBatches = new Telerik.WinControls.UI.RadListView();
            this.txtBatch = new Telerik.WinControls.UI.RadTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoginBatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsvBatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHeader.Location = new System.Drawing.Point(221, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(171, 39);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "הזנת אצוות";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "stockk.ico");
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.lblNumOfBatches);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Controls.Add(this.btnExit);
            this.radGroupBox1.Controls.Add(this.btnLoginBatches);
            this.radGroupBox1.Controls.Add(this.lsvBatches);
            this.radGroupBox1.Controls.Add(this.txtBatch);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(35, 65);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(737, 565);
            this.radGroupBox1.TabIndex = 7;
            // 
            // lblNumOfBatches
            // 
            this.lblNumOfBatches.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNumOfBatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNumOfBatches.Location = new System.Drawing.Point(28, 485);
            this.lblNumOfBatches.Name = "lblNumOfBatches";
            this.lblNumOfBatches.Size = new System.Drawing.Size(50, 24);
            this.lblNumOfBatches.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(533, 56);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "אצווה:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(95, 485);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "סה\"כ:";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(640, 513);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(83, 33);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "יציאה";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoginBatches
            // 
            this.btnLoginBatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginBatches.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginBatches.Location = new System.Drawing.Point(533, 513);
            this.btnLoginBatches.Name = "btnLoginBatches";
            this.btnLoginBatches.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLoginBatches.Size = new System.Drawing.Size(80, 33);
            this.btnLoginBatches.TabIndex = 9;
            this.btnLoginBatches.Text = "הזן אצוות";
            this.btnLoginBatches.Click += new System.EventHandler(this.btnLoginBatches_Click);
            // 
            // lsvBatches
            // 
            this.lsvBatches.AllowEdit = false;
            this.lsvBatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            listViewDetailColumn1.HeaderText = "מספר אצווה";
            listViewDetailColumn2.HeaderText = "תיאור אצווה";
            listViewDetailColumn3.HeaderText = "הערות";
            listViewDetailColumn3.Width = 250F;
            this.lsvBatches.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3});
            this.lsvBatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            listViewDataItemGroup1.Image = ((System.Drawing.Image)(resources.GetObject("listViewDataItemGroup1.Image")));
            listViewDataItemGroup1.ImageKey = "stockk.ico";
            listViewDataItemGroup1.Text = "אצוות";
            this.lsvBatches.Groups.AddRange(new Telerik.WinControls.UI.ListViewDataItemGroup[] {
            listViewDataItemGroup1});
            this.lsvBatches.ImageList = this.imageList1;
            this.lsvBatches.ItemSpacing = -1;
            this.lsvBatches.Location = new System.Drawing.Point(15, 116);
            this.lsvBatches.Name = "lsvBatches";
            this.lsvBatches.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lsvBatches.Size = new System.Drawing.Size(708, 354);
            this.lsvBatches.TabIndex = 8;
            this.lsvBatches.Text = "radListView1";
            this.lsvBatches.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.lsvBatches.ItemRemoved += new Telerik.WinControls.UI.ListViewItemEventHandler(this.lsvBatches_ItemRemoved);
            // 
            // txtBatch
            // 
            this.txtBatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatch.Location = new System.Drawing.Point(114, 52);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBatch.Size = new System.Drawing.Size(413, 27);
            this.txtBatch.TabIndex = 7;
            this.txtBatch.TabStop = false;
            this.txtBatch.TextChanged += new System.EventHandler(this.txtBatch_TextChanged);
            this.txtBatch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBatch_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BatchTestLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.lblHeader);
            this.Name = "BatchTestLogin";
            this.Size = new System.Drawing.Size(801, 685);
            this.Load += new System.EventHandler(this.BatchTestLogin_Load);
            this.Resize += new System.EventHandler(this.BatchTestLogin_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoginBatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsvBatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Label lblNumOfBatches;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnExit;
        private Telerik.WinControls.UI.RadButton btnLoginBatches;
        private Telerik.WinControls.UI.RadListView lsvBatches;
        private Telerik.WinControls.UI.RadTextBox txtBatch;
        private System.Windows.Forms.Timer timer1;
    }
}
