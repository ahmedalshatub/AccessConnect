namespace acconnect
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AddBT = new System.Windows.Forms.Button();
            this.deletebt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 355);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1089, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(12, 12);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(321, 24);
            this.NameBox.TabIndex = 1;
            // 
            // AddBT
            // 
            this.AddBT.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddBT.FlatAppearance.BorderSize = 0;
            this.AddBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBT.Font = new System.Drawing.Font("Ara Hamah 1964 B Bold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddBT.ForeColor = System.Drawing.Color.White;
            this.AddBT.Location = new System.Drawing.Point(12, 42);
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(321, 57);
            this.AddBT.TabIndex = 2;
            this.AddBT.Text = "أضافة";
            this.AddBT.UseVisualStyleBackColor = false;
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // deletebt
            // 
            this.deletebt.BackColor = System.Drawing.Color.DodgerBlue;
            this.deletebt.FlatAppearance.BorderSize = 0;
            this.deletebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebt.Font = new System.Drawing.Font("Ara Hamah 1964 B Bold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.deletebt.ForeColor = System.Drawing.Color.White;
            this.deletebt.Location = new System.Drawing.Point(768, 292);
            this.deletebt.Name = "deletebt";
            this.deletebt.Size = new System.Drawing.Size(321, 57);
            this.deletebt.TabIndex = 3;
            this.deletebt.Text = "حذف";
            this.deletebt.UseVisualStyleBackColor = false;
            this.deletebt.Click += new System.EventHandler(this.deletebt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 726);
            this.Controls.Add(this.deletebt);
            this.Controls.Add(this.AddBT);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button AddBT;
        private System.Windows.Forms.Button deletebt;
    }
}

