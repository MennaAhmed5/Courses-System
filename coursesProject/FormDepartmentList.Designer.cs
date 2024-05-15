namespace coursesProject
{
    partial class FormDepartmentList
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
            search_name = new TextBox();
            search_Location = new TextBox();
            dataGridView1 = new DataGridView();
            load_btn = new Button();
            open_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 16);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 19);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 1;
            label2.Text = "Location";
            // 
            // search_name
            // 
            search_name.Location = new Point(96, 16);
            search_name.Name = "search_name";
            search_name.Size = new Size(227, 31);
            search_name.TabIndex = 2;
            search_name.Text = " ";
            // 
            // search_Location
            // 
            search_Location.Location = new Point(488, 16);
            search_Location.Name = "search_Location";
            search_Location.Size = new Size(230, 31);
            search_Location.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(702, 290);
            dataGridView1.TabIndex = 4;
            // 
            // load_btn
            // 
            load_btn.Location = new Point(68, 381);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(112, 34);
            load_btn.TabIndex = 5;
            load_btn.Text = "Load";
            load_btn.UseVisualStyleBackColor = true;
            load_btn.Click += load_btn_Click;
            // 
            // open_btn
            // 
            open_btn.Location = new Point(571, 381);
            open_btn.Name = "open_btn";
            open_btn.Size = new Size(112, 34);
            open_btn.TabIndex = 6;
            open_btn.Text = "Open ";
            open_btn.UseVisualStyleBackColor = true;
            open_btn.Click += open_btn_Click;
            // 
            // FormDepartmentList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(open_btn);
            Controls.Add(load_btn);
            Controls.Add(dataGridView1);
            Controls.Add(search_Location);
            Controls.Add(search_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDepartmentList";
            Text = "FormDepartmentList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox search_name;
        private TextBox search_Location;
        private DataGridView dataGridView1;
        private Button load_btn;
        private Button open_btn;
    }
}