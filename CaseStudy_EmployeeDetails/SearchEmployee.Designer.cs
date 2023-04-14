using System;

namespace CaseStudy_EmployeeDetails
{
    partial class SearchEmployee
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
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEmpDetails = new System.Windows.Forms.DataGridView();
            this.btnViewAllEmp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpSearch = new System.Windows.Forms.TextBox();
            this.btnEmpSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.AutoEllipsis = true;
            this.btnHome.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnHome.ForeColor = System.Drawing.SystemColors.Info;
            this.btnHome.Location = new System.Drawing.Point(26, 65);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(293, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Details";
            // 
            // dataGridViewEmpDetails
            // 
            this.dataGridViewEmpDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpDetails.Location = new System.Drawing.Point(367, 107);
            this.dataGridViewEmpDetails.Name = "dataGridViewEmpDetails";
            this.dataGridViewEmpDetails.RowHeadersWidth = 51;
            this.dataGridViewEmpDetails.RowTemplate.Height = 24;
            this.dataGridViewEmpDetails.Size = new System.Drawing.Size(669, 401);
            this.dataGridViewEmpDetails.TabIndex = 1;
            // 
            // btnViewAllEmp
            // 
            this.btnViewAllEmp.Location = new System.Drawing.Point(16, 243);
            this.btnViewAllEmp.Name = "btnViewAllEmp";
            this.btnViewAllEmp.Size = new System.Drawing.Size(148, 44);
            this.btnViewAllEmp.TabIndex = 2;
            this.btnViewAllEmp.Text = "View All Employees Details";
            this.btnViewAllEmp.UseVisualStyleBackColor = true;
            this.btnViewAllEmp.Click += new System.EventHandler(this.btnViewAllEmp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "EmpId";
            // 
            // txtEmpSearch
            // 
            this.txtEmpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpSearch.Location = new System.Drawing.Point(100, 137);
            this.txtEmpSearch.Name = "txtEmpSearch";
            this.txtEmpSearch.Size = new System.Drawing.Size(119, 23);
            this.txtEmpSearch.TabIndex = 4;
            // 
            // btnEmpSearch
            // 
            this.btnEmpSearch.Location = new System.Drawing.Point(100, 181);
            this.btnEmpSearch.Name = "btnEmpSearch";
            this.btnEmpSearch.Size = new System.Drawing.Size(75, 23);
            this.btnEmpSearch.TabIndex = 5;
            this.btnEmpSearch.Text = "Search";
            this.btnEmpSearch.UseVisualStyleBackColor = true;
            this.btnEmpSearch.Click += new System.EventHandler(this.btnEmpSearch_Click);
            // 
            // SearchEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(928, 520);
            this.Controls.Add(this.btnEmpSearch);
            this.Controls.Add(this.txtEmpSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnViewAllEmp);
            this.Controls.Add(this.dataGridViewEmpDetails);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SearchEmployee";
            this.Text = "SearchEmployee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEmpDetails;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnViewAllEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpSearch;
        private System.Windows.Forms.Button btnEmpSearch;
    }
}