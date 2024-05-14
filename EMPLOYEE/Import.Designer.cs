namespace QuanLyHotel.EMPLOYEE
{
    partial class Import
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stdListDataGridView = new System.Windows.Forms.DataGridView();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.button_savetodb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stdListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stdListDataGridView
            // 
            this.stdListDataGridView.AllowUserToAddRows = false;
            this.stdListDataGridView.AllowUserToDeleteRows = false;
            this.stdListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stdListDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.stdListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.stdListDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stdListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stdListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stdListDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.stdListDataGridView.Location = new System.Drawing.Point(14, 71);
            this.stdListDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stdListDataGridView.Name = "stdListDataGridView";
            this.stdListDataGridView.ReadOnly = true;
            this.stdListDataGridView.RowHeadersWidth = 33;
            this.stdListDataGridView.RowTemplate.Height = 26;
            this.stdListDataGridView.Size = new System.Drawing.Size(1053, 474);
            this.stdListDataGridView.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(524, 28);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(114, 37);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(136, 38);
            this.txtFilename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(359, 20);
            this.txtFilename.TabIndex = 3;
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(675, 28);
            this.btnImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(147, 37);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "ImportPreview";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // button_savetodb
            // 
            this.button_savetodb.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_savetodb.Location = new System.Drawing.Point(876, 28);
            this.button_savetodb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_savetodb.Name = "button_savetodb";
            this.button_savetodb.Size = new System.Drawing.Size(147, 37);
            this.button_savetodb.TabIndex = 4;
            this.button_savetodb.Text = "SaveToDB";
            this.button_savetodb.UseVisualStyleBackColor = true;
            this.button_savetodb.Click += new System.EventHandler(this.button_savetodb_Click);
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1077, 586);
            this.Controls.Add(this.button_savetodb);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.stdListDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Import";
            this.Text = "ImportStudent";
            this.Load += new System.EventHandler(this.Import_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stdListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stdListDataGridView;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button button_savetodb;
    }
}