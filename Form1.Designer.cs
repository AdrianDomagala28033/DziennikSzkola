
namespace MiniDziennik
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
            this.filtryLabel = new System.Windows.Forms.Label();
            this.imieLabel = new System.Windows.Forms.Label();
            this.nazwiskoLabel = new System.Windows.Forms.Label();
            this.klasaLabel = new System.Windows.Forms.Label();
            this.sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            this.Rok = new System.Windows.Forms.Label();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.klasyComboBox = new System.Windows.Forms.ComboBox();
            this.dataUrodzeniaNumeric = new System.Windows.Forms.NumericUpDown();
            this.szukajButton = new System.Windows.Forms.Button();
            this.listaUczniowLabel = new System.Windows.Forms.Label();
            this.tabelaUczniowGridView = new System.Windows.Forms.DataGridView();
            this.ImieColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwiskoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KlasaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RokUrodzeniaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodajButton = new System.Windows.Forms.Button();
            this.edytujButton = new System.Windows.Forms.Button();
            this.usunButton = new System.Windows.Forms.Button();
            this.dodajKlaseButton = new System.Windows.Forms.Button();
            this.operacjeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataUrodzeniaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaUczniowGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filtryLabel
            // 
            this.filtryLabel.AutoSize = true;
            this.filtryLabel.Location = new System.Drawing.Point(13, 13);
            this.filtryLabel.Name = "filtryLabel";
            this.filtryLabel.Size = new System.Drawing.Size(33, 15);
            this.filtryLabel.TabIndex = 0;
            this.filtryLabel.Text = "Filtry";
            // 
            // imieLabel
            // 
            this.imieLabel.AutoSize = true;
            this.imieLabel.Location = new System.Drawing.Point(13, 39);
            this.imieLabel.Name = "imieLabel";
            this.imieLabel.Size = new System.Drawing.Size(30, 15);
            this.imieLabel.TabIndex = 1;
            this.imieLabel.Text = "Imię";
            // 
            // nazwiskoLabel
            // 
            this.nazwiskoLabel.AutoSize = true;
            this.nazwiskoLabel.Location = new System.Drawing.Point(154, 39);
            this.nazwiskoLabel.Name = "nazwiskoLabel";
            this.nazwiskoLabel.Size = new System.Drawing.Size(57, 15);
            this.nazwiskoLabel.TabIndex = 2;
            this.nazwiskoLabel.Text = "Nazwisko";
            // 
            // klasaLabel
            // 
            this.klasaLabel.AutoSize = true;
            this.klasaLabel.Location = new System.Drawing.Point(309, 39);
            this.klasaLabel.Name = "klasaLabel";
            this.klasaLabel.Size = new System.Drawing.Size(34, 15);
            this.klasaLabel.TabIndex = 3;
            this.klasaLabel.Text = "Klasa";
            // 
            // sqliteCommand1
            // 
            this.sqliteCommand1.CommandTimeout = 30;
            this.sqliteCommand1.Connection = null;
            this.sqliteCommand1.Transaction = null;
            this.sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // Rok
            // 
            this.Rok.AutoSize = true;
            this.Rok.Location = new System.Drawing.Point(484, 39);
            this.Rok.Name = "Rok";
            this.Rok.Size = new System.Drawing.Size(27, 15);
            this.Rok.TabIndex = 4;
            this.Rok.Text = "Rok";
            // 
            // imieTextBox
            // 
            this.imieTextBox.Location = new System.Drawing.Point(12, 60);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(100, 23);
            this.imieTextBox.TabIndex = 5;
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.Location = new System.Drawing.Point(154, 60);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(100, 23);
            this.nazwiskoTextBox.TabIndex = 6;
            // 
            // klasyComboBox
            // 
            this.klasyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.klasyComboBox.FormattingEnabled = true;
            this.klasyComboBox.Location = new System.Drawing.Point(309, 60);
            this.klasyComboBox.Name = "klasyComboBox";
            this.klasyComboBox.Size = new System.Drawing.Size(121, 23);
            this.klasyComboBox.TabIndex = 7;
            // 
            // dataUrodzeniaNumeric
            // 
            this.dataUrodzeniaNumeric.Location = new System.Drawing.Point(484, 61);
            this.dataUrodzeniaNumeric.Maximum = new decimal(new int[] {
            90000,
            0,
            0,
            0});
            this.dataUrodzeniaNumeric.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.dataUrodzeniaNumeric.Name = "dataUrodzeniaNumeric";
            this.dataUrodzeniaNumeric.Size = new System.Drawing.Size(120, 23);
            this.dataUrodzeniaNumeric.TabIndex = 8;
            this.dataUrodzeniaNumeric.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // szukajButton
            // 
            this.szukajButton.Location = new System.Drawing.Point(652, 21);
            this.szukajButton.Name = "szukajButton";
            this.szukajButton.Size = new System.Drawing.Size(136, 63);
            this.szukajButton.TabIndex = 9;
            this.szukajButton.Text = "Szukaj";
            this.szukajButton.UseVisualStyleBackColor = true;
            this.szukajButton.Click += new System.EventHandler(this.szukajButton_Click);
            // 
            // listaUczniowLabel
            // 
            this.listaUczniowLabel.AutoSize = true;
            this.listaUczniowLabel.Location = new System.Drawing.Point(13, 96);
            this.listaUczniowLabel.Name = "listaUczniowLabel";
            this.listaUczniowLabel.Size = new System.Drawing.Size(78, 15);
            this.listaUczniowLabel.TabIndex = 10;
            this.listaUczniowLabel.Text = "Lista uczniów";
            // 
            // tabelaUczniowGridView
            // 
            this.tabelaUczniowGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaUczniowGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImieColumn,
            this.NazwiskoColumn,
            this.KlasaColumn,
            this.RokUrodzeniaColumn});
            this.tabelaUczniowGridView.Location = new System.Drawing.Point(-24, 114);
            this.tabelaUczniowGridView.Name = "tabelaUczniowGridView";
            this.tabelaUczniowGridView.RowTemplate.Height = 25;
            this.tabelaUczniowGridView.Size = new System.Drawing.Size(668, 335);
            this.tabelaUczniowGridView.TabIndex = 11;
            // 
            // ImieColumn
            // 
            this.ImieColumn.DataPropertyName = "Imie";
            this.ImieColumn.HeaderText = "Imię";
            this.ImieColumn.Name = "ImieColumn";
            // 
            // NazwiskoColumn
            // 
            this.NazwiskoColumn.DataPropertyName = "Nazwisko";
            this.NazwiskoColumn.HeaderText = "Nazwisko";
            this.NazwiskoColumn.Name = "NazwiskoColumn";
            // 
            // KlasaColumn
            // 
            this.KlasaColumn.DataPropertyName = "Klasa";
            this.KlasaColumn.HeaderText = "Klasa";
            this.KlasaColumn.Name = "KlasaColumn";
            // 
            // RokUrodzeniaColumn
            // 
            this.RokUrodzeniaColumn.DataPropertyName = "RokUrodzenia";
            this.RokUrodzeniaColumn.HeaderText = "Rok urodzenia";
            this.RokUrodzeniaColumn.Name = "RokUrodzeniaColumn";
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(652, 144);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(136, 63);
            this.dodajButton.TabIndex = 12;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // edytujButton
            // 
            this.edytujButton.Location = new System.Drawing.Point(652, 213);
            this.edytujButton.Name = "edytujButton";
            this.edytujButton.Size = new System.Drawing.Size(136, 63);
            this.edytujButton.TabIndex = 13;
            this.edytujButton.Text = "Edytuj";
            this.edytujButton.UseVisualStyleBackColor = true;
            // 
            // usunButton
            // 
            this.usunButton.Location = new System.Drawing.Point(650, 282);
            this.usunButton.Name = "usunButton";
            this.usunButton.Size = new System.Drawing.Size(136, 63);
            this.usunButton.TabIndex = 14;
            this.usunButton.Text = "Usuń";
            this.usunButton.UseVisualStyleBackColor = true;
            // 
            // dodajKlaseButton
            // 
            this.dodajKlaseButton.Location = new System.Drawing.Point(650, 351);
            this.dodajKlaseButton.Name = "dodajKlaseButton";
            this.dodajKlaseButton.Size = new System.Drawing.Size(136, 63);
            this.dodajKlaseButton.TabIndex = 15;
            this.dodajKlaseButton.Text = "Dodaj klasę";
            this.dodajKlaseButton.UseVisualStyleBackColor = true;
            this.dodajKlaseButton.Click += new System.EventHandler(this.dodajKlaseButton_Click);
            // 
            // operacjeLabel
            // 
            this.operacjeLabel.AutoSize = true;
            this.operacjeLabel.Location = new System.Drawing.Point(652, 114);
            this.operacjeLabel.Name = "operacjeLabel";
            this.operacjeLabel.Size = new System.Drawing.Size(54, 15);
            this.operacjeLabel.TabIndex = 16;
            this.operacjeLabel.Text = "Operacje";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.operacjeLabel);
            this.Controls.Add(this.dodajKlaseButton);
            this.Controls.Add(this.usunButton);
            this.Controls.Add(this.edytujButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.tabelaUczniowGridView);
            this.Controls.Add(this.listaUczniowLabel);
            this.Controls.Add(this.szukajButton);
            this.Controls.Add(this.dataUrodzeniaNumeric);
            this.Controls.Add(this.klasyComboBox);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(this.imieTextBox);
            this.Controls.Add(this.Rok);
            this.Controls.Add(this.klasaLabel);
            this.Controls.Add(this.nazwiskoLabel);
            this.Controls.Add(this.imieLabel);
            this.Controls.Add(this.filtryLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataUrodzeniaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaUczniowGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filtryLabel;
        private System.Windows.Forms.Label imieLabel;
        private System.Windows.Forms.Label nazwiskoLabel;
        private System.Windows.Forms.Label klasaLabel;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private System.Windows.Forms.Label Rok;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.ComboBox klasyComboBox;
        private System.Windows.Forms.NumericUpDown dataUrodzeniaNumeric;
        private System.Windows.Forms.Button szukajButton;
        private System.Windows.Forms.Label listaUczniowLabel;
        private System.Windows.Forms.DataGridView tabelaUczniowGridView;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button edytujButton;
        private System.Windows.Forms.Button usunButton;
        private System.Windows.Forms.Button dodajKlaseButton;
        private System.Windows.Forms.Label operacjeLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImieColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwiskoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlasaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RokUrodzeniaColumn;
    }
}

