namespace Tapanyagok.Views
{
    partial class TapanyagForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.okBtn = new System.Windows.Forms.Button();
            this.megseBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.energiaNUD = new System.Windows.Forms.NumericUpDown();
            this.feherjeNUD = new System.Windows.Forms.NumericUpDown();
            this.zsirNUD = new System.Windows.Forms.NumericUpDown();
            this.szenhidratNUD = new System.Windows.Forms.NumericUpDown();
            this.nevTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.energiaNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feherjeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zsirNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szenhidratNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 363);
            this.panel1.TabIndex = 0;
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(39, 398);
            this.okBtn.Margin = new System.Windows.Forms.Padding(30, 20, 20, 20);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // megseBtn
            // 
            this.megseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.megseBtn.Location = new System.Drawing.Point(686, 398);
            this.megseBtn.Margin = new System.Windows.Forms.Padding(20, 20, 30, 20);
            this.megseBtn.Name = "megseBtn";
            this.megseBtn.Size = new System.Drawing.Size(75, 23);
            this.megseBtn.TabIndex = 2;
            this.megseBtn.Text = "Mégse";
            this.megseBtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.feherjeNUD, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.zsirNUD, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.szenhidratNUD, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.energiaNUD, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nevTB, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 357);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Energia";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fehérje";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zsír";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Szénhidrát";
            // 
            // energiaNUD
            // 
            this.energiaNUD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.energiaNUD.DecimalPlaces = 1;
            this.energiaNUD.Location = new System.Drawing.Point(157, 190);
            this.energiaNUD.Name = "energiaNUD";
            this.energiaNUD.Size = new System.Drawing.Size(610, 20);
            this.energiaNUD.TabIndex = 5;
            // 
            // feherjeNUD
            // 
            this.feherjeNUD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.feherjeNUD.DecimalPlaces = 1;
            this.feherjeNUD.Location = new System.Drawing.Point(157, 234);
            this.feherjeNUD.Name = "feherjeNUD";
            this.feherjeNUD.Size = new System.Drawing.Size(610, 20);
            this.feherjeNUD.TabIndex = 6;
            // 
            // zsirNUD
            // 
            this.zsirNUD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zsirNUD.DecimalPlaces = 1;
            this.zsirNUD.Location = new System.Drawing.Point(157, 278);
            this.zsirNUD.Name = "zsirNUD";
            this.zsirNUD.Size = new System.Drawing.Size(610, 20);
            this.zsirNUD.TabIndex = 7;
            // 
            // szenhidratNUD
            // 
            this.szenhidratNUD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.szenhidratNUD.DecimalPlaces = 1;
            this.szenhidratNUD.Location = new System.Drawing.Point(157, 323);
            this.szenhidratNUD.Name = "szenhidratNUD";
            this.szenhidratNUD.Size = new System.Drawing.Size(610, 20);
            this.szenhidratNUD.TabIndex = 8;
            // 
            // nevTB
            // 
            this.nevTB.Location = new System.Drawing.Point(157, 3);
            this.nevTB.Multiline = true;
            this.nevTB.Name = "nevTB";
            this.nevTB.Size = new System.Drawing.Size(610, 172);
            this.nevTB.TabIndex = 9;
            // 
            // TapanyagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.megseBtn);
            this.Controls.Add(this.panel1);
            this.Name = "TapanyagForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TapanyagForm";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.energiaNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feherjeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zsirNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szenhidratNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown feherjeNUD;
        private System.Windows.Forms.NumericUpDown zsirNUD;
        private System.Windows.Forms.NumericUpDown szenhidratNUD;
        private System.Windows.Forms.NumericUpDown energiaNUD;
        private System.Windows.Forms.TextBox nevTB;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button megseBtn;
    }
}