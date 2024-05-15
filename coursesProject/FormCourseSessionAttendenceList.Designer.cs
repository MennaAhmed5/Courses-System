namespace coursesProject
{
    partial class FormCourseSessionAttendenceList
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
            dataGridView1 = new DataGridView();
            open_btn = new Button();
            load_btn = new Button();
            search_id = new TextBox();
            search_note = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(707, 303);
            dataGridView1.TabIndex = 0;
            // 
            // open_btn
            // 
            open_btn.Location = new Point(601, 393);
            open_btn.Name = "open_btn";
            open_btn.Size = new Size(112, 34);
            open_btn.TabIndex = 1;
            open_btn.Text = "Open";
            open_btn.UseVisualStyleBackColor = true;
            open_btn.Click += open_btn_Click;
            // 
            // load_btn
            // 
            load_btn.Location = new Point(108, 393);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(112, 34);
            load_btn.TabIndex = 2;
            load_btn.Text = "Load";
            load_btn.UseVisualStyleBackColor = true;
            load_btn.Click += load_btn_Click;
            // 
            // search_id
            // 
            search_id.Location = new Point(136, 23);
            search_id.Name = "search_id";
            search_id.Size = new Size(223, 31);
            search_id.TabIndex = 3;
            // 
            // search_note
            // 
            search_note.Location = new Point(461, 23);
            search_note.Name = "search_note";
            search_note.Size = new Size(252, 31);
            search_note.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 27);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 5;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(387, 26);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 6;
            label2.Text = "Notes";
            // 
            // FormCourseSessionAttendenceList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(search_note);
            Controls.Add(search_id);
            Controls.Add(load_btn);
            Controls.Add(open_btn);
            Controls.Add(dataGridView1);
            Name = "FormCourseSessionAttendenceList";
            Text = "FormCourseSessionAttendenceList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button open_btn;
        private Button load_btn;
        private TextBox search_id;
        private TextBox search_note;
        private Label label1;
        private Label label2;
    }
}