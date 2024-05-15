namespace coursesProject
{
    partial class FormCourseSessionList
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
            dataGridView1 = new DataGridView();
            btn_load = new Button();
            open_btn = new Button();
            search_title = new TextBox();
            search_id = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 17);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 17);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(726, 307);
            dataGridView1.TabIndex = 2;
            // 
            // btn_load
            // 
            btn_load.Location = new Point(71, 388);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(112, 34);
            btn_load.TabIndex = 4;
            btn_load.Text = "Load";
            btn_load.UseVisualStyleBackColor = true;
            btn_load.Click += btn_load_Click;
            // 
            // open_btn
            // 
            open_btn.Location = new Point(574, 388);
            open_btn.Name = "open_btn";
            open_btn.Size = new Size(112, 34);
            open_btn.TabIndex = 5;
            open_btn.Text = "Open";
            open_btn.UseVisualStyleBackColor = true;
            open_btn.Click += open_btn_Click;
            // 
            // search_title
            // 
            search_title.Location = new Point(485, 14);
            search_title.Name = "search_title";
            search_title.Size = new Size(234, 31);
            search_title.TabIndex = 6;
            // 
            // search_id
            // 
            search_id.Location = new Point(110, 14);
            search_id.Name = "search_id";
            search_id.Size = new Size(259, 31);
            search_id.TabIndex = 7;
            // 
            // FormCourseSessionList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(777, 450);
            Controls.Add(search_id);
            Controls.Add(search_title);
            Controls.Add(open_btn);
            Controls.Add(btn_load);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCourseSessionList";
            Text = "FormCourseSessionList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btn_load;
        private Button open_btn;
        private TextBox search_title;
        private TextBox search_id;
    }
}