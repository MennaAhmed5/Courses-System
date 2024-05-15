namespace coursesProject.views
{
    partial class StudentForm
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
            txt_Id = new TextBox();
            txt_Fname = new TextBox();
            txt_Lname = new TextBox();
            txt_Phone = new TextBox();
            New = new Button();
            btn_save = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 27);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 90);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 1;
            label2.Text = "FirstName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 151);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 2;
            label3.Text = "LastName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 216);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(148, 27);
            txt_Id.Name = "txt_Id";
            txt_Id.ReadOnly = true;
            txt_Id.Size = new Size(239, 31);
            txt_Id.TabIndex = 4;
            // 
            // txt_Fname
            // 
            txt_Fname.Location = new Point(148, 90);
            txt_Fname.Name = "txt_Fname";
            txt_Fname.Size = new Size(239, 31);
            txt_Fname.TabIndex = 5;
            // 
            // txt_Lname
            // 
            txt_Lname.Location = new Point(148, 151);
            txt_Lname.Name = "txt_Lname";
            txt_Lname.Size = new Size(239, 31);
            txt_Lname.TabIndex = 6;
            // 
            // txt_Phone
            // 
            txt_Phone.Location = new Point(148, 216);
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(239, 31);
            txt_Phone.TabIndex = 7;
            // 
            // New
            // 
            New.Location = new Point(36, 283);
            New.Name = "New";
            New.Size = new Size(112, 34);
            New.TabIndex = 8;
            New.Text = "New";
            New.UseVisualStyleBackColor = true;
            New.Click += New_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(187, 283);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(112, 34);
            btn_save.TabIndex = 9;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += button2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(332, 283);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 11;
            button2.Text = "delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btn_save);
            Controls.Add(New);
            Controls.Add(txt_Phone);
            Controls.Add(txt_Lname);
            Controls.Add(txt_Fname);
            Controls.Add(txt_Id);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_Id;
        private TextBox txt_Fname;
        private TextBox txt_Lname;
        private TextBox txt_Phone;
        private Button New;
        private Button btn_save;
        private Button button2;
    }
}