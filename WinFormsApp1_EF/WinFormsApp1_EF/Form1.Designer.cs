namespace WinFormsApp1_EF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnKayitEkle = new Button();
            dataGridView1 = new DataGridView();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtOkulNo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnKayitEkle
            // 
            btnKayitEkle.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnKayitEkle.Location = new Point(12, 99);
            btnKayitEkle.Name = "btnKayitEkle";
            btnKayitEkle.Size = new Size(181, 31);
            btnKayitEkle.TabIndex = 0;
            btnKayitEkle.Text = "Kayıt Ekle";
            btnKayitEkle.UseVisualStyleBackColor = true;
            btnKayitEkle.Click += btnKayitEkle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(199, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(488, 190);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(93, 12);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(93, 41);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 3;
            // 
            // txtOkulNo
            // 
            txtOkulNo.Location = new Point(93, 70);
            txtOkulNo.Name = "txtOkulNo";
            txtOkulNo.Size = new Size(100, 23);
            txtOkulNo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 12);
            label1.Name = "label1";
            label1.Size = new Size(42, 23);
            label1.TabIndex = 5;
            label1.Text = "Ad -";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 41);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 6;
            label2.Text = "Soyad -";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 7;
            label3.Text = "Okul No -";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 209);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOkulNo);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(dataGridView1);
            Controls.Add(btnKayitEkle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKayitEkle;
        private DataGridView dataGridView1;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtOkulNo;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}