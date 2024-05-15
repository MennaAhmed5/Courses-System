namespace coursesProject
{
    partial class InstructorForm
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
            txt_fname = new TextBox();
            txt_lname = new TextBox();
            txt_phone = new TextBox();
            txt_deptName = new TextBox();
            new_btn = new Button();
            save_btn = new Button();
            delete_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 29);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 82);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 1;
            label2.Text = "FirstName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 140);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 2;
            label3.Text = "LastName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 187);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 239);
            label5.Name = "label5";
            label5.Size = new Size(154, 25);
            label5.TabIndex = 4;
            label5.Text = "DepartmentName";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(296, 23);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(217, 31);
            txt_id.TabIndex = 5;
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(296, 79);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(217, 31);
            txt_fname.TabIndex = 6;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(296, 134);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(217, 31);
            txt_lname.TabIndex = 7;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(296, 187);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(217, 31);
            txt_phone.TabIndex = 9;
            // 
            // txt_deptName
            // 
            txt_deptName.Location = new Point(296, 239);
            txt_deptName.Name = "txt_deptName";
            txt_deptName.Size = new Size(217, 31);
            txt_deptName.TabIndex = 10;
            // 
            // new_btn
            // 
            new_btn.Location = new Point(127, 365);
            new_btn.Name = "new_btn";
            new_btn.Size = new Size(112, 34);
            new_btn.TabIndex = 11;
            new_btn.Text = "New";
            new_btn.UseVisualStyleBackColor = true;
            new_btn.Click += new_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(350, 365);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(112, 34);
            save_btn.TabIndex = 12;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(568, 365);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(112, 34);
            delete_btn.TabIndex = 13;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(754, 450);
            Controls.Add(delete_btn);
            Controls.Add(save_btn);
            Controls.Add(new_btn);
            Controls.Add(txt_deptName);
            Controls.Add(txt_phone);
            Controls.Add(txt_lname);
            Controls.Add(txt_fname);
            Controls.Add(txt_id);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InstructorForm";
            Text = "InstructorForm";
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
        private TextBox txt_fname;
        private TextBox txt_lname;
        private TextBox txt_phone;
        private TextBox txt_deptName;
        private Button new_btn;
        private Button save_btn;
        private Button delete_btn;
    }
}