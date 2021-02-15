namespace AdapterDesignPattern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtlist = new System.Windows.Forms.ListBox();
            this.btnTextFile = new DevExpress.XtraEditors.SimpleButton();
            this.btnxmlfile = new DevExpress.XtraEditors.SimpleButton();
            this.btnsqlveri = new DevExpress.XtraEditors.SimpleButton();
            this.gridveri = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridveri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtlist
            // 
            this.txtlist.FormattingEnabled = true;
            this.txtlist.Location = new System.Drawing.Point(12, 66);
            this.txtlist.Name = "txtlist";
            this.txtlist.Size = new System.Drawing.Size(298, 277);
            this.txtlist.TabIndex = 2;
            // 
            // btnTextFile
            // 
            this.btnTextFile.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTextFile.Appearance.Options.UseBackColor = true;
            this.btnTextFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTextFile.ImageOptions.Image")));
            this.btnTextFile.Location = new System.Drawing.Point(32, 368);
            this.btnTextFile.Name = "btnTextFile";
            this.btnTextFile.Size = new System.Drawing.Size(203, 47);
            this.btnTextFile.TabIndex = 4;
            this.btnTextFile.Text = "Text Dosyasından Veri Çekme";
            this.btnTextFile.Click += new System.EventHandler(this.btnTextFile_Click);
            // 
            // btnxmlfile
            // 
            this.btnxmlfile.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnxmlfile.Appearance.Options.UseBackColor = true;
            this.btnxmlfile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxmlfile.ImageOptions.Image")));
            this.btnxmlfile.Location = new System.Drawing.Point(384, 368);
            this.btnxmlfile.Name = "btnxmlfile";
            this.btnxmlfile.Size = new System.Drawing.Size(218, 47);
            this.btnxmlfile.TabIndex = 5;
            this.btnxmlfile.Text = "Xml Dosyasından Veri Çekme";
            this.btnxmlfile.Click += new System.EventHandler(this.btnxmlfile_Click);
            // 
            // btnsqlveri
            // 
            this.btnsqlveri.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsqlveri.Appearance.Options.UseBackColor = true;
            this.btnsqlveri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsqlveri.ImageOptions.Image")));
            this.btnsqlveri.Location = new System.Drawing.Point(753, 368);
            this.btnsqlveri.Name = "btnsqlveri";
            this.btnsqlveri.Size = new System.Drawing.Size(218, 47);
            this.btnsqlveri.TabIndex = 6;
            this.btnsqlveri.Text = "Veri Tabanından Veri Çekme";
            this.btnsqlveri.Click += new System.EventHandler(this.btnsqlveri_Click);
            // 
            // gridveri
            // 
            this.gridveri.Location = new System.Drawing.Point(696, 66);
            this.gridveri.MainView = this.gridView1;
            this.gridveri.Name = "gridveri";
            this.gridveri.Size = new System.Drawing.Size(309, 277);
            this.gridveri.TabIndex = 7;
            this.gridveri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridveri;
            this.gridView1.Name = "gridView1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(354, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(306, 277);
            this.dataGridView1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Text dosyasında bulunan çalışan bilgileri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(350, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Xml dosyasında bulunan çalışan bilgileri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(692, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sql veri tabanında bulunan çalışan bilgileri:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1017, 459);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gridveri);
            this.Controls.Add(this.btnsqlveri);
            this.Controls.Add(this.btnxmlfile);
            this.Controls.Add(this.btnTextFile);
            this.Controls.Add(this.txtlist);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridveri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox txtlist;
        private DevExpress.XtraEditors.SimpleButton btnTextFile;
        private DevExpress.XtraEditors.SimpleButton btnxmlfile;
        private DevExpress.XtraEditors.SimpleButton btnsqlveri;
        private DevExpress.XtraGrid.GridControl gridveri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

