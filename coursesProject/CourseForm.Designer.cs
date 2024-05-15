namespace coursesProject
{
    partial class CourseForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_id = new TextBox();
            txt_name = new TextBox();
            txt_duration = new TextBox();
            txt_deptname = new TextBox();
            txt_instructorid = new TextBox();
            new_btn = new Button();
            delete_btn = new Button();
            save_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 41);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 91);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 143);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 2;
            label3.Text = "Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 200);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 3;
            label4.Text = "DepartmentName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 251);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 4;
            label5.Text = "InstructorId";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(277, 41);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(209, 31);
            txt_id.TabIndex = 5;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(277, 91);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(209, 31);
            txt_name.TabIndex = 6;
            // 
            // txt_duration
            // 
            txt_duration.Location = new Point(277, 143);
            txt_duration.Name = "txt_duration";
            txt_duration.Size = new Size(209, 31);
            txt_duration.TabIndex = 7;
            // 
            // txt_deptname
            // 
            txt_deptname.Location = new Point(277, 200);
            txt_deptname.Name = "txt_deptname";
            txt_deptname.Size = new Size(209, 31);
            txt_deptname.TabIndex = 8;
            // 
            // txt_instructorid
            // 
            txt_instructorid.Location = new Point(277, 251);
            txt_instructorid.Name = "txt_instructorid";
            txt_instructorid.Size = new Size(209, 31);
            txt_instructorid.TabIndex = 9;
            // 
            // new_btn
            // 
            new_btn.Location = new Point(135, 309);
            new_btn.Name = "new_btn";
            new_btn.Size = new Size(112, 34);
            new_btn.TabIndex = 10;
            new_btn.Text = "New";
            new_btn.UseVisualStyleBackColor = true;
            new_btn.Click += new_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(540, 309);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(112, 34);
            delete_btn.TabIndex = 11;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(334, 309);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(112, 34);
            save_btn.TabIndex = 12;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(save_btn);
            Controls.Add(delete_btn);
            Controls.Add(new_btn);
            Controls.Add(txt_instructorid);
            Controls.Add(txt_deptname);
            Controls.Add(txt_duration);
            Controls.Add(txt_name);
            Controls.Add(txt_id);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CourseForm";
            Text = "CourseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_id;
        private TextBox txt_name;
        private TextBox txt_duration;
        private TextBox txt_deptname;
        private TextBox txt_instructorid;
        private Button new_btn;
        private Button delete_btn;
        private Button save_btn;
    }
}