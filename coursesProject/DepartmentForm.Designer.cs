namespace coursesProject
{
    partial class DepartmentForm
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
            txt_name = new TextBox();
            txt_location = new TextBox();
            New_btn = new Button();
            Save_btn = new Button();
            delete_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 37);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 110);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 1;
            label2.Text = "Location";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(253, 37);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(202, 31);
            txt_name.TabIndex = 2;
            // 
            // txt_location
            // 
            txt_location.Location = new Point(253, 110);
            txt_location.Name = "txt_location";
            txt_location.Size = new Size(202, 31);
            txt_location.TabIndex = 3;
            // 
            // New_btn
            // 
            New_btn.Location = new Point(123, 258);
            New_btn.Name = "New_btn";
            New_btn.Size = new Size(112, 34);
            New_btn.TabIndex = 4;
            New_btn.Text = "New";
            New_btn.UseVisualStyleBackColor = true;
            New_btn.Click += New_btn_Click;
            // 
            // Save_btn
            // 
            Save_btn.Location = new Point(311, 258);
            Save_btn.Name = "Save_btn";
            Save_btn.RightToLeft = RightToLeft.Yes;
            Save_btn.Size = new Size(112, 34);
            Save_btn.TabIndex = 5;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = true;
            Save_btn.Click += Save_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(501, 258);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(112, 34);
            delete_btn.TabIndex = 6;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(delete_btn);
            Controls.Add(Save_btn);
            Controls.Add(New_btn);
            Controls.Add(txt_location);
            Controls.Add(txt_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DepartmentForm";
            Text = "DepartmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_name;
        private TextBox txt_location;
        private Button New_btn;
        private Button Save_btn;
        private Button delete_btn;
    }
}