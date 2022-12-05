namespace savannah
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
            this.start_button = new System.Windows.Forms.Button();
            this.rozmiar_combo = new System.Windows.Forms.ComboBox();
            this.typ_combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(270, 73);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(191, 64);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "START";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // rozmiar_combo
            // 
            this.rozmiar_combo.FormattingEnabled = true;
            this.rozmiar_combo.Items.AddRange(new object[] {
            "2x2",
            "3x3",
            "4x4",
            "5x5"});
            this.rozmiar_combo.Location = new System.Drawing.Point(519, 95);
            this.rozmiar_combo.Name = "rozmiar_combo";
            this.rozmiar_combo.Size = new System.Drawing.Size(195, 23);
            this.rozmiar_combo.TabIndex = 1;
            this.rozmiar_combo.Text = "ROZMIAR";
            this.rozmiar_combo.SelectedIndexChanged += new System.EventHandler(this.rozmiar_combo_SelectedIndexChanged);
            // 
            // typ_combo
            // 
            this.typ_combo.FormattingEnabled = true;
            this.typ_combo.Items.AddRange(new object[] {
            "Krokodyl",
            "Surykatka",
            "Slon",
            "Okapi"});
            this.typ_combo.Location = new System.Drawing.Point(46, 95);
            this.typ_combo.Name = "typ_combo";
            this.typ_combo.Size = new System.Drawing.Size(182, 23);
            this.typ_combo.TabIndex = 2;
            this.typ_combo.Text = "TYP";
            this.typ_combo.SelectedIndexChanged += new System.EventHandler(this.typ_combo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.typ_combo);
            this.Controls.Add(this.rozmiar_combo);
            this.Controls.Add(this.start_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button start_button;
        private ComboBox rozmiar_combo;
        private ComboBox typ_combo;
    }
}