namespace SA43Team09B_TEXT
{
    partial class Form1
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
            this.Search_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MemberID_textBox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Print_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(241, 425);
            this.Search_button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(138, 42);
            this.Search_button.TabIndex = 0;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 346);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "MemberID";
            // 
            // MemberID_textBox
            // 
            this.MemberID_textBox.Location = new System.Drawing.Point(282, 340);
            this.MemberID_textBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MemberID_textBox.Name = "MemberID_textBox";
            this.MemberID_textBox.Size = new System.Drawing.Size(180, 29);
            this.MemberID_textBox.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(64, 56);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 24);
            this.linkLabel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 244);
            this.dataGridView1.TabIndex = 4;
            // 
            // Print_button
            // 
            this.Print_button.Location = new System.Drawing.Point(45, 425);
            this.Print_button.Margin = new System.Windows.Forms.Padding(6);
            this.Print_button.Name = "Print_button";
            this.Print_button.Size = new System.Drawing.Size(138, 42);
            this.Print_button.TabIndex = 5;
            this.Print_button.Text = "Print";
            this.Print_button.UseVisualStyleBackColor = true;
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(444, 425);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(6);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(138, 42);
            this.Cancel_button.TabIndex = 6;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 550);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Print_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.MemberID_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "FindMyAllRecord";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MemberID_textBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Print_button;
        private System.Windows.Forms.Button Cancel_button;
    }
}

