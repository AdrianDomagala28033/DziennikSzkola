
namespace MiniDziennik.Okienka
{
    partial class DodajEdytujOkno
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
            this.imieLabel = new System.Windows.Forms.Label();
            this.rokUrodzeniaLabel = new System.Windows.Forms.Label();
            this.klasaLabel = new System.Windows.Forms.Label();
            this.nazwiskoLabel = new System.Windows.Forms.Label();
            this.imieTextBoxDE = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBoxDE = new System.Windows.Forms.TextBox();
            this.klasaComboBoxDE = new System.Windows.Forms.ComboBox();
            this.rokUrodzeniaNumericDE = new System.Windows.Forms.NumericUpDown();
            this.dodajUczniaButtonDE = new System.Windows.Forms.Button();
            this.anulujButtonDE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rokUrodzeniaNumericDE)).BeginInit();
            this.SuspendLayout();
            // 
            // imieLabel
            // 
            this.imieLabel.AutoSize = true;
            this.imieLabel.Location = new System.Drawing.Point(13, 45);
            this.imieLabel.Name = "imieLabel";
            this.imieLabel.Size = new System.Drawing.Size(33, 15);
            this.imieLabel.TabIndex = 0;
            this.imieLabel.Text = "Imię:";
            // 
            // rokUrodzeniaLabel
            // 
            this.rokUrodzeniaLabel.AutoSize = true;
            this.rokUrodzeniaLabel.Location = new System.Drawing.Point(543, 45);
            this.rokUrodzeniaLabel.Name = "rokUrodzeniaLabel";
            this.rokUrodzeniaLabel.Size = new System.Drawing.Size(82, 15);
            this.rokUrodzeniaLabel.TabIndex = 1;
            this.rokUrodzeniaLabel.Text = "Rok urodzenia";
            // 
            // klasaLabel
            // 
            this.klasaLabel.AutoSize = true;
            this.klasaLabel.Location = new System.Drawing.Point(368, 45);
            this.klasaLabel.Name = "klasaLabel";
            this.klasaLabel.Size = new System.Drawing.Size(37, 15);
            this.klasaLabel.TabIndex = 2;
            this.klasaLabel.Text = "Klasa:";
            // 
            // nazwiskoLabel
            // 
            this.nazwiskoLabel.AutoSize = true;
            this.nazwiskoLabel.Location = new System.Drawing.Point(191, 45);
            this.nazwiskoLabel.Name = "nazwiskoLabel";
            this.nazwiskoLabel.Size = new System.Drawing.Size(60, 15);
            this.nazwiskoLabel.TabIndex = 3;
            this.nazwiskoLabel.Text = "Nazwisko:";
            // 
            // imieTextBoxDE
            // 
            this.imieTextBoxDE.Location = new System.Drawing.Point(13, 73);
            this.imieTextBoxDE.Name = "imieTextBoxDE";
            this.imieTextBoxDE.Size = new System.Drawing.Size(141, 23);
            this.imieTextBoxDE.TabIndex = 4;
            // 
            // nazwiskoTextBoxDE
            // 
            this.nazwiskoTextBoxDE.Location = new System.Drawing.Point(191, 73);
            this.nazwiskoTextBoxDE.Name = "nazwiskoTextBoxDE";
            this.nazwiskoTextBoxDE.Size = new System.Drawing.Size(141, 23);
            this.nazwiskoTextBoxDE.TabIndex = 5;
            // 
            // klasaComboBoxDE
            // 
            this.klasaComboBoxDE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.klasaComboBoxDE.FormattingEnabled = true;
            this.klasaComboBoxDE.Location = new System.Drawing.Point(368, 74);
            this.klasaComboBoxDE.Name = "klasaComboBoxDE";
            this.klasaComboBoxDE.Size = new System.Drawing.Size(141, 23);
            this.klasaComboBoxDE.TabIndex = 6;
            // 
            // rokUrodzeniaNumericDE
            // 
            this.rokUrodzeniaNumericDE.Location = new System.Drawing.Point(543, 75);
            this.rokUrodzeniaNumericDE.Maximum = new decimal(new int[] {
            9000000,
            0,
            0,
            0});
            this.rokUrodzeniaNumericDE.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.rokUrodzeniaNumericDE.Name = "rokUrodzeniaNumericDE";
            this.rokUrodzeniaNumericDE.Size = new System.Drawing.Size(141, 23);
            this.rokUrodzeniaNumericDE.TabIndex = 7;
            this.rokUrodzeniaNumericDE.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // dodajUczniaButtonDE
            // 
            this.dodajUczniaButtonDE.Location = new System.Drawing.Point(121, 153);
            this.dodajUczniaButtonDE.Name = "dodajUczniaButtonDE";
            this.dodajUczniaButtonDE.Size = new System.Drawing.Size(116, 48);
            this.dodajUczniaButtonDE.TabIndex = 8;
            this.dodajUczniaButtonDE.Text = "Dodaj";
            this.dodajUczniaButtonDE.UseVisualStyleBackColor = true;
            this.dodajUczniaButtonDE.Click += new System.EventHandler(this.dodajUczniaButtonDE_Click);
            // 
            // anulujButtonDE
            // 
            this.anulujButtonDE.Location = new System.Drawing.Point(471, 151);
            this.anulujButtonDE.Name = "anulujButtonDE";
            this.anulujButtonDE.Size = new System.Drawing.Size(116, 48);
            this.anulujButtonDE.TabIndex = 9;
            this.anulujButtonDE.Text = "Anuluj";
            this.anulujButtonDE.UseVisualStyleBackColor = true;
            this.anulujButtonDE.Click += new System.EventHandler(this.anulujButtonDE_Click);
            // 
            // DodajEdytujOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 276);
            this.Controls.Add(this.anulujButtonDE);
            this.Controls.Add(this.dodajUczniaButtonDE);
            this.Controls.Add(this.rokUrodzeniaNumericDE);
            this.Controls.Add(this.klasaComboBoxDE);
            this.Controls.Add(this.nazwiskoTextBoxDE);
            this.Controls.Add(this.imieTextBoxDE);
            this.Controls.Add(this.nazwiskoLabel);
            this.Controls.Add(this.klasaLabel);
            this.Controls.Add(this.rokUrodzeniaLabel);
            this.Controls.Add(this.imieLabel);
            this.Name = "DodajEdytujOkno";
            this.Text = "DodajEdytujOkno";
            ((System.ComponentModel.ISupportInitialize)(this.rokUrodzeniaNumericDE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imieLabel;
        private System.Windows.Forms.Label rokUrodzeniaLabel;
        private System.Windows.Forms.Label klasaLabel;
        private System.Windows.Forms.Label nazwiskoLabel;
        private System.Windows.Forms.TextBox imieTextBoxDE;
        private System.Windows.Forms.TextBox nazwiskoTextBoxDE;
        private System.Windows.Forms.ComboBox klasaComboBoxDE;
        private System.Windows.Forms.NumericUpDown rokUrodzeniaNumericDE;
        private System.Windows.Forms.Button dodajUczniaButtonDE;
        private System.Windows.Forms.Button anulujButtonDE;
    }
}