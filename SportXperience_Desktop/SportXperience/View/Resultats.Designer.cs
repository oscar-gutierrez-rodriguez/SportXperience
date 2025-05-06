namespace SportXperience.View
{
    partial class Resultats
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
            this.dataGridViewResultats = new System.Windows.Forms.DataGridView();
            this.numericUpDownPosicio = new System.Windows.Forms.NumericUpDown();
            this.buttonAfegirPosicio = new MaterialSkin.Controls.MaterialButton();
            this.buttonAfegirRsultat = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxNomParticipant = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosicio)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResultats
            // 
            this.dataGridViewResultats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewResultats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultats.Location = new System.Drawing.Point(198, 115);
            this.dataGridViewResultats.Name = "dataGridViewResultats";
            this.dataGridViewResultats.Size = new System.Drawing.Size(254, 150);
            this.dataGridViewResultats.TabIndex = 9;
            // 
            // numericUpDownPosicio
            // 
            this.numericUpDownPosicio.Location = new System.Drawing.Point(17, 248);
            this.numericUpDownPosicio.Name = "numericUpDownPosicio";
            this.numericUpDownPosicio.Size = new System.Drawing.Size(135, 20);
            this.numericUpDownPosicio.TabIndex = 18;
            // 
            // buttonAfegirPosicio
            // 
            this.buttonAfegirPosicio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAfegirPosicio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAfegirPosicio.Depth = 0;
            this.buttonAfegirPosicio.HighEmphasis = true;
            this.buttonAfegirPosicio.Icon = null;
            this.buttonAfegirPosicio.Location = new System.Drawing.Point(81, 289);
            this.buttonAfegirPosicio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAfegirPosicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAfegirPosicio.Name = "buttonAfegirPosicio";
            this.buttonAfegirPosicio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAfegirPosicio.Size = new System.Drawing.Size(71, 36);
            this.buttonAfegirPosicio.TabIndex = 19;
            this.buttonAfegirPosicio.Text = "Afegir";
            this.buttonAfegirPosicio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAfegirPosicio.UseAccentColor = false;
            this.buttonAfegirPosicio.UseVisualStyleBackColor = true;
            // 
            // buttonAfegirRsultat
            // 
            this.buttonAfegirRsultat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAfegirRsultat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAfegirRsultat.Depth = 0;
            this.buttonAfegirRsultat.HighEmphasis = true;
            this.buttonAfegirRsultat.Icon = null;
            this.buttonAfegirRsultat.Location = new System.Drawing.Point(297, 373);
            this.buttonAfegirRsultat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAfegirRsultat.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAfegirRsultat.Name = "buttonAfegirRsultat";
            this.buttonAfegirRsultat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAfegirRsultat.Size = new System.Drawing.Size(146, 36);
            this.buttonAfegirRsultat.TabIndex = 20;
            this.buttonAfegirRsultat.Text = "Afegir Resultat";
            this.buttonAfegirRsultat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAfegirRsultat.UseAccentColor = false;
            this.buttonAfegirRsultat.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(14, 97);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(120, 19);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "Nom Participant:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(14, 226);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(138, 19);
            this.materialLabel2.TabIndex = 23;
            this.materialLabel2.Text = "Posició Participant:";
            // 
            // comboBoxNomParticipant
            // 
            this.comboBoxNomParticipant.FormattingEnabled = true;
            this.comboBoxNomParticipant.Location = new System.Drawing.Point(17, 120);
            this.comboBoxNomParticipant.Name = "comboBoxNomParticipant";
            this.comboBoxNomParticipant.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNomParticipant.TabIndex = 24;
            // 
            // Resultats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.comboBoxNomParticipant);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.buttonAfegirRsultat);
            this.Controls.Add(this.buttonAfegirPosicio);
            this.Controls.Add(this.numericUpDownPosicio);
            this.Controls.Add(this.dataGridViewResultats);
            this.Name = "Resultats";
            this.Text = "Resultats";
            this.Load += new System.EventHandler(this.Resultats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridViewResultats;
        public MaterialSkin.Controls.MaterialButton buttonAfegirPosicio;
        public MaterialSkin.Controls.MaterialButton buttonAfegirRsultat;
        public MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialLabel materialLabel2;
        public System.Windows.Forms.NumericUpDown numericUpDownPosicio;
        public System.Windows.Forms.ComboBox comboBoxNomParticipant;
    }
}