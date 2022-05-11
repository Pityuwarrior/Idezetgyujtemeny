namespace WFA20220509
{
    partial class FrmMain
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
            this.label_idezet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ldatum = new System.Windows.Forms.Label();
            this.lcount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.tema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Isz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.szerkesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.szerzőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.témaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idézetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_idezet
            // 
            this.label_idezet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_idezet.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_idezet.Location = new System.Drawing.Point(90, 52);
            this.label_idezet.Name = "label_idezet";
            this.label_idezet.Size = new System.Drawing.Size(528, 82);
            this.label_idezet.TabIndex = 0;
            this.label_idezet.Text = "label1";
            this.label_idezet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "A nap idézete";
            // 
            // ldatum
            // 
            this.ldatum.AutoSize = true;
            this.ldatum.Location = new System.Drawing.Point(690, 13);
            this.ldatum.Name = "ldatum";
            this.ldatum.Size = new System.Drawing.Size(95, 13);
            this.ldatum.TabIndex = 2;
            this.ldatum.Text = "###DateTime###";
            // 
            // lcount
            // 
            this.lcount.AutoSize = true;
            this.lcount.Location = new System.Drawing.Point(664, 82);
            this.lcount.Name = "lcount";
            this.lcount.Size = new System.Drawing.Size(35, 13);
            this.lcount.TabIndex = 3;
            this.lcount.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Az idézetek száma témák szerint";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Az idézetek száma szerzők szerint:";
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tema,
            this.Isz});
            this.dgv1.Location = new System.Drawing.Point(29, 188);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv1.Size = new System.Drawing.Size(273, 226);
            this.dgv1.TabIndex = 6;
            // 
            // tema
            // 
            this.tema.HeaderText = "Téma";
            this.tema.Name = "tema";
            // 
            // Isz
            // 
            this.Isz.HeaderText = "Idézetek száma";
            this.Isz.Name = "Isz";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerkesztésToolStripMenuItem,
            this.keresésToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(667, 159);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(124, 258);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // szerkesztésToolStripMenuItem
            // 
            this.szerkesztésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.szerzőToolStripMenuItem,
            this.témaToolStripMenuItem,
            this.forrásToolStripMenuItem,
            this.idézetToolStripMenuItem});
            this.szerkesztésToolStripMenuItem.Image = global::WFA20220509.Properties.Resources.edit;
            this.szerkesztésToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
            this.szerkesztésToolStripMenuItem.Size = new System.Drawing.Size(117, 83);
            this.szerkesztésToolStripMenuItem.Text = "Szerkesztés";
            this.szerkesztésToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // szerzőToolStripMenuItem
            // 
            this.szerzőToolStripMenuItem.Name = "szerzőToolStripMenuItem";
            this.szerzőToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.szerzőToolStripMenuItem.Text = "Szerző";
            this.szerzőToolStripMenuItem.Click += new System.EventHandler(this.szerzőToolStripMenuItem_Click);
            // 
            // témaToolStripMenuItem
            // 
            this.témaToolStripMenuItem.Name = "témaToolStripMenuItem";
            this.témaToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.témaToolStripMenuItem.Text = "Téma";
            // 
            // forrásToolStripMenuItem
            // 
            this.forrásToolStripMenuItem.Name = "forrásToolStripMenuItem";
            this.forrásToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.forrásToolStripMenuItem.Text = "Forrás";
            // 
            // idézetToolStripMenuItem
            // 
            this.idézetToolStripMenuItem.Name = "idézetToolStripMenuItem";
            this.idézetToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.idézetToolStripMenuItem.Text = "Idézet";
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Image = global::WFA20220509.Properties.Resources.search;
            this.keresésToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(117, 83);
            this.keresésToolStripMenuItem.Text = "Keresés";
            this.keresésToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv2.Location = new System.Drawing.Point(345, 188);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersVisible = false;
            this.dgv2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv2.Size = new System.Drawing.Size(273, 226);
            this.dgv2.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Szerző";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Idézetek száma";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lcount);
            this.Controls.Add(this.ldatum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_idezet);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Idézetgyűjtemény ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_idezet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ldatum;
        private System.Windows.Forms.Label lcount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem szerkesztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem szerzőToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem témaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forrásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idézetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Isz;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

