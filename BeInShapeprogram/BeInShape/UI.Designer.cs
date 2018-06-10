namespace BeInShape
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.Waga_TB = new System.Windows.Forms.TextBox();
            this.Wzrost_TB = new System.Windows.Forms.TextBox();
            this.Waga_Label = new System.Windows.Forms.Label();
            this.Wzrost_Label = new System.Windows.Forms.Label();
            this.Wartosc_BMI = new System.Windows.Forms.Label();
            this.BMI_Text = new System.Windows.Forms.Label();
            this.Akt_fizyczna_CB = new System.Windows.Forms.ComboBox();
            this.Dieta_RTB = new System.Windows.Forms.RichTextBox();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.instruction = new System.Windows.Forms.Label();
            this.panel_BMI = new System.Windows.Forms.Panel();
            this.panel_RTB = new System.Windows.Forms.Panel();
            this.Akt_fizyczna_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.panel_BMI.SuspendLayout();
            this.panel_RTB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Waga_TB
            // 
            this.Waga_TB.Location = new System.Drawing.Point(49, 287);
            this.Waga_TB.Name = "Waga_TB";
            this.Waga_TB.Size = new System.Drawing.Size(100, 20);
            this.Waga_TB.TabIndex = 0;
            this.Waga_TB.TextChanged += new System.EventHandler(this.Waga_TB_TextChanged);
            // 
            // Wzrost_TB
            // 
            this.Wzrost_TB.Location = new System.Drawing.Point(49, 327);
            this.Wzrost_TB.Name = "Wzrost_TB";
            this.Wzrost_TB.Size = new System.Drawing.Size(100, 20);
            this.Wzrost_TB.TabIndex = 1;
            this.Wzrost_TB.TextChanged += new System.EventHandler(this.Wzrost_TB_TextChanged);
            // 
            // Waga_Label
            // 
            this.Waga_Label.AutoSize = true;
            this.Waga_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Waga_Label.Location = new System.Drawing.Point(48, 270);
            this.Waga_Label.Name = "Waga_Label";
            this.Waga_Label.Size = new System.Drawing.Size(71, 16);
            this.Waga_Label.TabIndex = 2;
            this.Waga_Label.Text = "Waga (kg)";
            // 
            // Wzrost_Label
            // 
            this.Wzrost_Label.AutoSize = true;
            this.Wzrost_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wzrost_Label.Location = new System.Drawing.Point(49, 309);
            this.Wzrost_Label.Name = "Wzrost_Label";
            this.Wzrost_Label.Size = new System.Drawing.Size(78, 16);
            this.Wzrost_Label.TabIndex = 3;
            this.Wzrost_Label.Text = "Wzrost (cm)";
            // 
            // Wartosc_BMI
            // 
            this.Wartosc_BMI.AutoSize = true;
            this.Wartosc_BMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wartosc_BMI.Location = new System.Drawing.Point(26, 39);
            this.Wartosc_BMI.Name = "Wartosc_BMI";
            this.Wartosc_BMI.Size = new System.Drawing.Size(37, 39);
            this.Wartosc_BMI.TabIndex = 4;
            this.Wartosc_BMI.Text = "0";
            // 
            // BMI_Text
            // 
            this.BMI_Text.AutoSize = true;
            this.BMI_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BMI_Text.Location = new System.Drawing.Point(12, 10);
            this.BMI_Text.Name = "BMI_Text";
            this.BMI_Text.Size = new System.Drawing.Size(135, 29);
            this.BMI_Text.TabIndex = 5;
            this.BMI_Text.Text = "Twoje BMI:";
            // 
            // Akt_fizyczna_CB
            // 
            this.Akt_fizyczna_CB.FormattingEnabled = true;
            this.Akt_fizyczna_CB.Items.AddRange(new object[] {
            "mała",
            "średnia",
            "duża"});
            this.Akt_fizyczna_CB.Location = new System.Drawing.Point(49, 376);
            this.Akt_fizyczna_CB.Name = "Akt_fizyczna_CB";
            this.Akt_fizyczna_CB.Size = new System.Drawing.Size(121, 21);
            this.Akt_fizyczna_CB.TabIndex = 6;
            this.Akt_fizyczna_CB.SelectedIndexChanged += new System.EventHandler(this.Akt_fizyczna_CB_SelectedIndexChanged);
            // 
            // Dieta_RTB
            // 
            this.Dieta_RTB.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Dieta_RTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dieta_RTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dieta_RTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dieta_RTB.Location = new System.Drawing.Point(15, 15);
            this.Dieta_RTB.Margin = new System.Windows.Forms.Padding(25);
            this.Dieta_RTB.Name = "Dieta_RTB";
            this.Dieta_RTB.Size = new System.Drawing.Size(250, 361);
            this.Dieta_RTB.TabIndex = 8;
            this.Dieta_RTB.Text = "";
            // 
            // logoImage
            // 
            this.logoImage.Image = ((System.Drawing.Image)(resources.GetObject("logoImage.Image")));
            this.logoImage.Location = new System.Drawing.Point(49, 31);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(265, 171);
            this.logoImage.TabIndex = 9;
            this.logoImage.TabStop = false;
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.instruction.Location = new System.Drawing.Point(47, 220);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(401, 36);
            this.instruction.TabIndex = 11;
            this.instruction.Text = "Wprowadź swoje parametry poniżej i zobacz dietę dobraną \r\nspecjalnie dla Ciebie.";
            // 
            // panel_BMI
            // 
            this.panel_BMI.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel_BMI.Controls.Add(this.BMI_Text);
            this.panel_BMI.Controls.Add(this.Wartosc_BMI);
            this.panel_BMI.Location = new System.Drawing.Point(195, 270);
            this.panel_BMI.Name = "panel_BMI";
            this.panel_BMI.Size = new System.Drawing.Size(158, 88);
            this.panel_BMI.TabIndex = 12;
            // 
            // panel_RTB
            // 
            this.panel_RTB.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel_RTB.Controls.Add(this.Dieta_RTB);
            this.panel_RTB.Location = new System.Drawing.Point(486, 31);
            this.panel_RTB.Name = "panel_RTB";
            this.panel_RTB.Padding = new System.Windows.Forms.Padding(15);
            this.panel_RTB.Size = new System.Drawing.Size(280, 391);
            this.panel_RTB.TabIndex = 13;
            // 
            // Akt_fizyczna_Label
            // 
            this.Akt_fizyczna_Label.AutoSize = true;
            this.Akt_fizyczna_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Akt_fizyczna_Label.Location = new System.Drawing.Point(47, 357);
            this.Akt_fizyczna_Label.Name = "Akt_fizyczna_Label";
            this.Akt_fizyczna_Label.Size = new System.Drawing.Size(122, 16);
            this.Akt_fizyczna_Label.TabIndex = 14;
            this.Akt_fizyczna_Label.Text = "Aktywność fizyczna";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(808, 457);
            this.Controls.Add(this.Akt_fizyczna_Label);
            this.Controls.Add(this.panel_RTB);
            this.Controls.Add(this.panel_BMI);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.logoImage);
            this.Controls.Add(this.Akt_fizyczna_CB);
            this.Controls.Add(this.Wzrost_Label);
            this.Controls.Add(this.Waga_Label);
            this.Controls.Add(this.Wzrost_TB);
            this.Controls.Add(this.Waga_TB);
            this.Name = "UI";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.panel_BMI.ResumeLayout(false);
            this.panel_BMI.PerformLayout();
            this.panel_RTB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Waga_TB;
        private System.Windows.Forms.TextBox Wzrost_TB;
        private System.Windows.Forms.Label Waga_Label;
        private System.Windows.Forms.Label Wzrost_Label;
        private System.Windows.Forms.Label Wartosc_BMI;
        private System.Windows.Forms.Label BMI_Text;
        private System.Windows.Forms.ComboBox Akt_fizyczna_CB;
        private System.Windows.Forms.RichTextBox Dieta_RTB;
        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.Panel panel_BMI;
        private System.Windows.Forms.Panel panel_RTB;
        private System.Windows.Forms.Label Akt_fizyczna_Label;
    }
}

