        namespace kütüphaneOtomasyonu
        {
            partial class frmKatmanlıMimari
            {
                /// <summary>
                ///Gerekli tasarımcı değişkeni.
                /// </summary>
                private System.ComponentModel.IContainer components = null;

                /// <summary>
                ///Kullanılan tüm kaynakları temizleyin.
                /// </summary>
                ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
                protected override void Dispose(bool disposing)
                {
                    if (disposing && (components != null))
                    {
                        components.Dispose();
                    }
                    base.Dispose(disposing);
                }

                #region Windows Form Designer üretilen kod

                /// <summary>
                /// Tasarımcı desteği için gerekli metot - bu metodun 
                ///içeriğini kod düzenleyici ile değiştirmeyin.
                /// </summary>
                private void InitializeComponent()
                {
                    this.dataGridView1 = new System.Windows.Forms.DataGridView();
                    this.label1 = new System.Windows.Forms.Label();
                    this.txtAra = new System.Windows.Forms.TextBox();
                    this.PersonelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.Birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.AdıSoyadı = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.BirimID = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    this.txtPersonelID = new System.Windows.Forms.TextBox();
                    this.Personel = new System.Windows.Forms.Label();
                    this.txtAdıSoyadı = new System.Windows.Forms.TextBox();
                    this.label3 = new System.Windows.Forms.Label();
                    this.label4 = new System.Windows.Forms.Label();
                    this.label5 = new System.Windows.Forms.Label();
                    this.txtEMail = new System.Windows.Forms.TextBox();
                    this.label6 = new System.Windows.Forms.Label();
                    this.txtAdres = new System.Windows.Forms.TextBox();
                    this.label7 = new System.Windows.Forms.Label();
                    this.label8 = new System.Windows.Forms.Label();
                    this.label9 = new System.Windows.Forms.Label();
                    this.cmbBirimi = new System.Windows.Forms.ComboBox();
                    this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
                    this.checkBox1 = new System.Windows.Forms.CheckBox();
                    this.btnYeni = new System.Windows.Forms.Button();
                    this.btnKaydet = new System.Windows.Forms.Button();
                    this.btnSil = new System.Windows.Forms.Button();
                    this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
                    ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
                    this.SuspendLayout();
                    // 
                    // dataGridView1
                    // 
                    this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                    | System.Windows.Forms.AnchorStyles.Left) 
                    | System.Windows.Forms.AnchorStyles.Right)));
                    this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    this.PersonelID,
                    this.Birim,
                    this.AdıSoyadı,
                    this.Telefon,
                    this.Adress,
                    this.EMail,
                    this.Tarih,
                    this.IsActive,
                    this.BirimID});
                    this.dataGridView1.Location = new System.Drawing.Point(2, 35);
                    this.dataGridView1.Name = "dataGridView1";
                    this.dataGridView1.RowHeadersWidth = 51;
                    this.dataGridView1.RowTemplate.Height = 24;
                    this.dataGridView1.Size = new System.Drawing.Size(1465, 364);
                    this.dataGridView1.TabIndex = 0;
                    this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
                    this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
                    // 
                    // label1
                    // 
                    this.label1.AutoSize = true;
                    this.label1.Location = new System.Drawing.Point(12, 16);
                    this.label1.Name = "label1";
                    this.label1.Size = new System.Drawing.Size(87, 16);
                    this.label1.TabIndex = 1;
                    this.label1.Text = "Personel ara;";
                    // 
                    // txtAra
                    // 
                    this.txtAra.Location = new System.Drawing.Point(94, 10);
                    this.txtAra.Name = "txtAra";
                    this.txtAra.Size = new System.Drawing.Size(143, 22);
                    this.txtAra.TabIndex = 2;
                    this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
                    // 
                    // PersonelID
                    // 
                    this.PersonelID.DataPropertyName = "PersonelID";
                    this.PersonelID.HeaderText = "PersonelID";
                    this.PersonelID.MinimumWidth = 6;
                    this.PersonelID.Name = "PersonelID";
                    this.PersonelID.Visible = false;
                    // 
                    // Birim
                    // 
                    this.Birim.DataPropertyName = "BirimAdı";
                    this.Birim.HeaderText = "Birim";
                    this.Birim.MinimumWidth = 6;
                    this.Birim.Name = "Birim";
                    // 
                    // AdıSoyadı
                    // 
                    this.AdıSoyadı.DataPropertyName = "AdıSoyadı";
                    this.AdıSoyadı.HeaderText = "Adı Soyadı";
                    this.AdıSoyadı.MinimumWidth = 6;
                    this.AdıSoyadı.Name = "AdıSoyadı";
                    // 
                    // Telefon
                    // 
                    this.Telefon.DataPropertyName = "Telefon";
                    this.Telefon.HeaderText = "Telefon";
                    this.Telefon.MinimumWidth = 6;
                    this.Telefon.Name = "Telefon";
                    // 
                    // Adress
                    // 
                    this.Adress.DataPropertyName = "Adress";
                    this.Adress.HeaderText = "Adres";
                    this.Adress.MinimumWidth = 6;
                    this.Adress.Name = "Adress";
                    // 
                    // EMail
                    // 
                    this.EMail.DataPropertyName = "EMail";
                    this.EMail.HeaderText = "E Mail";
                    this.EMail.MinimumWidth = 6;
                    this.EMail.Name = "EMail";
                    // 
                    // Tarih
                    // 
                    this.Tarih.DataPropertyName = "Tarih";
                    this.Tarih.HeaderText = "Tarih";
                    this.Tarih.MinimumWidth = 6;
                    this.Tarih.Name = "Tarih";
                    // 
                    // IsActive
                    // 
                    this.IsActive.DataPropertyName = "IsActive";
                    this.IsActive.HeaderText = "Is Active";
                    this.IsActive.MinimumWidth = 6;
                    this.IsActive.Name = "IsActive";
                    this.IsActive.Visible = false;
                    // 
                    // BirimID
                    // 
                    this.BirimID.DataPropertyName = "BirimID";
                    this.BirimID.HeaderText = "BirimID";
                    this.BirimID.MinimumWidth = 6;
                    this.BirimID.Name = "BirimID";
                    this.BirimID.Visible = false;
                    // 
                    // txtPersonelID
                    // 
                    this.txtPersonelID.Location = new System.Drawing.Point(132, 445);
                    this.txtPersonelID.Name = "txtPersonelID";
                    this.txtPersonelID.Size = new System.Drawing.Size(92, 22);
                    this.txtPersonelID.TabIndex = 4;
                    // 
                    // Personel
                    // 
                    this.Personel.AutoSize = true;
                    this.Personel.Location = new System.Drawing.Point(34, 451);
                    this.Personel.Name = "Personel";
                    this.Personel.Size = new System.Drawing.Size(80, 16);
                    this.Personel.TabIndex = 3;
                    this.Personel.Text = "Personel ID:";
                    // 
                    // txtAdıSoyadı
                    // 
                    this.txtAdıSoyadı.Location = new System.Drawing.Point(132, 473);
                    this.txtAdıSoyadı.Name = "txtAdıSoyadı";
                    this.txtAdıSoyadı.Size = new System.Drawing.Size(205, 22);
                    this.txtAdıSoyadı.TabIndex = 6;
                    // 
                    // label3
                    // 
                    this.label3.AutoSize = true;
                    this.label3.Location = new System.Drawing.Point(38, 479);
                    this.label3.Name = "label3";
                    this.label3.Size = new System.Drawing.Size(76, 16);
                    this.label3.TabIndex = 5;
                    this.label3.Text = "Adı Soyadı:";
                    // 
                    // label4
                    // 
                    this.label4.AutoSize = true;
                    this.label4.Location = new System.Drawing.Point(58, 535);
                    this.label4.Name = "label4";
                    this.label4.Size = new System.Drawing.Size(56, 16);
                    this.label4.TabIndex = 9;
                    this.label4.Text = "Telefon:";
                    // 
                    // label5
                    // 
                    this.label5.AutoSize = true;
                    this.label5.Location = new System.Drawing.Point(71, 507);
                    this.label5.Name = "label5";
                    this.label5.Size = new System.Drawing.Size(43, 16);
                    this.label5.TabIndex = 7;
                    this.label5.Text = "Birimi:";
                    // 
                    // txtEMail
                    // 
                    this.txtEMail.Location = new System.Drawing.Point(132, 560);
                    this.txtEMail.Name = "txtEMail";
                    this.txtEMail.Size = new System.Drawing.Size(205, 22);
                    this.txtEMail.TabIndex = 14;
                    // 
                    // label6
                    // 
                    this.label6.AutoSize = true;
                    this.label6.Location = new System.Drawing.Point(66, 566);
                    this.label6.Name = "label6";
                    this.label6.Size = new System.Drawing.Size(48, 16);
                    this.label6.TabIndex = 13;
                    this.label6.Text = "E-Mail:";
                    // 
                    // txtAdres
                    // 
                    this.txtAdres.Location = new System.Drawing.Point(568, 463);
                    this.txtAdres.Multiline = true;
                    this.txtAdres.Name = "txtAdres";
                    this.txtAdres.Size = new System.Drawing.Size(648, 65);
                    this.txtAdres.TabIndex = 12;
                    // 
                    // label7
                    // 
                    this.label7.AutoSize = true;
                    this.label7.Location = new System.Drawing.Point(516, 466);
                    this.label7.Name = "label7";
                    this.label7.Size = new System.Drawing.Size(46, 16);
                    this.label7.TabIndex = 11;
                    this.label7.Text = "Adres:";
                    // 
                    // label8
                    // 
                    this.label8.AutoSize = true;
                    this.label8.Location = new System.Drawing.Point(65, 422);
                    this.label8.Name = "label8";
                    this.label8.Size = new System.Drawing.Size(49, 16);
                    this.label8.TabIndex = 17;
                    this.label8.Text = "Durum:";
                    // 
                    // label9
                    // 
                    this.label9.AutoSize = true;
                    this.label9.Location = new System.Drawing.Point(73, 588);
                    this.label9.Name = "label9";
                    this.label9.Size = new System.Drawing.Size(41, 16);
                    this.label9.TabIndex = 15;
                    this.label9.Text = "Tarih:";
                    // 
                    // cmbBirimi
                    // 
                    this.cmbBirimi.DisplayMember = "BirimAdı";
                    this.cmbBirimi.FormattingEnabled = true;
                    this.cmbBirimi.Location = new System.Drawing.Point(132, 499);
                    this.cmbBirimi.Name = "cmbBirimi";
                    this.cmbBirimi.Size = new System.Drawing.Size(205, 24);
                    this.cmbBirimi.TabIndex = 19;
                    this.cmbBirimi.ValueMember = "BirimID";
                    // 
                    // mtxtTelefon
                    // 
                    this.mtxtTelefon.Location = new System.Drawing.Point(132, 529);
                    this.mtxtTelefon.Mask = "(999) 000-0000";
                    this.mtxtTelefon.Name = "mtxtTelefon";
                    this.mtxtTelefon.Size = new System.Drawing.Size(205, 22);
                    this.mtxtTelefon.TabIndex = 20;
                    // 
                    // checkBox1
                    // 
                    this.checkBox1.AutoSize = true;
                    this.checkBox1.Location = new System.Drawing.Point(132, 419);
                    this.checkBox1.Name = "checkBox1";
                    this.checkBox1.Size = new System.Drawing.Size(95, 20);
                    this.checkBox1.TabIndex = 21;
                    this.checkBox1.Text = "checkBox1";
                    this.checkBox1.UseVisualStyleBackColor = true;
                    // 
                    // btnYeni
                    // 
                    this.btnYeni.Location = new System.Drawing.Point(517, 563);
                    this.btnYeni.Name = "btnYeni";
                    this.btnYeni.Size = new System.Drawing.Size(104, 44);
                    this.btnYeni.TabIndex = 22;
                    this.btnYeni.Text = "yeni";
                    this.btnYeni.UseVisualStyleBackColor = true;
                    this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
                    // 
                    // btnKaydet
                    // 
                    this.btnKaydet.Location = new System.Drawing.Point(627, 563);
                    this.btnKaydet.Name = "btnKaydet";
                    this.btnKaydet.Size = new System.Drawing.Size(105, 44);
                    this.btnKaydet.TabIndex = 23;
                    this.btnKaydet.Text = "Kaydet";
                    this.btnKaydet.UseVisualStyleBackColor = true;
                    this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
                    // 
                    // btnSil
                    // 
                    this.btnSil.Location = new System.Drawing.Point(738, 563);
                    this.btnSil.Name = "btnSil";
                    this.btnSil.Size = new System.Drawing.Size(104, 44);
                    this.btnSil.TabIndex = 24;
                    this.btnSil.Text = "Sil";
                    this.btnSil.UseVisualStyleBackColor = true;
                    this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
                    // 
                    // dateTimePicker1
                    // 
                    this.dateTimePicker1.Location = new System.Drawing.Point(132, 585);
                    this.dateTimePicker1.Name = "dateTimePicker1";
                    this.dateTimePicker1.Size = new System.Drawing.Size(205, 22);
                    this.dateTimePicker1.TabIndex = 25;
                    // 
                    // frmKatmanlıMimari
                    // 
                    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                    this.ClientSize = new System.Drawing.Size(1465, 634);
                    this.Controls.Add(this.dateTimePicker1);
                    this.Controls.Add(this.btnSil);
                    this.Controls.Add(this.btnKaydet);
                    this.Controls.Add(this.btnYeni);
                    this.Controls.Add(this.checkBox1);
                    this.Controls.Add(this.mtxtTelefon);
                    this.Controls.Add(this.cmbBirimi);
                    this.Controls.Add(this.label8);
                    this.Controls.Add(this.label9);
                    this.Controls.Add(this.txtEMail);
                    this.Controls.Add(this.label6);
                    this.Controls.Add(this.txtAdres);
                    this.Controls.Add(this.label7);
                    this.Controls.Add(this.label4);
                    this.Controls.Add(this.label5);
                    this.Controls.Add(this.txtAdıSoyadı);
                    this.Controls.Add(this.label3);
                    this.Controls.Add(this.txtPersonelID);
                    this.Controls.Add(this.Personel);
                    this.Controls.Add(this.txtAra);
                    this.Controls.Add(this.label1);
                    this.Controls.Add(this.dataGridView1);
                    this.Name = "frmKatmanlıMimari";
                    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                    this.Text = "Basit Katmanlı Mimari Projesi";
                    this.Load += new System.EventHandler(this.Form1_Load);
                    ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
                    this.ResumeLayout(false);
                    this.PerformLayout();

                }

                #endregion

                private System.Windows.Forms.DataGridView dataGridView1;
                private System.Windows.Forms.Label label1;
                private System.Windows.Forms.TextBox txtAra;
                private System.Windows.Forms.DataGridViewTextBoxColumn PersonelID;
                private System.Windows.Forms.DataGridViewTextBoxColumn Birim;
                private System.Windows.Forms.DataGridViewTextBoxColumn AdıSoyadı;
                private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
                private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
                private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
                private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
                private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
                private System.Windows.Forms.DataGridViewTextBoxColumn BirimID;
                private System.Windows.Forms.TextBox txtPersonelID;
                private System.Windows.Forms.Label Personel;
                private System.Windows.Forms.TextBox txtAdıSoyadı;
                private System.Windows.Forms.Label label3;
                private System.Windows.Forms.Label label4;
                private System.Windows.Forms.Label label5;
                private System.Windows.Forms.TextBox txtEMail;
                private System.Windows.Forms.Label label6;
                private System.Windows.Forms.TextBox txtAdres;
                private System.Windows.Forms.Label label7;
                private System.Windows.Forms.Label label8;
                private System.Windows.Forms.Label label9;
                private System.Windows.Forms.ComboBox cmbBirimi;
                private System.Windows.Forms.MaskedTextBox mtxtTelefon;
                private System.Windows.Forms.CheckBox checkBox1;
                private System.Windows.Forms.Button btnYeni;
                private System.Windows.Forms.Button btnKaydet;
                private System.Windows.Forms.Button btnSil;
                private System.Windows.Forms.DateTimePicker dateTimePicker1;
            }
        }

