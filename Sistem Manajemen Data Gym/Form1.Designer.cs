namespace Sistem_Manajemen_Data_Gym
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.BtnReset = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btntampilkann = new System.Windows.Forms.Button();
            this.Inputcari = new System.Windows.Forms.Label();
            this.txtcari = new System.Windows.Forms.TextBox();
            this.txtupdate = new System.Windows.Forms.Button();
            this.txthapus = new System.Windows.Forms.Button();
            this.txtsimpan = new System.Windows.Forms.Button();
            this.Inputstatus = new System.Windows.Forms.Label();
            this.cbstatus = new System.Windows.Forms.ComboBox();
            this.txthp = new System.Windows.Forms.TextBox();
            this.Inputnohp = new System.Windows.Forms.Label();
            this.Inputnama = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.lblTotalRecord = new System.Windows.Forms.Label();
            this.lblStatusKoneksi = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHeader.Controls.Add(this.BtnReset);
            this.pnlHeader.Controls.Add(this.dataGridView2);
            this.pnlHeader.Controls.Add(this.dataGridView1);
            this.pnlHeader.Controls.Add(this.btntampilkann);
            this.pnlHeader.Controls.Add(this.Inputcari);
            this.pnlHeader.Controls.Add(this.txtcari);
            this.pnlHeader.Controls.Add(this.txtupdate);
            this.pnlHeader.Controls.Add(this.txthapus);
            this.pnlHeader.Controls.Add(this.txtsimpan);
            this.pnlHeader.Controls.Add(this.Inputstatus);
            this.pnlHeader.Controls.Add(this.cbstatus);
            this.pnlHeader.Controls.Add(this.txthp);
            this.pnlHeader.Controls.Add(this.Inputnohp);
            this.pnlHeader.Controls.Add(this.Inputnama);
            this.pnlHeader.Controls.Add(this.txtnama);
            this.pnlHeader.Controls.Add(this.lblTotalRecord);
            this.pnlHeader.Controls.Add(this.lblStatusKoneksi);
            this.pnlHeader.Controls.Add(this.lblJudul);
            this.pnlHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlHeader.Location = new System.Drawing.Point(-6, -29);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(815, 487);
            this.pnlHeader.TabIndex = 0;
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(558, 133);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(100, 25);
            this.BtnReset.TabIndex = 17;
            this.BtnReset.Text = "Reset Data";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(435, 317);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(373, 150);
            this.dataGridView2.TabIndex = 16;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(426, 150);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btntampilkann
            // 
            this.btntampilkann.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntampilkann.Location = new System.Drawing.Point(558, 101);
            this.btntampilkann.Name = "btntampilkann";
            this.btntampilkann.Size = new System.Drawing.Size(100, 23);
            this.btntampilkann.TabIndex = 14;
            this.btntampilkann.Text = "Tampilkan Data";
            this.btntampilkann.UseVisualStyleBackColor = true;
            this.btntampilkann.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inputcari
            // 
            this.Inputcari.AutoSize = true;
            this.Inputcari.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inputcari.Location = new System.Drawing.Point(229, 105);
            this.Inputcari.Name = "Inputcari";
            this.Inputcari.Size = new System.Drawing.Size(27, 13);
            this.Inputcari.TabIndex = 13;
            this.Inputcari.Text = "Cari";
            // 
            // txtcari
            // 
            this.txtcari.Location = new System.Drawing.Point(262, 101);
            this.txtcari.Name = "txtcari";
            this.txtcari.Size = new System.Drawing.Size(226, 23);
            this.txtcari.TabIndex = 12;
            this.txtcari.TextChanged += new System.EventHandler(this.txtcari_TextChanged);
            // 
            // txtupdate
            // 
            this.txtupdate.Location = new System.Drawing.Point(457, 243);
            this.txtupdate.Name = "txtupdate";
            this.txtupdate.Size = new System.Drawing.Size(75, 23);
            this.txtupdate.TabIndex = 11;
            this.txtupdate.Text = "Update";
            this.txtupdate.UseVisualStyleBackColor = true;
            this.txtupdate.Click += new System.EventHandler(this.txtupdate_Click);
            // 
            // txthapus
            // 
            this.txthapus.Location = new System.Drawing.Point(343, 243);
            this.txthapus.Name = "txthapus";
            this.txthapus.Size = new System.Drawing.Size(75, 23);
            this.txthapus.TabIndex = 10;
            this.txthapus.Text = "Hapus";
            this.txthapus.UseVisualStyleBackColor = true;
            this.txthapus.Click += new System.EventHandler(this.txthapus_Click);
            // 
            // txtsimpan
            // 
            this.txtsimpan.Location = new System.Drawing.Point(223, 243);
            this.txtsimpan.Name = "txtsimpan";
            this.txtsimpan.Size = new System.Drawing.Size(75, 23);
            this.txtsimpan.TabIndex = 9;
            this.txtsimpan.Text = "Simpan";
            this.txtsimpan.UseVisualStyleBackColor = true;
            this.txtsimpan.Click += new System.EventHandler(this.txtsimpan_Click);
            // 
            // Inputstatus
            // 
            this.Inputstatus.AutoSize = true;
            this.Inputstatus.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inputstatus.Location = new System.Drawing.Point(222, 191);
            this.Inputstatus.Name = "Inputstatus";
            this.Inputstatus.Size = new System.Drawing.Size(38, 12);
            this.Inputstatus.TabIndex = 8;
            this.Inputstatus.Text = "Status";
            this.Inputstatus.Click += new System.EventHandler(this.Inputstatus_Click);
            // 
            // cbstatus
            // 
            this.cbstatus.FormattingEnabled = true;
            this.cbstatus.Items.AddRange(new object[] {
            "Aktif",
            "Tidak Aktif"});
            this.cbstatus.Location = new System.Drawing.Point(262, 188);
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(87, 23);
            this.cbstatus.TabIndex = 7;
            this.cbstatus.SelectedIndexChanged += new System.EventHandler(this.cbstatus_SelectedIndexChanged);
            // 
            // txthp
            // 
            this.txthp.Location = new System.Drawing.Point(262, 159);
            this.txthp.Name = "txthp";
            this.txthp.Size = new System.Drawing.Size(226, 23);
            this.txthp.TabIndex = 6;
            this.txthp.TextChanged += new System.EventHandler(this.txthp_TextChanged);
            // 
            // Inputnohp
            // 
            this.Inputnohp.AutoSize = true;
            this.Inputnohp.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inputnohp.Location = new System.Drawing.Point(222, 162);
            this.Inputnohp.Name = "Inputnohp";
            this.Inputnohp.Size = new System.Drawing.Size(39, 12);
            this.Inputnohp.TabIndex = 5;
            this.Inputnohp.Text = "No HP";
            // 
            // Inputnama
            // 
            this.Inputnama.AutoSize = true;
            this.Inputnama.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inputnama.Location = new System.Drawing.Point(222, 133);
            this.Inputnama.Name = "Inputnama";
            this.Inputnama.Size = new System.Drawing.Size(34, 12);
            this.Inputnama.TabIndex = 4;
            this.Inputnama.Text = "Nama";
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(262, 130);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(226, 23);
            this.txtnama.TabIndex = 3;
            this.txtnama.TextChanged += new System.EventHandler(this.txtnama_TextChanged);
            // 
            // lblTotalRecord
            // 
            this.lblTotalRecord.AutoSize = true;
            this.lblTotalRecord.Location = new System.Drawing.Point(125, 289);
            this.lblTotalRecord.Name = "lblTotalRecord";
            this.lblTotalRecord.Size = new System.Drawing.Size(85, 15);
            this.lblTotalRecord.TabIndex = 2;
            this.lblTotalRecord.Text = "Total Member";
            this.lblTotalRecord.Click += new System.EventHandler(this.lblTotalRecord_Click);
            // 
            // lblStatusKoneksi
            // 
            this.lblStatusKoneksi.AutoSize = true;
            this.lblStatusKoneksi.Location = new System.Drawing.Point(569, 289);
            this.lblStatusKoneksi.Name = "lblStatusKoneksi";
            this.lblStatusKoneksi.Size = new System.Drawing.Size(89, 15);
            this.lblStatusKoneksi.TabIndex = 1;
            this.lblStatusKoneksi.Text = "Status Koneksi";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblJudul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblJudul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.Black;
            this.lblJudul.Location = new System.Drawing.Point(200, 63);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(401, 20);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "GYM DATA MASTER - SISTEM MANAJEMEN DATA GYM";
            this.lblJudul.Click += new System.EventHandler(this.lblJudul_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label Inputstatus;
        private System.Windows.Forms.ComboBox cbstatus;
        private System.Windows.Forms.TextBox txthp;
        private System.Windows.Forms.Label Inputnohp;
        private System.Windows.Forms.Label Inputnama;
        private System.Windows.Forms.Button txtupdate;
        private System.Windows.Forms.Button txthapus;
        private System.Windows.Forms.Button txtsimpan;
        private System.Windows.Forms.TextBox txtcari;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btntampilkann;
        private System.Windows.Forms.Label Inputcari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblTotalRecord;
        private System.Windows.Forms.Label lblStatusKoneksi;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}

