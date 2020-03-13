namespace Tapanyagok.Views
{
    partial class TablazatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablazatForm));
            this.tablazatTS = new System.Windows.Forms.ToolStrip();
            this.mentesBtn = new System.Windows.Forms.ToolStripButton();
            this.ujBtn = new System.Windows.Forms.ToolStripButton();
            this.torlesBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.keresesTB = new System.Windows.Forms.ToolStripTextBox();
            this.keresesBtn = new System.Windows.Forms.ToolStripButton();
            this.tablazatDGV = new System.Windows.Forms.DataGridView();
            this.tablazatCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.szerkesztesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.torlesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.elsoBtn = new System.Windows.Forms.Button();
            this.elozoBtn = new System.Windows.Forms.Button();
            this.kovetkezoBtn = new System.Windows.Forms.Button();
            this.utolsoBtn = new System.Windows.Forms.Button();
            this.oldalLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tablazatTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablazatDGV)).BeginInit();
            this.tablazatCMS.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablazatTS
            // 
            this.tablazatTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mentesBtn,
            this.ujBtn,
            this.torlesBtn,
            this.toolStripSeparator1,
            this.keresesTB,
            this.keresesBtn});
            this.tablazatTS.Location = new System.Drawing.Point(0, 0);
            this.tablazatTS.Name = "tablazatTS";
            this.tablazatTS.Size = new System.Drawing.Size(800, 25);
            this.tablazatTS.TabIndex = 0;
            this.tablazatTS.Text = "toolStrip1";
            // 
            // mentesBtn
            // 
            this.mentesBtn.Image = ((System.Drawing.Image)(resources.GetObject("mentesBtn.Image")));
            this.mentesBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mentesBtn.Name = "mentesBtn";
            this.mentesBtn.Size = new System.Drawing.Size(66, 22);
            this.mentesBtn.Text = "Mentés";
            this.mentesBtn.Click += new System.EventHandler(this.mentesBtn_Click);
            // 
            // ujBtn
            // 
            this.ujBtn.Image = ((System.Drawing.Image)(resources.GetObject("ujBtn.Image")));
            this.ujBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ujBtn.Name = "ujBtn";
            this.ujBtn.Size = new System.Drawing.Size(38, 22);
            this.ujBtn.Text = "Új";
            this.ujBtn.Click += new System.EventHandler(this.ujBtn_Click);
            // 
            // torlesBtn
            // 
            this.torlesBtn.Image = ((System.Drawing.Image)(resources.GetObject("torlesBtn.Image")));
            this.torlesBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.torlesBtn.Name = "torlesBtn";
            this.torlesBtn.Size = new System.Drawing.Size(58, 22);
            this.torlesBtn.Text = "Törlés";
            this.torlesBtn.Click += new System.EventHandler(this.torlesBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // keresesTB
            // 
            this.keresesTB.Name = "keresesTB";
            this.keresesTB.Size = new System.Drawing.Size(200, 25);
            // 
            // keresesBtn
            // 
            this.keresesBtn.Image = ((System.Drawing.Image)(resources.GetObject("keresesBtn.Image")));
            this.keresesBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.keresesBtn.Name = "keresesBtn";
            this.keresesBtn.Size = new System.Drawing.Size(66, 22);
            this.keresesBtn.Text = "Keresés";
            this.keresesBtn.Click += new System.EventHandler(this.keresesBtn_Click);
            // 
            // tablazatDGV
            // 
            this.tablazatDGV.AllowUserToAddRows = false;
            this.tablazatDGV.AllowUserToDeleteRows = false;
            this.tablazatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablazatDGV.ContextMenuStrip = this.tablazatCMS;
            this.tablazatDGV.Location = new System.Drawing.Point(12, 28);
            this.tablazatDGV.Name = "tablazatDGV";
            this.tablazatDGV.Size = new System.Drawing.Size(776, 361);
            this.tablazatDGV.TabIndex = 1;
            this.tablazatDGV.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablazatDGV_CellMouseDown);
            // 
            // tablazatCMS
            // 
            this.tablazatCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerkesztesTSMI,
            this.torlesTSMI});
            this.tablazatCMS.Name = "tablazatCMS";
            this.tablazatCMS.Size = new System.Drawing.Size(133, 48);
            // 
            // szerkesztesTSMI
            // 
            this.szerkesztesTSMI.Name = "szerkesztesTSMI";
            this.szerkesztesTSMI.Size = new System.Drawing.Size(132, 22);
            this.szerkesztesTSMI.Text = "Szerkesztés";
            this.szerkesztesTSMI.Click += new System.EventHandler(this.szerkesztesTSMI_Click);
            // 
            // torlesTSMI
            // 
            this.torlesTSMI.Name = "torlesTSMI";
            this.torlesTSMI.Size = new System.Drawing.Size(132, 22);
            this.torlesTSMI.Text = "Törlés";
            this.torlesTSMI.Click += new System.EventHandler(this.torlesTSMI_Click);
            // 
            // elsoBtn
            // 
            this.elsoBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elsoBtn.Location = new System.Drawing.Point(3, 7);
            this.elsoBtn.Name = "elsoBtn";
            this.elsoBtn.Size = new System.Drawing.Size(65, 23);
            this.elsoBtn.TabIndex = 2;
            this.elsoBtn.Text = "<<";
            this.elsoBtn.UseVisualStyleBackColor = true;
            this.elsoBtn.Click += new System.EventHandler(this.elsoBtn_Click);
            // 
            // elozoBtn
            // 
            this.elozoBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elozoBtn.Location = new System.Drawing.Point(74, 7);
            this.elozoBtn.Name = "elozoBtn";
            this.elozoBtn.Size = new System.Drawing.Size(65, 23);
            this.elozoBtn.TabIndex = 3;
            this.elozoBtn.Text = "<";
            this.elozoBtn.UseVisualStyleBackColor = true;
            this.elozoBtn.Click += new System.EventHandler(this.elozoBtn_Click);
            // 
            // kovetkezoBtn
            // 
            this.kovetkezoBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kovetkezoBtn.Location = new System.Drawing.Point(216, 7);
            this.kovetkezoBtn.Name = "kovetkezoBtn";
            this.kovetkezoBtn.Size = new System.Drawing.Size(65, 23);
            this.kovetkezoBtn.TabIndex = 4;
            this.kovetkezoBtn.Text = ">";
            this.kovetkezoBtn.UseVisualStyleBackColor = true;
            this.kovetkezoBtn.Click += new System.EventHandler(this.kovetkezoBtn_Click);
            // 
            // utolsoBtn
            // 
            this.utolsoBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.utolsoBtn.Location = new System.Drawing.Point(287, 7);
            this.utolsoBtn.Name = "utolsoBtn";
            this.utolsoBtn.Size = new System.Drawing.Size(66, 23);
            this.utolsoBtn.TabIndex = 5;
            this.utolsoBtn.Text = ">>";
            this.utolsoBtn.UseVisualStyleBackColor = true;
            this.utolsoBtn.Click += new System.EventHandler(this.utolsoBtn_Click);
            // 
            // oldalLbl
            // 
            this.oldalLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oldalLbl.AutoSize = true;
            this.oldalLbl.Location = new System.Drawing.Point(165, 12);
            this.oldalLbl.Name = "oldalLbl";
            this.oldalLbl.Size = new System.Drawing.Size(24, 13);
            this.oldalLbl.TabIndex = 6;
            this.oldalLbl.Text = "0/0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 43);
            this.panel1.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.oldalLbl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.elozoBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.elsoBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kovetkezoBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.utolsoBtn, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(210, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 37);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // TablazatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tablazatDGV);
            this.Controls.Add(this.tablazatTS);
            this.Name = "TablazatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TablazatForm";
            this.tablazatTS.ResumeLayout(false);
            this.tablazatTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablazatDGV)).EndInit();
            this.tablazatCMS.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tablazatTS;
        private System.Windows.Forms.ToolStripButton mentesBtn;
        private System.Windows.Forms.ToolStripButton ujBtn;
        private System.Windows.Forms.ToolStripButton torlesBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox keresesTB;
        private System.Windows.Forms.ToolStripButton keresesBtn;
        private System.Windows.Forms.DataGridView tablazatDGV;
        private System.Windows.Forms.Button elsoBtn;
        private System.Windows.Forms.Button elozoBtn;
        private System.Windows.Forms.Button kovetkezoBtn;
        private System.Windows.Forms.Button utolsoBtn;
        private System.Windows.Forms.Label oldalLbl;
        private System.Windows.Forms.ContextMenuStrip tablazatCMS;
        private System.Windows.Forms.ToolStripMenuItem szerkesztesTSMI;
        private System.Windows.Forms.ToolStripMenuItem torlesTSMI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}