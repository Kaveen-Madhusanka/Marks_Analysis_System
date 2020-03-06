namespace PDSA
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsindex = new System.Windows.Forms.TextBox();
            this.txtmarksol = new System.Windows.Forms.TextBox();
            this.txtmarksendturm = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oldDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateStaticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblstd = new System.Windows.Forms.Label();
            this.lblcov = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Index Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "O/L Marks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "End Term Marks";
            // 
            // txtsindex
            // 
            this.txtsindex.Location = new System.Drawing.Point(255, 93);
            this.txtsindex.Name = "txtsindex";
            this.txtsindex.Size = new System.Drawing.Size(148, 20);
            this.txtsindex.TabIndex = 6;
            // 
            // txtmarksol
            // 
            this.txtmarksol.Location = new System.Drawing.Point(255, 136);
            this.txtmarksol.Name = "txtmarksol";
            this.txtmarksol.Size = new System.Drawing.Size(148, 20);
            this.txtmarksol.TabIndex = 7;
            this.txtmarksol.Leave += new System.EventHandler(this.txtmarksol_Leave);
            // 
            // txtmarksendturm
            // 
            this.txtmarksendturm.Location = new System.Drawing.Point(255, 175);
            this.txtmarksendturm.Name = "txtmarksendturm";
            this.txtmarksendturm.Size = new System.Drawing.Size(148, 20);
            this.txtmarksendturm.TabIndex = 8;
            this.txtmarksendturm.Leave += new System.EventHandler(this.txtmarksendturm_Leave);
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(122, 259);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(110, 34);
            this.btninsert.TabIndex = 9;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(238, 259);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(110, 34);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(167, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "Display";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(395, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 34);
            this.button4.TabIndex = 12;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 13;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Years";
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(255, 214);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(148, 20);
            this.txtyear.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(281, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 54);
            this.panel1.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Marks Analysis System";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oldDetailsToolStripMenuItem,
            this.calculateStaticsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oldDetailsToolStripMenuItem
            // 
            this.oldDetailsToolStripMenuItem.Name = "oldDetailsToolStripMenuItem";
            this.oldDetailsToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.oldDetailsToolStripMenuItem.Text = "Old Details";
            this.oldDetailsToolStripMenuItem.Click += new System.EventHandler(this.oldDetailsToolStripMenuItem_Click);
            // 
            // calculateStaticsToolStripMenuItem
            // 
            this.calculateStaticsToolStripMenuItem.Name = "calculateStaticsToolStripMenuItem";
            this.calculateStaticsToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.calculateStaticsToolStripMenuItem.Text = "Calculate Statics";
            this.calculateStaticsToolStripMenuItem.Click += new System.EventHandler(this.calculateStaticsToolStripMenuItem_Click_2);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(116, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Mean                          : ";
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmin.Location = new System.Drawing.Point(307, 132);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(19, 20);
            this.lblmin.TabIndex = 25;
            this.lblmin.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(116, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Standard Deviation    : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(116, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Correlation Cofficient : ";
            this.label10.Visible = false;
            // 
            // lblstd
            // 
            this.lblstd.AutoSize = true;
            this.lblstd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstd.Location = new System.Drawing.Point(307, 167);
            this.lblstd.Name = "lblstd";
            this.lblstd.Size = new System.Drawing.Size(19, 20);
            this.lblstd.TabIndex = 28;
            this.lblstd.Text = "0";
            // 
            // lblcov
            // 
            this.lblcov.AutoSize = true;
            this.lblcov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcov.Location = new System.Drawing.Point(307, 197);
            this.lblcov.Name = "lblcov";
            this.lblcov.Size = new System.Drawing.Size(19, 20);
            this.lblcov.TabIndex = 29;
            this.lblcov.Text = "0";
            this.lblcov.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(777, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 30;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtyear);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btninsert);
            this.panel2.Controls.Add(this.txtmarksendturm);
            this.panel2.Controls.Add(this.txtmarksol);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.txtsindex);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 313);
            this.panel2.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(102, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "STUDENT DETAILS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.lblcov);
            this.panel3.Controls.Add(this.lblstd);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lblmin);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(461, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 313);
            this.panel3.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(140, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "CALCULATION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::PDSA.Properties.Resources.download111;
            this.pictureBox1.Location = new System.Drawing.Point(122, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(915, 550);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsindex;
        private System.Windows.Forms.TextBox txtmarksol;
        private System.Windows.Forms.TextBox txtmarksendturm;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oldDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateStaticsToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblstd;
        private System.Windows.Forms.Label lblcov;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
    }
}