namespace _460457_Irharsy_Tara_Prasetya_ResponsiJuniorProject
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
            this.logo = new System.Windows.Forms.Label();
            this.namaKaryawan = new System.Windows.Forms.Label();
            this.depKaryawan = new System.Windows.Forms.Label();
            this.idDepartemen = new System.Windows.Forms.Label();
            this.tbNamaKaryawan = new System.Windows.Forms.TextBox();
            this.cbDepKaryawan = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Location = new System.Drawing.Point(57, 25);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(27, 13);
            this.logo.TabIndex = 0;
            this.logo.Text = "logo";
            this.logo.Click += new System.EventHandler(this.label1_Click);
            // 
            // namaKaryawan
            // 
            this.namaKaryawan.AutoSize = true;
            this.namaKaryawan.Location = new System.Drawing.Point(12, 60);
            this.namaKaryawan.Name = "namaKaryawan";
            this.namaKaryawan.Size = new System.Drawing.Size(97, 13);
            this.namaKaryawan.TabIndex = 1;
            this.namaKaryawan.Text = "Nama Karyawan   :";
            // 
            // depKaryawan
            // 
            this.depKaryawan.AutoSize = true;
            this.depKaryawan.Location = new System.Drawing.Point(12, 90);
            this.depKaryawan.Name = "depKaryawan";
            this.depKaryawan.Size = new System.Drawing.Size(98, 13);
            this.depKaryawan.TabIndex = 2;
            this.depKaryawan.Text = "Dep. Karyawan     :";
            this.depKaryawan.Click += new System.EventHandler(this.depKaryawan_Click);
            // 
            // idDepartemen
            // 
            this.idDepartemen.AutoSize = true;
            this.idDepartemen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.idDepartemen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idDepartemen.Location = new System.Drawing.Point(305, 23);
            this.idDepartemen.Name = "idDepartemen";
            this.idDepartemen.Size = new System.Drawing.Size(96, 90);
            this.idDepartemen.TabIndex = 3;
            this.idDepartemen.Text = "ID Departemen\r\nHR : HR\r\nENG :Engineer\r\nDEV : Developer\r\nPM : Product M\r\nFIN : Fin" +
    "ance";
            this.idDepartemen.Click += new System.EventHandler(this.idDepartemen_Click);
            // 
            // tbNamaKaryawan
            // 
            this.tbNamaKaryawan.Location = new System.Drawing.Point(124, 60);
            this.tbNamaKaryawan.Name = "tbNamaKaryawan";
            this.tbNamaKaryawan.Size = new System.Drawing.Size(121, 20);
            this.tbNamaKaryawan.TabIndex = 4;
            this.tbNamaKaryawan.TextChanged += new System.EventHandler(this.tbNamaKaryawan_TextChanged);
            // 
            // cbDepKaryawan
            // 
            this.cbDepKaryawan.FormattingEnabled = true;
            this.cbDepKaryawan.Location = new System.Drawing.Point(124, 90);
            this.cbDepKaryawan.Name = "cbDepKaryawan";
            this.cbDepKaryawan.Size = new System.Drawing.Size(121, 21);
            this.cbDepKaryawan.TabIndex = 5;
            this.cbDepKaryawan.SelectedIndexChanged += new System.EventHandler(this.cbDepKaryawan_SelectedIndexChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(15, 136);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(170, 136);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(326, 136);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(15, 178);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(386, 136);
            this.dgv1.TabIndex = 9;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 326);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cbDepKaryawan);
            this.Controls.Add(this.tbNamaKaryawan);
            this.Controls.Add(this.idDepartemen);
            this.Controls.Add(this.depKaryawan);
            this.Controls.Add(this.namaKaryawan);
            this.Controls.Add(this.logo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label namaKaryawan;
        private System.Windows.Forms.Label depKaryawan;
        private System.Windows.Forms.Label idDepartemen;
        private System.Windows.Forms.TextBox tbNamaKaryawan;
        private System.Windows.Forms.ComboBox cbDepKaryawan;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgv1;
    }
}

