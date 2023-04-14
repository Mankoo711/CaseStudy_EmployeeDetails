namespace CaseStudy_EmployeeDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnManageEmp = new System.Windows.Forms.Button();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(281, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management Portal";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 125);
            this.panel1.TabIndex = 1;
            // 
            // btnManageEmp
            // 
            this.btnManageEmp.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnManageEmp.ForeColor = System.Drawing.SystemColors.Info;
            this.btnManageEmp.Location = new System.Drawing.Point(320, 184);
            this.btnManageEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManageEmp.Name = "btnManageEmp";
            this.btnManageEmp.Size = new System.Drawing.Size(108, 48);
            this.btnManageEmp.TabIndex = 3;
            this.btnManageEmp.Text = "Manage Employee";
            this.btnManageEmp.UseVisualStyleBackColor = false;
            this.btnManageEmp.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSearchEmp.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSearchEmp.Location = new System.Drawing.Point(521, 184);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(109, 48);
            this.btnSearchEmp.TabIndex = 4;
            this.btnSearchEmp.Text = "Search Employee";
            this.btnSearchEmp.UseVisualStyleBackColor = false;
            this.btnSearchEmp.Click += new System.EventHandler(this.btnSearchEmp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1151, 631);
            this.Controls.Add(this.btnSearchEmp);
            this.Controls.Add(this.btnManageEmp);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnManageEmp;
        private System.Windows.Forms.Button btnSearchEmp;
    }
}

