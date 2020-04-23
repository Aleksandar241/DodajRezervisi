namespace DodajRezervisi
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFormular = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtMesta = new System.Windows.Forms.TextBox();
            this.lbMesta = new System.Windows.Forms.Label();
            this.btZavrsi = new System.Windows.Forms.Button();
            this.cbHrana = new System.Windows.Forms.CheckBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.cbPet = new System.Windows.Forms.CheckBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lbKontakt = new System.Windows.Forms.Label();
            this.lbAdresa = new System.Windows.Forms.Label();
            this.lbNaziv = new System.Windows.Forms.Label();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.lbIme = new System.Windows.Forms.Label();
            this.gbRezerva = new System.Windows.Forms.GroupBox();
            this.cbIzbor = new System.Windows.Forms.ComboBox();
            this.bR = new System.Windows.Forms.Button();
            this.lbMusKont = new System.Windows.Forms.Label();
            this.tMkont = new System.Windows.Forms.TextBox();
            this.tJMBG = new System.Windows.Forms.TextBox();
            this.JMBG = new System.Windows.Forms.Label();
            this.lbMuspime = new System.Windows.Forms.Label();
            this.lbMusime = new System.Windows.Forms.Label();
            this.tMpre = new System.Windows.Forms.TextBox();
            this.tMime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbFormular.SuspendLayout();
            this.gbRezerva.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.Location = new System.Drawing.Point(30, 390);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(951, 141);
            this.dataGridView1.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tip";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Hrana";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Pet friendly";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Broj Mesta";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Menadzer/Kontakt";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 180;
            // 
            // gbFormular
            // 
            this.gbFormular.BackColor = System.Drawing.Color.Snow;
            this.gbFormular.Controls.Add(this.comboBox1);
            this.gbFormular.Controls.Add(this.txtMesta);
            this.gbFormular.Controls.Add(this.lbMesta);
            this.gbFormular.Controls.Add(this.btZavrsi);
            this.gbFormular.Controls.Add(this.cbHrana);
            this.gbFormular.Controls.Add(this.txtKontakt);
            this.gbFormular.Controls.Add(this.cbPet);
            this.gbFormular.Controls.Add(this.txtAdresa);
            this.gbFormular.Controls.Add(this.txtNaziv);
            this.gbFormular.Controls.Add(this.txtPrezime);
            this.gbFormular.Controls.Add(this.txtIme);
            this.gbFormular.Controls.Add(this.lbKontakt);
            this.gbFormular.Controls.Add(this.lbAdresa);
            this.gbFormular.Controls.Add(this.lbNaziv);
            this.gbFormular.Controls.Add(this.lbPrezime);
            this.gbFormular.Controls.Add(this.lbIme);
            this.gbFormular.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFormular.Location = new System.Drawing.Point(102, 12);
            this.gbFormular.Name = "gbFormular";
            this.gbFormular.Size = new System.Drawing.Size(356, 372);
            this.gbFormular.TabIndex = 32;
            this.gbFormular.TabStop = false;
            this.gbFormular.Text = "Dodaj objekat:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nepoznato",
            "Kafana",
            "Kafic",
            "Diskoteka",
            "Restoran"});
            this.comboBox1.Location = new System.Drawing.Point(6, 286);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Text = "Tip objekta";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtMesta
            // 
            this.txtMesta.Location = new System.Drawing.Point(115, 203);
            this.txtMesta.Name = "txtMesta";
            this.txtMesta.Size = new System.Drawing.Size(217, 28);
            this.txtMesta.TabIndex = 14;
            // 
            // lbMesta
            // 
            this.lbMesta.AutoSize = true;
            this.lbMesta.Location = new System.Drawing.Point(6, 206);
            this.lbMesta.Name = "lbMesta";
            this.lbMesta.Size = new System.Drawing.Size(94, 21);
            this.lbMesta.TabIndex = 13;
            this.lbMesta.Text = "Broj mesta:";
            // 
            // btZavrsi
            // 
            this.btZavrsi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btZavrsi.Location = new System.Drawing.Point(202, 286);
            this.btZavrsi.Name = "btZavrsi";
            this.btZavrsi.Size = new System.Drawing.Size(130, 61);
            this.btZavrsi.TabIndex = 12;
            this.btZavrsi.Text = "Kreiraj nalog";
            this.btZavrsi.UseVisualStyleBackColor = false;
            this.btZavrsi.Click += new System.EventHandler(this.btZavrsi_Click);
            // 
            // cbHrana
            // 
            this.cbHrana.AutoSize = true;
            this.cbHrana.Location = new System.Drawing.Point(175, 250);
            this.cbHrana.Name = "cbHrana";
            this.cbHrana.Size = new System.Drawing.Size(76, 25);
            this.cbHrana.TabIndex = 10;
            this.cbHrana.Text = "Hrana";
            this.cbHrana.UseVisualStyleBackColor = true;
            this.cbHrana.CheckedChanged += new System.EventHandler(this.cbHrana_CheckedChanged);
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(115, 167);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(217, 28);
            this.txtKontakt.TabIndex = 9;
            // 
            // cbPet
            // 
            this.cbPet.AutoSize = true;
            this.cbPet.Location = new System.Drawing.Point(22, 250);
            this.cbPet.Name = "cbPet";
            this.cbPet.Size = new System.Drawing.Size(117, 25);
            this.cbPet.TabIndex = 11;
            this.cbPet.Text = "Pet friendly";
            this.cbPet.UseVisualStyleBackColor = true;
            this.cbPet.CheckedChanged += new System.EventHandler(this.cbPet_CheckedChanged);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(115, 133);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(217, 28);
            this.txtAdresa.TabIndex = 8;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(115, 99);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(217, 28);
            this.txtNaziv.TabIndex = 7;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(115, 61);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(217, 28);
            this.txtPrezime.TabIndex = 6;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(115, 27);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(217, 28);
            this.txtIme.TabIndex = 5;
            // 
            // lbKontakt
            // 
            this.lbKontakt.AutoSize = true;
            this.lbKontakt.Location = new System.Drawing.Point(6, 167);
            this.lbKontakt.Name = "lbKontakt";
            this.lbKontakt.Size = new System.Drawing.Size(73, 21);
            this.lbKontakt.TabIndex = 4;
            this.lbKontakt.Text = "Kontakt:";
            // 
            // lbAdresa
            // 
            this.lbAdresa.AutoSize = true;
            this.lbAdresa.Location = new System.Drawing.Point(6, 133);
            this.lbAdresa.Name = "lbAdresa";
            this.lbAdresa.Size = new System.Drawing.Size(67, 21);
            this.lbAdresa.TabIndex = 3;
            this.lbAdresa.Text = "Adresa:";
            // 
            // lbNaziv
            // 
            this.lbNaziv.AutoSize = true;
            this.lbNaziv.Location = new System.Drawing.Point(8, 102);
            this.lbNaziv.Name = "lbNaziv";
            this.lbNaziv.Size = new System.Drawing.Size(101, 21);
            this.lbNaziv.TabIndex = 2;
            this.lbNaziv.Text = "Ime objekta:";
            // 
            // lbPrezime
            // 
            this.lbPrezime.AutoSize = true;
            this.lbPrezime.Location = new System.Drawing.Point(6, 61);
            this.lbPrezime.Name = "lbPrezime";
            this.lbPrezime.Size = new System.Drawing.Size(73, 21);
            this.lbPrezime.TabIndex = 1;
            this.lbPrezime.Text = "Prezime:";
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(6, 27);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(42, 21);
            this.lbIme.TabIndex = 0;
            this.lbIme.Text = "Ime:";
            // 
            // gbRezerva
            // 
            this.gbRezerva.BackColor = System.Drawing.Color.Snow;
            this.gbRezerva.Controls.Add(this.cbIzbor);
            this.gbRezerva.Controls.Add(this.bR);
            this.gbRezerva.Controls.Add(this.lbMusKont);
            this.gbRezerva.Controls.Add(this.tMkont);
            this.gbRezerva.Controls.Add(this.tJMBG);
            this.gbRezerva.Controls.Add(this.JMBG);
            this.gbRezerva.Controls.Add(this.lbMuspime);
            this.gbRezerva.Controls.Add(this.lbMusime);
            this.gbRezerva.Controls.Add(this.tMpre);
            this.gbRezerva.Controls.Add(this.tMime);
            this.gbRezerva.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRezerva.Location = new System.Drawing.Point(523, 12);
            this.gbRezerva.Name = "gbRezerva";
            this.gbRezerva.Size = new System.Drawing.Size(356, 372);
            this.gbRezerva.TabIndex = 31;
            this.gbRezerva.TabStop = false;
            this.gbRezerva.Text = "Rezervacija";
            // 
            // cbIzbor
            // 
            this.cbIzbor.FormattingEnabled = true;
            this.cbIzbor.Location = new System.Drawing.Point(10, 286);
            this.cbIzbor.Name = "cbIzbor";
            this.cbIzbor.Size = new System.Drawing.Size(138, 28);
            this.cbIzbor.TabIndex = 22;
            this.cbIzbor.Text = "Izaberi objekat";
            // 
            // bR
            // 
            this.bR.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bR.Location = new System.Drawing.Point(209, 286);
            this.bR.Name = "bR";
            this.bR.Size = new System.Drawing.Size(113, 61);
            this.bR.TabIndex = 21;
            this.bR.Text = "Rezervisi";
            this.bR.UseVisualStyleBackColor = false;
            this.bR.Click += new System.EventHandler(this.bR_Click);
            // 
            // lbMusKont
            // 
            this.lbMusKont.AutoSize = true;
            this.lbMusKont.Location = new System.Drawing.Point(6, 192);
            this.lbMusKont.Name = "lbMusKont";
            this.lbMusKont.Size = new System.Drawing.Size(73, 21);
            this.lbMusKont.TabIndex = 16;
            this.lbMusKont.Text = "Kontakt:";
            // 
            // tMkont
            // 
            this.tMkont.Location = new System.Drawing.Point(105, 189);
            this.tMkont.Name = "tMkont";
            this.tMkont.Size = new System.Drawing.Size(217, 28);
            this.tMkont.TabIndex = 20;
            // 
            // tJMBG
            // 
            this.tJMBG.Location = new System.Drawing.Point(105, 140);
            this.tJMBG.Name = "tJMBG";
            this.tJMBG.Size = new System.Drawing.Size(217, 28);
            this.tJMBG.TabIndex = 19;
            // 
            // JMBG
            // 
            this.JMBG.AutoSize = true;
            this.JMBG.Location = new System.Drawing.Point(6, 140);
            this.JMBG.Name = "JMBG";
            this.JMBG.Size = new System.Drawing.Size(59, 21);
            this.JMBG.TabIndex = 18;
            this.JMBG.Text = "JMBG";
            // 
            // lbMuspime
            // 
            this.lbMuspime.AutoSize = true;
            this.lbMuspime.Location = new System.Drawing.Point(6, 95);
            this.lbMuspime.Name = "lbMuspime";
            this.lbMuspime.Size = new System.Drawing.Size(73, 21);
            this.lbMuspime.TabIndex = 16;
            this.lbMuspime.Text = "Prezime:";
            // 
            // lbMusime
            // 
            this.lbMusime.AutoSize = true;
            this.lbMusime.Location = new System.Drawing.Point(6, 46);
            this.lbMusime.Name = "lbMusime";
            this.lbMusime.Size = new System.Drawing.Size(42, 21);
            this.lbMusime.TabIndex = 17;
            this.lbMusime.Text = "Ime:";
            // 
            // tMpre
            // 
            this.tMpre.Location = new System.Drawing.Point(105, 88);
            this.tMpre.Name = "tMpre";
            this.tMpre.Size = new System.Drawing.Size(217, 28);
            this.tMpre.TabIndex = 16;
            // 
            // tMime
            // 
            this.tMime.Location = new System.Drawing.Point(105, 39);
            this.tMime.Name = "tMime";
            this.tMime.Size = new System.Drawing.Size(217, 28);
            this.tMime.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 587);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbFormular);
            this.Controls.Add(this.gbRezerva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Dodaj i Rezervisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbFormular.ResumeLayout(false);
            this.gbFormular.PerformLayout();
            this.gbRezerva.ResumeLayout(false);
            this.gbRezerva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox gbFormular;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtMesta;
        private System.Windows.Forms.Label lbMesta;
        private System.Windows.Forms.Button btZavrsi;
        private System.Windows.Forms.CheckBox cbHrana;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.CheckBox cbPet;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lbKontakt;
        private System.Windows.Forms.Label lbAdresa;
        private System.Windows.Forms.Label lbNaziv;
        private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.GroupBox gbRezerva;
        private System.Windows.Forms.ComboBox cbIzbor;
        private System.Windows.Forms.Button bR;
        private System.Windows.Forms.Label lbMusKont;
        private System.Windows.Forms.TextBox tMkont;
        private System.Windows.Forms.TextBox tJMBG;
        private System.Windows.Forms.Label JMBG;
        private System.Windows.Forms.Label lbMuspime;
        private System.Windows.Forms.Label lbMusime;
        private System.Windows.Forms.TextBox tMpre;
        private System.Windows.Forms.TextBox tMime;
    }
}

