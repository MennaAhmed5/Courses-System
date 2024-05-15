namespace coursesProject
{
    partial class CourseStudentForm
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
            txt_courseid = new TextBox();
            txt_studentid = new TextBox();
            label1 = new Label();
            label2 = new Label();
            new_btn = new Button();
            save_btn = new Button();
            delete_btn = new Button();
            SuspendLayout();
            // 
            // txt_courseid
            // 
            txt_courseid.Location = new Point(254, 108);
            txt_courseid.Name = "txt_courseid";
            txt_courseid.Size = new Size(192, 31);
            txt_courseid.TabIndex = 0;
            // 
            // txt_studentid
            // 
            txt_studentid.Location = new Point(254, 195);
            txt_studentid.Name = "txt_studentid";
            txt_studentid.Size = new Size(192, 31);
            txt_studentid.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 108);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 2;
            label1.Text = "Course Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 198);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 3;
            label2.Text = "Student Id";
            // 
            // new_btn
            // 
            new_btn.Location = new Point(51, 289);
            new_btn.Name = "new_btn";
            new_btn.Size = new Size(112, 34);
            new_btn.TabIndex = 4;
            new_btn.Text = "New";
            new_btn.UseVisualStyleBackColor = true;
            new_btn.Click += new_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(264, 289);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(112, 34);
            save_btn.TabIndex = 5;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(491, 289);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(112, 34);
            delete_btn.TabIndex = 6;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // CourseStudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(704, 450);
            Controls.Add(delete_btn);
            Controls.Add(save_btn);
            Controls.Add(new_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_studentid);
            Controls.Add(txt_courseid);
            Name = "CourseStudentForm";
            Text = "CourseStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_courseid;
        private TextBox txt_studentid;
        private Label label1;
        private Label label2;
        private Button new_btn;
        private Button save_btn;
        private Button delete_btn;
    }
}