namespace Projectb
{
    partial class Attendancedetailofday
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendancedetailofday));
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnrucric = new System.Windows.Forms.Button();
            this.btnmanageclos = new System.Windows.Forms.Button();
            this.btnstudents = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnalltendance = new System.Windows.Forms.Button();
            this.btnevaluation = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(184, 86);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(737, 441);
            this.panel5.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(582, 344);
            this.dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Manage Assessments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnrucric
            // 
            this.btnrucric.Location = new System.Drawing.Point(3, 131);
            this.btnrucric.Name = "btnrucric";
            this.btnrucric.Size = new System.Drawing.Size(154, 46);
            this.btnrucric.TabIndex = 8;
            this.btnrucric.Text = "Manage Rubric";
            this.btnrucric.UseVisualStyleBackColor = true;
            this.btnrucric.Click += new System.EventHandler(this.btnrucric_Click);
            // 
            // btnmanageclos
            // 
            this.btnmanageclos.Location = new System.Drawing.Point(3, 67);
            this.btnmanageclos.Name = "btnmanageclos";
            this.btnmanageclos.Size = new System.Drawing.Size(154, 46);
            this.btnmanageclos.TabIndex = 7;
            this.btnmanageclos.Text = "Manage CLO\'S";
            this.btnmanageclos.UseVisualStyleBackColor = true;
            this.btnmanageclos.Click += new System.EventHandler(this.btnmanageclos_Click);
            // 
            // btnstudents
            // 
            this.btnstudents.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnstudents.Location = new System.Drawing.Point(3, 3);
            this.btnstudents.Name = "btnstudents";
            this.btnstudents.Size = new System.Drawing.Size(154, 50);
            this.btnstudents.TabIndex = 6;
            this.btnstudents.Text = "Manage Student";
            this.btnstudents.UseVisualStyleBackColor = false;
            this.btnstudents.Click += new System.EventHandler(this.btnstudents_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 441);
            this.panel3.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnrucric, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnmanageclos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnstudents, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnalltendance, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnevaluation, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 441);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(303, 19);
            this.lblname.MaximumSize = new System.Drawing.Size(400, 50);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(394, 48);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "UNIERSITY OF ENGINEERING AND TECHNOLOGY , LAHORE";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblname);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 86);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 86);
            this.panel1.TabIndex = 11;
            // 
            // btnalltendance
            // 
            this.btnalltendance.Location = new System.Drawing.Point(3, 262);
            this.btnalltendance.Name = "btnalltendance";
            this.btnalltendance.Size = new System.Drawing.Size(154, 46);
            this.btnalltendance.TabIndex = 10;
            this.btnalltendance.Text = "Manage Attendance";
            this.btnalltendance.UseVisualStyleBackColor = true;
            this.btnalltendance.Click += new System.EventHandler(this.btnalltendance_Click);
            // 
            // btnevaluation
            // 
            this.btnevaluation.Location = new System.Drawing.Point(3, 327);
            this.btnevaluation.Name = "btnevaluation";
            this.btnevaluation.Size = new System.Drawing.Size(154, 46);
            this.btnevaluation.TabIndex = 11;
            this.btnevaluation.Text = "Manage Evaluation";
            this.btnevaluation.UseVisualStyleBackColor = true;
            this.btnevaluation.Click += new System.EventHandler(this.btnevaluation_Click);
            // 
            // Attendancedetailofday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 527);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Attendancedetailofday";
            this.Text = "Attendancedetailofday";
            this.Load += new System.EventHandler(this.Attendancedetailofday_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnrucric;
        private System.Windows.Forms.Button btnmanageclos;
        private System.Windows.Forms.Button btnstudents;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label lblname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnalltendance;
        private System.Windows.Forms.Button btnevaluation;
    }
}