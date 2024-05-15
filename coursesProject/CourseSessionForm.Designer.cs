namespace coursesProject
{
    partial class CourseSessionForm
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
            txt_courseId = new TextBox();
            txt_title = new TextBox();
            txt_instructorId = new TextBox();
            txt_date = new TextBox();
            new_btn = new Button();
            save_btn = new Button();
            delete_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 55);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 102);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 1;
            label2.Text = "Course ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 152);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 2;
            label3.Text = "Instructor ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 204);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 3;
            label4.Text = "Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(129, 251);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 4;
            label5.Text = "Date";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(238, 55);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(260, 31);
            txt_id.TabIndex = 5;
            // 
            // txt_courseId
            // 
            txt_courseId.Location = new Point(240, 103);
            txt_courseId.Name = "txt_courseId";
            txt_courseId.Size = new Size(258, 31);
            txt_courseId.TabIndex = 6;
            // 
            // txt_title
            // 
            txt_title.Location = new Point(240, 204);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(258, 31);
            txt_title.TabIndex = 7;
            // 
            // txt_instructorId
            // 
            txt_instructorId.Location = new Point(238, 146);
            txt_instructorId.Name = "txt_instructorId";
            txt_instructorId.Size = new Size(260, 31);
            txt_instructorId.TabIndex = 8;
            // 
            // txt_date
            // 
            txt_date.Location = new Point(240, 251);
            txt_date.Name = "txt_date";
            txt_date.Size = new Size(258, 31);
            txt_date.TabIndex = 9;
            // 
            // new_btn
            // 
            new_btn.Location = new Point(76, 312);
            new_btn.Name = "new_btn";
            new_btn.Size = new Size(112, 34);
            new_btn.TabIndex = 10;
            new_btn.Text = "New";
            new_btn.UseVisualStyleBackColor = true;
            new_btn.Click += new_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(276, 312);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(112, 34);
            save_btn.TabIndex = 11;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(464, 312);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(112, 34);
            delete_btn.TabIndex = 12;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // CourseSessionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(688, 382);
            Controls.Add(delete_btn);
            Controls.Add(save_btn);
            Controls.Add(new_btn);
            Controls.Add(txt_date);
            Controls.Add(txt_instructorId);
            Controls.Add(txt_title);
            Controls.Add(txt_courseId);
            Controls.Add(txt_id);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CourseSessionForm";
            Text = "CourseSessionForm";
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
        private TextBox txt_courseId;
        private TextBox txt_title;
        private TextBox txt_instructorId;
        private TextBox txt_date;
        private Button new_btn;
        private Button save_btn;
        private Button delete_btn;
    }
}