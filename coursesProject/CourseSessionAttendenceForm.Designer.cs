namespace coursesProject
{
    partial class CourseSessionAttendenceForm
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
            txt_courseSessionId = new TextBox();
            txt_studentid = new TextBox();
            txt_grade = new TextBox();
            txt_id = new TextBox();
            new_btn = new Button();
            save_btn = new Button();
            delete_btn = new Button();
            txt_notes = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 55);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 115);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 1;
            label2.Text = "CourseSessionId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 175);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "StudentID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 237);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 3;
            label4.Text = "Grade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 294);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 4;
            label5.Text = "Notes";
            // 
            // txt_courseSessionId
            // 
            txt_courseSessionId.Location = new Point(211, 115);
            txt_courseSessionId.Name = "txt_courseSessionId";
            txt_courseSessionId.Size = new Size(255, 31);
            txt_courseSessionId.TabIndex = 5;
            // 
            // txt_studentid
            // 
            txt_studentid.Location = new Point(211, 175);
            txt_studentid.Name = "txt_studentid";
            txt_studentid.Size = new Size(255, 31);
            txt_studentid.TabIndex = 6;
            // 
            // txt_grade
            // 
            txt_grade.Location = new Point(211, 231);
            txt_grade.Name = "txt_grade";
            txt_grade.Size = new Size(255, 31);
            txt_grade.TabIndex = 7;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(209, 55);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(255, 31);
            txt_id.TabIndex = 8;
            // 
            // new_btn
            // 
            new_btn.Location = new Point(53, 388);
            new_btn.Name = "new_btn";
            new_btn.Size = new Size(112, 34);
            new_btn.TabIndex = 9;
            new_btn.Text = "New";
            new_btn.UseVisualStyleBackColor = true;
            new_btn.Click += new_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(242, 388);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(112, 34);
            save_btn.TabIndex = 10;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(437, 388);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(112, 34);
            delete_btn.TabIndex = 11;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // txt_notes
            // 
            txt_notes.Location = new Point(209, 291);
            txt_notes.Name = "txt_notes";
            txt_notes.Size = new Size(255, 31);
            txt_notes.TabIndex = 12;
            // 
            // CourseSessionAttendenceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(645, 450);
            Controls.Add(txt_notes);
            Controls.Add(delete_btn);
            Controls.Add(save_btn);
            Controls.Add(new_btn);
            Controls.Add(txt_id);
            Controls.Add(txt_grade);
            Controls.Add(txt_studentid);
            Controls.Add(txt_courseSessionId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CourseSessionAttendenceForm";
            Text = "CourseSessionAttendenceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_courseSessionId;
        private TextBox txt_studentid;
        private TextBox txt_grade;
        private TextBox txt_id;
        private Button new_btn;
        private Button save_btn;
        private Button delete_btn;
        private TextBox txt_notes;
    }
}