
namespace MiniDziennik.Okienka
{
    partial class OknoDodajKlase
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
            this.nazwaKlasyLabel = new System.Windows.Forms.Label();
            this.nazwaKlasyTextBox = new System.Windows.Forms.TextBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.anulujButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nazwaKlasyLabel
            // 
            this.nazwaKlasyLabel.AutoSize = true;
            this.nazwaKlasyLabel.Location = new System.Drawing.Point(12, 65);
            this.nazwaKlasyLabel.Name = "nazwaKlasyLabel";
            this.nazwaKlasyLabel.Size = new System.Drawing.Size(74, 15);
            this.nazwaKlasyLabel.TabIndex = 0;
            this.nazwaKlasyLabel.Text = "Nazwa klasy:";
            // 
            // nazwaKlasyTextBox
            // 
            this.nazwaKlasyTextBox.Location = new System.Drawing.Point(12, 96);
            this.nazwaKlasyTextBox.Name = "nazwaKlasyTextBox";
            this.nazwaKlasyTextBox.Size = new System.Drawing.Size(591, 23);
            this.nazwaKlasyTextBox.TabIndex = 1;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(100, 143);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(121, 43);
            this.dodajButton.TabIndex = 2;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // anulujButton
            // 
            this.anulujButton.Location = new System.Drawing.Point(365, 143);
            this.anulujButton.Name = "anulujButton";
            this.anulujButton.Size = new System.Drawing.Size(121, 43);
            this.anulujButton.TabIndex = 3;
            this.anulujButton.Text = "Anuluj";
            this.anulujButton.UseVisualStyleBackColor = true;
            this.anulujButton.Click += new System.EventHandler(this.anulujButton_Click);
            // 
            // OknoDodajKlase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 259);
            this.Controls.Add(this.anulujButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.nazwaKlasyTextBox);
            this.Controls.Add(this.nazwaKlasyLabel);
            this.Name = "OknoDodajKlase";
            this.Text = "OknoDodajKlase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nazwaKlasyLabel;
        private System.Windows.Forms.TextBox nazwaKlasyTextBox;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button anulujButton;
    }
}