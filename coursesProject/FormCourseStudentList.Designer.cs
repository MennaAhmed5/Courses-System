namespace coursesProject
{
    partial class FormCourseStudentList
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
            search_studentId = new TextBox();
            search_courseid = new TextBox();
            dataGridView1 = new DataGridView();
            open_btn = new Button();
            btn_load = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 30);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 0;
            label1.Text = "Student Id ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 30);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 1;
            label2.Text = "Course Id ";
            // 
            // search_studentId
            // 
            search_studentId.Location = new Point(149, 30);
            search_studentId.Name = "search_studentId";
            search_studentId.Size = new Size(226, 31);
            search_studentId.TabIndex = 2;
            // 
            // search_courseid
            // 
            search_courseid.Location = new Point(517, 30);
            search_courseid.Name = "search_courseid";
            search_courseid.Size = new Size(227, 31);
            search_courseid.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(745, 275);
            dataGridView1.TabIndex = 4;
            // 
            // open_btn
            // 
            open_btn.Location = new Point(595, 386);
            open_btn.Name = "open_btn";
            open_btn.Size = new Size(112, 34);
            open_btn.TabIndex = 5;
            open_btn.Text = "Open";
            open_btn.UseVisualStyleBackColor = true;
            open_btn.Click += open_btn_Click;
            // 
            // btn_load
            // 
            btn_load.Location = new Point(49, 386);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(112, 34);
            btn_load.TabIndex = 6;
            btn_load.Text = "Load";
            btn_load.UseVisualStyleBackColor = true;
            btn_load.Click += btn_load_Click;
            // 
            // FormCourseStudentList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_load);
            Controls.Add(open_btn);
            Controls.Add(dataGridView1);
            Controls.Add(search_courseid);
            Controls.Add(search_studentId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCourseStudentList";
            Text = "FormCourseStudentList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox search_studentId;
        private TextBox search_courseid;
        private DataGridView dataGridView1;
        private Button open_btn;
        private Button btn_load;
    }
}