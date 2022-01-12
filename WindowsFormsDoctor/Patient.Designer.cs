namespace WindowsFormsDoctor
{
    partial class Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.label_docname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_docicon = new System.Windows.Forms.PictureBox();
            this.buttonSelect_docworking = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.selectColumn_docdone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.photoColumn_docdone = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameColumn_docdone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleColumn_docdone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectColumn_docworking = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.photoColumn_docworking = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameColumn_docworking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleColumn_docworking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_docicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_docname
            // 
            this.label_docname.AutoSize = true;
            this.label_docname.BackColor = System.Drawing.Color.Transparent;
            this.label_docname.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_docname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(86)))));
            this.label_docname.Location = new System.Drawing.Point(115, 21);
            this.label_docname.Name = "label_docname";
            this.label_docname.Size = new System.Drawing.Size(208, 37);
            this.label_docname.TabIndex = 12;
            this.label_docname.Text = "Name Surname";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(738, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_docicon
            // 
            this.pictureBox_docicon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_docicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_docicon.Image = global::WindowsFormsDoctor.Properties.Resources.d3f913b8dd27fac04b26c2c9a903610d;
            this.pictureBox_docicon.Location = new System.Drawing.Point(12, 20);
            this.pictureBox_docicon.Name = "pictureBox_docicon";
            this.pictureBox_docicon.Size = new System.Drawing.Size(96, 79);
            this.pictureBox_docicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_docicon.TabIndex = 10;
            this.pictureBox_docicon.TabStop = false;
            // 
            // buttonSelect_docworking
            // 
            this.buttonSelect_docworking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSelect_docworking.Font = new System.Drawing.Font("Poor Richard", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelect_docworking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(86)))));
            this.buttonSelect_docworking.Location = new System.Drawing.Point(33, 389);
            this.buttonSelect_docworking.Name = "buttonSelect_docworking";
            this.buttonSelect_docworking.Size = new System.Drawing.Size(94, 42);
            this.buttonSelect_docworking.TabIndex = 9;
            this.buttonSelect_docworking.Text = "Select";
            this.buttonSelect_docworking.UseVisualStyleBackColor = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectColumn_docdone,
            this.photoColumn_docdone,
            this.nameColumn_docdone,
            this.titleColumn_docdone});
            this.dataGridView3.Location = new System.Drawing.Point(418, 130);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(345, 226);
            this.dataGridView3.TabIndex = 8;
            // 
            // selectColumn_docdone
            // 
            this.selectColumn_docdone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.selectColumn_docdone.HeaderText = "Select";
            this.selectColumn_docdone.MinimumWidth = 6;
            this.selectColumn_docdone.Name = "selectColumn_docdone";
            this.selectColumn_docdone.Width = 51;
            // 
            // photoColumn_docdone
            // 
            this.photoColumn_docdone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.photoColumn_docdone.HeaderText = "Image";
            this.photoColumn_docdone.MinimumWidth = 6;
            this.photoColumn_docdone.Name = "photoColumn_docdone";
            this.photoColumn_docdone.Width = 51;
            // 
            // nameColumn_docdone
            // 
            this.nameColumn_docdone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn_docdone.HeaderText = "Name";
            this.nameColumn_docdone.MinimumWidth = 6;
            this.nameColumn_docdone.Name = "nameColumn_docdone";
            this.nameColumn_docdone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameColumn_docdone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // titleColumn_docdone
            // 
            this.titleColumn_docdone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleColumn_docdone.HeaderText = "Title";
            this.titleColumn_docdone.MinimumWidth = 6;
            this.titleColumn_docdone.Name = "titleColumn_docdone";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectColumn_docworking,
            this.photoColumn_docworking,
            this.nameColumn_docworking,
            this.titleColumn_docworking});
            this.dataGridView1.Location = new System.Drawing.Point(34, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(324, 226);
            this.dataGridView1.TabIndex = 7;
            // 
            // selectColumn_docworking
            // 
            this.selectColumn_docworking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.selectColumn_docworking.HeaderText = "Select";
            this.selectColumn_docworking.MinimumWidth = 6;
            this.selectColumn_docworking.Name = "selectColumn_docworking";
            this.selectColumn_docworking.Width = 51;
            // 
            // photoColumn_docworking
            // 
            this.photoColumn_docworking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.photoColumn_docworking.HeaderText = "Image";
            this.photoColumn_docworking.MinimumWidth = 6;
            this.photoColumn_docworking.Name = "photoColumn_docworking";
            this.photoColumn_docworking.Width = 51;
            // 
            // nameColumn_docworking
            // 
            this.nameColumn_docworking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn_docworking.HeaderText = "Name";
            this.nameColumn_docworking.MinimumWidth = 6;
            this.nameColumn_docworking.Name = "nameColumn_docworking";
            this.nameColumn_docworking.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameColumn_docworking.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // titleColumn_docworking
            // 
            this.titleColumn_docworking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleColumn_docworking.HeaderText = "Title";
            this.titleColumn_docworking.MinimumWidth = 6;
            this.titleColumn_docworking.Name = "titleColumn_docworking";
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_docname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_docicon);
            this.Controls.Add(this.buttonSelect_docworking);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Patient";
            this.Text = "Patient";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_docicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_docname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox_docicon;
        private System.Windows.Forms.Button buttonSelect_docworking;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectColumn_docdone;
        private System.Windows.Forms.DataGridViewImageColumn photoColumn_docdone;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn_docdone;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleColumn_docdone;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectColumn_docworking;
        private System.Windows.Forms.DataGridViewImageColumn photoColumn_docworking;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn_docworking;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleColumn_docworking;
    }
}