
namespace MiniDziennik.Okienka
{
    partial class UsunUcznia
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
            this.anulujButtonDE = new System.Windows.Forms.Button();
            this.usunUczniaButtonU = new System.Windows.Forms.Button();
            this.rokUrodzeniaNumericU = new System.Windows.Forms.NumericUpDown();
            this.klasaComboBoxU = new System.Windows.Forms.ComboBox();
            this.nazwiskoTextBoxU = new System.Windows.Forms.TextBox();
            this.imieTextBoxU = new System.Windows.Forms.TextBox();
            this.nazwiskoLabel = new System.Windows.Forms.Label();
            this.klasaLabel = new System.Windows.Forms.Label();
            this.rokUrodzeniaLabel = new System.Windows.Forms.Label();
            this.imieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rokUrodzeniaNumericU)).BeginInit();
            this.SuspendLayout();
            // 
            // anulujButtonDE
            // 
            this.anulujButtonDE.Location = new System.Drawing.Point(535, 182);
            this.anulujButtonDE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.anulujButtonDE.Name = "anulujButtonDE";
            this.anulujButtonDE.Size = new System.Drawing.Size(133, 64);
            this.anulujButtonDE.TabIndex = 29;
            this.anulujButtonDE.Text = "Anuluj";
            this.anulujButtonDE.UseVisualStyleBackColor = true;
            this.anulujButtonDE.Click += new System.EventHandler(this.anulujButtonDE_Click);
            // 
            // usunUczniaButtonU
            // 
            this.usunUczniaButtonU.Location = new System.Drawing.Point(135, 185);
            this.usunUczniaButtonU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usunUczniaButtonU.Name = "usunUczniaButtonU";
            this.usunUczniaButtonU.Size = new System.Drawing.Size(133, 64);
            this.usunUczniaButtonU.TabIndex = 28;
            this.usunUczniaButtonU.Text = "Usuń";
            this.usunUczniaButtonU.UseVisualStyleBackColor = true;
            this.usunUczniaButtonU.Click += new System.EventHandler(this.usunUczniaButtonU_Click);
            // 
            // rokUrodzeniaNumericU
            // 
            this.rokUrodzeniaNumericU.Location = new System.Drawing.Point(618, 81);
            this.rokUrodzeniaNumericU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rokUrodzeniaNumericU.Maximum = new decimal(new int[] {
            9000000,
            0,
            0,
            0});
            this.rokUrodzeniaNumericU.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.rokUrodzeniaNumericU.Name = "rokUrodzeniaNumericU";
            this.rokUrodzeniaNumericU.Size = new System.Drawing.Size(161, 27);
            this.rokUrodzeniaNumericU.TabIndex = 27;
            this.rokUrodzeniaNumericU.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // klasaComboBoxU
            // 
            this.klasaComboBoxU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.klasaComboBoxU.FormattingEnabled = true;
            this.klasaComboBoxU.Location = new System.Drawing.Point(418, 80);
            this.klasaComboBoxU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.klasaComboBoxU.Name = "klasaComboBoxU";
            this.klasaComboBoxU.Size = new System.Drawing.Size(161, 28);
            this.klasaComboBoxU.TabIndex = 26;
            // 
            // nazwiskoTextBoxU
            // 
            this.nazwiskoTextBoxU.Location = new System.Drawing.Point(215, 78);
            this.nazwiskoTextBoxU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nazwiskoTextBoxU.Name = "nazwiskoTextBoxU";
            this.nazwiskoTextBoxU.Size = new System.Drawing.Size(161, 27);
            this.nazwiskoTextBoxU.TabIndex = 25;
            // 
            // imieTextBoxU
            // 
            this.imieTextBoxU.Location = new System.Drawing.Point(12, 78);
            this.imieTextBoxU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imieTextBoxU.Name = "imieTextBoxU";
            this.imieTextBoxU.Size = new System.Drawing.Size(161, 27);
            this.imieTextBoxU.TabIndex = 24;
            // 
            // nazwiskoLabel
            // 
            this.nazwiskoLabel.AutoSize = true;
            this.nazwiskoLabel.Location = new System.Drawing.Point(215, 41);
            this.nazwiskoLabel.Name = "nazwiskoLabel";
            this.nazwiskoLabel.Size = new System.Drawing.Size(75, 20);
            this.nazwiskoLabel.TabIndex = 23;
            this.nazwiskoLabel.Text = "Nazwisko:";
            // 
            // klasaLabel
            // 
            this.klasaLabel.AutoSize = true;
            this.klasaLabel.Location = new System.Drawing.Point(418, 41);
            this.klasaLabel.Name = "klasaLabel";
            this.klasaLabel.Size = new System.Drawing.Size(47, 20);
            this.klasaLabel.TabIndex = 22;
            this.klasaLabel.Text = "Klasa:";
            // 
            // rokUrodzeniaLabel
            // 
            this.rokUrodzeniaLabel.AutoSize = true;
            this.rokUrodzeniaLabel.Location = new System.Drawing.Point(618, 41);
            this.rokUrodzeniaLabel.Name = "rokUrodzeniaLabel";
            this.rokUrodzeniaLabel.Size = new System.Drawing.Size(104, 20);
            this.rokUrodzeniaLabel.TabIndex = 21;
            this.rokUrodzeniaLabel.Text = "Rok urodzenia";
            // 
            // imieLabel
            // 
            this.imieLabel.AutoSize = true;
            this.imieLabel.Location = new System.Drawing.Point(12, 41);
            this.imieLabel.Name = "imieLabel";
            this.imieLabel.Size = new System.Drawing.Size(41, 20);
            this.imieLabel.TabIndex = 20;
            this.imieLabel.Text = "Imię:";
            // 
            // UsunUcznia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 281);
            this.Controls.Add(this.anulujButtonDE);
            this.Controls.Add(this.usunUczniaButtonU);
            this.Controls.Add(this.rokUrodzeniaNumericU);
            this.Controls.Add(this.klasaComboBoxU);
            this.Controls.Add(this.nazwiskoTextBoxU);
            this.Controls.Add(this.imieTextBoxU);
            this.Controls.Add(this.nazwiskoLabel);
            this.Controls.Add(this.klasaLabel);
            this.Controls.Add(this.rokUrodzeniaLabel);
            this.Controls.Add(this.imieLabel);
            this.Name = "UsunUcznia";
            this.Text = "UsunUcznia";
            ((System.ComponentModel.ISupportInitialize)(this.rokUrodzeniaNumericU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button anulujButtonDE;
        private System.Windows.Forms.Button usunUczniaButtonU;
        private System.Windows.Forms.NumericUpDown rokUrodzeniaNumericU;
        private System.Windows.Forms.ComboBox klasaComboBoxU;
        private System.Windows.Forms.TextBox nazwiskoTextBoxU;
        private System.Windows.Forms.TextBox imieTextBoxU;
        private System.Windows.Forms.Label nazwiskoLabel;
        private System.Windows.Forms.Label klasaLabel;
        private System.Windows.Forms.Label rokUrodzeniaLabel;
        private System.Windows.Forms.Label imieLabel;
    }
}