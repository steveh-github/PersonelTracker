namespace PersonalTracking
{
    partial class frmMain
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
            this.txtEmployee = new System.Windows.Forms.Button();
            this.txtTasks = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.Button();
            this.txtPermissions = new System.Windows.Forms.Button();
            this.txtDepartment = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.Button();
            this.txtLogOut = new System.Windows.Forms.Button();
            this.txtExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(23, 22);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(135, 50);
            this.txtEmployee.TabIndex = 0;
            this.txtEmployee.Text = "Employee";
            this.txtEmployee.UseVisualStyleBackColor = true;
            // 
            // txtTasks
            // 
            this.txtTasks.Location = new System.Drawing.Point(164, 22);
            this.txtTasks.Name = "txtTasks";
            this.txtTasks.Size = new System.Drawing.Size(135, 50);
            this.txtTasks.TabIndex = 1;
            this.txtTasks.Text = "Tasks";
            this.txtTasks.UseVisualStyleBackColor = true;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(305, 22);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(135, 50);
            this.txtSalary.TabIndex = 2;
            this.txtSalary.Text = "Salary";
            this.txtSalary.UseVisualStyleBackColor = true;
            // 
            // txtPermissions
            // 
            this.txtPermissions.Location = new System.Drawing.Point(23, 87);
            this.txtPermissions.Name = "txtPermissions";
            this.txtPermissions.Size = new System.Drawing.Size(135, 50);
            this.txtPermissions.TabIndex = 3;
            this.txtPermissions.Text = "Permissons";
            this.txtPermissions.UseVisualStyleBackColor = true;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(164, 87);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(135, 50);
            this.txtDepartment.TabIndex = 4;
            this.txtDepartment.Text = "Department";
            this.txtDepartment.UseVisualStyleBackColor = true;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(305, 87);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(135, 50);
            this.txtPosition.TabIndex = 5;
            this.txtPosition.Text = "Positions";
            this.txtPosition.UseVisualStyleBackColor = true;
            // 
            // txtLogOut
            // 
            this.txtLogOut.Location = new System.Drawing.Point(164, 166);
            this.txtLogOut.Name = "txtLogOut";
            this.txtLogOut.Size = new System.Drawing.Size(135, 50);
            this.txtLogOut.TabIndex = 6;
            this.txtLogOut.Text = "Logout";
            this.txtLogOut.UseVisualStyleBackColor = true;
            // 
            // txtExit
            // 
            this.txtExit.Location = new System.Drawing.Point(305, 166);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(135, 50);
            this.txtExit.TabIndex = 7;
            this.txtExit.Text = "Exit";
            this.txtExit.UseVisualStyleBackColor = true;
            this.txtExit.Click += new System.EventHandler(this.txtExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 232);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.txtLogOut);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtPermissions);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtTasks);
            this.Controls.Add(this.txtEmployee);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtEmployee;
        private System.Windows.Forms.Button txtTasks;
        private System.Windows.Forms.Button txtSalary;
        private System.Windows.Forms.Button txtPermissions;
        private System.Windows.Forms.Button txtDepartment;
        private System.Windows.Forms.Button txtPosition;
        private System.Windows.Forms.Button txtLogOut;
        private System.Windows.Forms.Button txtExit;
    }
}