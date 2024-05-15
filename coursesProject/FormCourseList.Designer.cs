namespace coursesProject
{
    partial class FormCourseList
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
            search_id = new TextBox();
            search_name = new TextBox();
            dataGridView1 = new DataGridView();
            open_btn = new Button();
            load_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 28);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 28);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // search_id
            // 
            search_id.Location = new Point(110, 28);
            search_id.Name = "search_id";
            search_id.Size = new Size(195, 31);
            search_id.TabIndex = 2;
            // 
            // search_name
            // 
            search_name.Location = new Point(433, 28);
            search_name.Name = "search_name";
            search_name.Size = new Size(215, 31);
            search_name.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(744, 300);
            dataGridView1.TabIndex = 4;
            // 
            // open_btn
            // 
            open_btn.Location = new Point(613, 393);
            open_btn.Name = "open_btn";
            open_btn.Size = new Size(112, 34);
            open_btn.TabIndex = 5;
            open_btn.Text = "Open";
            open_btn.UseVisualStyleBackColor = true;
            open_btn.Click += open_btn_Click;
            // 
            // load_btn
            // 
            load_btn.Location = new Point(50, 393);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(112, 34);
            load_btn.TabIndex = 6;
            load_btn.Text = "Load";
            load_btn.UseVisualStyleBackColor = true;
            load_btn.Click += load_btn_Click_1;
            // 
            // FormCourseList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(load_btn);
            Controls.Add(open_btn);
            Controls.Add(dataGridView1);
            Controls.Add(search_name);
            Controls.Add(search_id);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCourseList";
            Text = "FormCourseList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox search_id;
        private TextBox search_name;
        private DataGridView dataGridView1;
        private Button open_btn;
        private Button load_btn;
    }
}