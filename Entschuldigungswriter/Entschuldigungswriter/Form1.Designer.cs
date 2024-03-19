namespace Entschuldigungswriter
{
    partial class FrmGenerieren
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
            tabPage2 = new TabPage();
            btnEntspeichern = new Button();
            btnZuruck1 = new Button();
            lblGeneriert = new Label();
            tabPage1 = new TabPage();
            btnLos = new Button();
            tbxGrund = new TextBox();
            btnGenerieren = new Button();
            lblTitel = new Label();
            dtpBis = new DateTimePicker();
            lblGrund = new Label();
            lblBis = new Label();
            dtpVon = new DateTimePicker();
            lblVon = new Label();
            lblZeitraum = new Label();
            tbcSGL = new TabControl();
            tabPage3 = new TabPage();
            btnSchueler = new Button();
            btnLehrer = new Button();
            lblNachname = new Label();
            lblLos = new Label();
            tbxLos = new TextBox();
            btnZuruck2 = new Button();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tbcSGL.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(64, 64, 64);
            tabPage2.Controls.Add(btnEntspeichern);
            tabPage2.Controls.Add(btnZuruck1);
            tabPage2.Controls.Add(lblGeneriert);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(586, 477);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Speichern";
            // 
            // btnEntspeichern
            // 
            btnEntspeichern.BackColor = Color.FromArgb(64, 64, 64);
            btnEntspeichern.ForeColor = Color.White;
            btnEntspeichern.Location = new Point(266, 180);
            btnEntspeichern.Name = "btnEntspeichern";
            btnEntspeichern.Size = new Size(104, 51);
            btnEntspeichern.TabIndex = 11;
            btnEntspeichern.Text = "Speichern";
            btnEntspeichern.UseVisualStyleBackColor = false;
            btnEntspeichern.Click += btnEntspeichern_Click;
            // 
            // btnZuruck1
            // 
            btnZuruck1.BackColor = Color.FromArgb(64, 64, 64);
            btnZuruck1.ForeColor = Color.White;
            btnZuruck1.Location = new Point(275, 262);
            btnZuruck1.Name = "btnZuruck1";
            btnZuruck1.Size = new Size(88, 43);
            btnZuruck1.TabIndex = 10;
            btnZuruck1.Text = "Zurück";
            btnZuruck1.UseVisualStyleBackColor = false;
            btnZuruck1.Click += btnZuruck1_Click;
            // 
            // lblGeneriert
            // 
            lblGeneriert.AutoSize = true;
            lblGeneriert.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGeneriert.ForeColor = Color.FromArgb(224, 224, 224);
            lblGeneriert.Location = new Point(6, 17);
            lblGeneriert.Name = "lblGeneriert";
            lblGeneriert.Size = new Size(58, 18);
            lblGeneriert.TabIndex = 0;
            lblGeneriert.Text = "label1";
            // 
            // tabPage1
            // 
            tabPage1.AccessibleRole = AccessibleRole.None;
            tabPage1.BackColor = Color.FromArgb(64, 64, 64);
            tabPage1.Controls.Add(btnLos);
            tabPage1.Controls.Add(tbxGrund);
            tabPage1.Controls.Add(btnGenerieren);
            tabPage1.Controls.Add(lblTitel);
            tabPage1.Controls.Add(dtpBis);
            tabPage1.Controls.Add(lblGrund);
            tabPage1.Controls.Add(lblBis);
            tabPage1.Controls.Add(dtpVon);
            tabPage1.Controls.Add(lblVon);
            tabPage1.Controls.Add(lblZeitraum);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(586, 477);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Generieren";
            // 
            // btnLos
            // 
            btnLos.BackColor = Color.FromArgb(64, 64, 64);
            btnLos.ForeColor = Color.White;
            btnLos.Location = new Point(231, 348);
            btnLos.Name = "btnLos";
            btnLos.Size = new Size(171, 23);
            btnLos.TabIndex = 10;
            btnLos.Text = "Lehrer o. Schüler editieren";
            btnLos.UseVisualStyleBackColor = false;
            btnLos.Click += btnLos_Click;
            // 
            // tbxGrund
            // 
            tbxGrund.BackColor = Color.White;
            tbxGrund.ForeColor = Color.Black;
            tbxGrund.Location = new Point(6, 190);
            tbxGrund.Multiline = true;
            tbxGrund.Name = "tbxGrund";
            tbxGrund.Size = new Size(205, 182);
            tbxGrund.TabIndex = 0;
            // 
            // btnGenerieren
            // 
            btnGenerieren.BackColor = Color.FromArgb(64, 64, 64);
            btnGenerieren.ForeColor = Color.White;
            btnGenerieren.Location = new Point(231, 274);
            btnGenerieren.Name = "btnGenerieren";
            btnGenerieren.Size = new Size(88, 43);
            btnGenerieren.TabIndex = 9;
            btnGenerieren.Text = "Generieren";
            btnGenerieren.UseVisualStyleBackColor = false;
            btnGenerieren.Click += btnGenerieren_Click;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitel.ForeColor = Color.White;
            lblTitel.Location = new Point(6, 5);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(313, 29);
            lblTitel.TabIndex = 1;
            lblTitel.Text = "Entschuldigungwriter";
            lblTitel.Click += lblTitel_Click;
            // 
            // dtpBis
            // 
            dtpBis.CalendarForeColor = Color.FromArgb(224, 224, 224);
            dtpBis.CalendarMonthBackground = Color.FromArgb(64, 64, 64);
            dtpBis.CalendarTitleBackColor = Color.Black;
            dtpBis.Checked = false;
            dtpBis.CustomFormat = " ";
            dtpBis.Format = DateTimePickerFormat.Custom;
            dtpBis.Location = new Point(164, 117);
            dtpBis.MaxDate = new DateTime(2040, 12, 31, 0, 0, 0, 0);
            dtpBis.MinDate = new DateTime(2020, 12, 31, 0, 0, 0, 0);
            dtpBis.Name = "dtpBis";
            dtpBis.Size = new Size(96, 23);
            dtpBis.TabIndex = 8;
            dtpBis.ValueChanged += dtpBis_ValueChanged;
            // 
            // lblGrund
            // 
            lblGrund.AutoSize = true;
            lblGrund.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrund.ForeColor = Color.White;
            lblGrund.Location = new Point(6, 168);
            lblGrund.Name = "lblGrund";
            lblGrund.Size = new Size(169, 19);
            lblGrund.TabIndex = 2;
            lblGrund.Text = "Grund(Optional):";
            // 
            // lblBis
            // 
            lblBis.AutoSize = true;
            lblBis.Font = new Font("Unispace", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            lblBis.ForeColor = Color.White;
            lblBis.Location = new Point(164, 95);
            lblBis.Name = "lblBis";
            lblBis.Size = new Size(39, 15);
            lblBis.TabIndex = 7;
            lblBis.Text = "Bis:";
            // 
            // dtpVon
            // 
            dtpVon.CalendarForeColor = Color.FromArgb(224, 224, 224);
            dtpVon.CalendarMonthBackground = Color.FromArgb(64, 64, 64);
            dtpVon.Checked = false;
            dtpVon.CustomFormat = " ";
            dtpVon.Format = DateTimePickerFormat.Custom;
            dtpVon.Location = new Point(6, 117);
            dtpVon.MaxDate = new DateTime(2040, 12, 31, 0, 0, 0, 0);
            dtpVon.MinDate = new DateTime(2020, 12, 31, 0, 0, 0, 0);
            dtpVon.Name = "dtpVon";
            dtpVon.Size = new Size(96, 23);
            dtpVon.TabIndex = 3;
            dtpVon.ValueChanged += dtpVon_ValueChanged;
            // 
            // lblVon
            // 
            lblVon.AutoSize = true;
            lblVon.Font = new Font("Unispace", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            lblVon.ForeColor = Color.White;
            lblVon.Location = new Point(6, 95);
            lblVon.Name = "lblVon";
            lblVon.Size = new Size(47, 15);
            lblVon.TabIndex = 6;
            lblVon.Text = "Von: ";
            // 
            // lblZeitraum
            // 
            lblZeitraum.AutoSize = true;
            lblZeitraum.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lblZeitraum.ForeColor = Color.White;
            lblZeitraum.Location = new Point(3, 54);
            lblZeitraum.Name = "lblZeitraum";
            lblZeitraum.Size = new Size(99, 19);
            lblZeitraum.TabIndex = 5;
            lblZeitraum.Text = "Zeitraum:";
            // 
            // tbcSGL
            // 
            tbcSGL.Controls.Add(tabPage1);
            tbcSGL.Controls.Add(tabPage2);
            tbcSGL.Controls.Add(tabPage3);
            tbcSGL.ImeMode = ImeMode.NoControl;
            tbcSGL.Location = new Point(-5, 12);
            tbcSGL.Name = "tbcSGL";
            tbcSGL.SelectedIndex = 0;
            tbcSGL.Size = new Size(594, 505);
            tbcSGL.TabIndex = 10;
            tbcSGL.SelectedIndexChanged += tbcSGL_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(64, 64, 64);
            tabPage3.Controls.Add(btnSchueler);
            tabPage3.Controls.Add(btnLehrer);
            tabPage3.Controls.Add(lblNachname);
            tabPage3.Controls.Add(lblLos);
            tabPage3.Controls.Add(tbxLos);
            tabPage3.Controls.Add(btnZuruck2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(586, 477);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Lehrer u. Schüler";
            // 
            // btnSchueler
            // 
            btnSchueler.BackColor = Color.FromArgb(64, 64, 64);
            btnSchueler.ForeColor = Color.White;
            btnSchueler.Location = new Point(184, 134);
            btnSchueler.Name = "btnSchueler";
            btnSchueler.Size = new Size(88, 43);
            btnSchueler.TabIndex = 16;
            btnSchueler.Text = "Schüler Speichern";
            btnSchueler.UseVisualStyleBackColor = false;
            btnSchueler.Click += btnSchueler_Click;
            // 
            // btnLehrer
            // 
            btnLehrer.BackColor = Color.FromArgb(64, 64, 64);
            btnLehrer.ForeColor = Color.White;
            btnLehrer.Location = new Point(13, 134);
            btnLehrer.Name = "btnLehrer";
            btnLehrer.Size = new Size(88, 43);
            btnLehrer.TabIndex = 15;
            btnLehrer.Text = "Lehrer Speichern";
            btnLehrer.UseVisualStyleBackColor = false;
            btnLehrer.Click += btnLehrer_Click;
            // 
            // lblNachname
            // 
            lblNachname.AutoSize = true;
            lblNachname.Font = new Font("Unispace", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNachname.ForeColor = Color.White;
            lblNachname.Location = new Point(13, 51);
            lblNachname.Name = "lblNachname";
            lblNachname.Size = new Size(182, 14);
            lblNachname.TabIndex = 14;
            lblNachname.Text = "(Bei Lehrer nur Nachname)";
            // 
            // lblLos
            // 
            lblLos.AutoSize = true;
            lblLos.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lblLos.ForeColor = Color.White;
            lblLos.Location = new Point(13, 32);
            lblLos.Name = "lblLos";
            lblLos.Size = new Size(259, 19);
            lblLos.TabIndex = 13;
            lblLos.Text = "Schüler oder Lehrer Name:";
            // 
            // tbxLos
            // 
            tbxLos.Location = new Point(13, 84);
            tbxLos.Name = "tbxLos";
            tbxLos.Size = new Size(259, 23);
            tbxLos.TabIndex = 12;
            // 
            // btnZuruck2
            // 
            btnZuruck2.BackColor = Color.FromArgb(64, 64, 64);
            btnZuruck2.ForeColor = Color.White;
            btnZuruck2.Location = new Point(275, 262);
            btnZuruck2.Name = "btnZuruck2";
            btnZuruck2.Size = new Size(88, 43);
            btnZuruck2.TabIndex = 11;
            btnZuruck2.Text = "Zurück";
            btnZuruck2.UseVisualStyleBackColor = false;
            btnZuruck2.Click += btnZuruck2_Click;
            // 
            // FrmGenerieren
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(582, 514);
            Controls.Add(tbcSGL);
            Name = "FrmGenerieren";
            Text = "Entschuldigung Generieren";
            Load += FrmGenerieren_Load;
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tbcSGL.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private Label lblGeneriert;
        private TabPage tabPage1;
        private TextBox tbxGrund;
        private Button btnGenerieren;
        private Label lblTitel;
        private DateTimePicker dtpBis;
        private Label lblGrund;
        private Label lblBis;
        private DateTimePicker dtpVon;
        private Label lblVon;
        private Label lblZeitraum;
        private TabControl tbcSGL;
        private TabPage tabPage3;
        private Button btnLos;
        private Button btnZuruck1;
        private Button btnZuruck2;
        private Button btnEntspeichern;
        private TextBox tbxLos;
        private Button btnSchueler;
        private Button btnLehrer;
        private Label lblNachname;
        private Label lblLos;
    }
}