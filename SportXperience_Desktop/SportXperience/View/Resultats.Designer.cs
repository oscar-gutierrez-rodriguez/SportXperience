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
            this.labelOpProd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomParticipant = new System.Windows.Forms.TextBox();
            this.buttonAfegirPosicio = new System.Windows.Forms.Button();
            this.buttonAfegirRsultat = new System.Windows.Forms.Button();
            this.dataGridViewResultats = new System.Windows.Forms.DataGridView();
            this.numericUpDownPosicio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosicio)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOpProd
            // 
            this.labelOpProd.AutoSize = true;
            this.labelOpProd.Location = new System.Drawing.Point(52, 223);
            this.labelOpProd.Name = "labelOpProd";
            this.labelOpProd.Size = new System.Drawing.Size(97, 13);
            this.labelOpProd.TabIndex = 17;
            this.labelOpProd.Text = "Posició Participant:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nom Participant:";
            // 
            // textBoxNomParticipant
            // 
            this.textBoxNomParticipant.Location = new System.Drawing.Point(55, 115);
            this.textBoxNomParticipant.Name = "textBoxNomParticipant";
            this.textBoxNomParticipant.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomParticipant.TabIndex = 13;
            // 
            // buttonAfegirPosicio
            // 
            this.buttonAfegirPosicio.Location = new System.Drawing.Point(101, 295);
            this.buttonAfegirPosicio.Name = "buttonAfegirPosicio";
            this.buttonAfegirPosicio.Size = new System.Drawing.Size(75, 23);
            this.buttonAfegirPosicio.TabIndex = 11;
            this.buttonAfegirPosicio.Text = "Afegir Posició";
            this.buttonAfegirPosicio.UseVisualStyleBackColor = true;
            // 
            // buttonAfegirRsultat
            // 
            this.buttonAfegirRsultat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAfegirRsultat.Location = new System.Drawing.Point(341, 343);
            this.buttonAfegirRsultat.Name = "buttonAfegirRsultat";
            this.buttonAfegirRsultat.Size = new System.Drawing.Size(111, 34);
            this.buttonAfegirRsultat.TabIndex = 10;
            this.buttonAfegirRsultat.Text = "Afegir Resultat";
            this.buttonAfegirRsultat.UseVisualStyleBackColor = true;
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
            this.numericUpDownPosicio.Location = new System.Drawing.Point(55, 244);
            this.numericUpDownPosicio.Name = "numericUpDownPosicio";
            this.numericUpDownPosicio.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPosicio.TabIndex = 18;
            // 
            // Resultats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.numericUpDownPosicio);
            this.Controls.Add(this.labelOpProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomParticipant);
            this.Controls.Add(this.buttonAfegirPosicio);
            this.Controls.Add(this.buttonAfegirRsultat);
            this.Controls.Add(this.dataGridViewResultats);
            this.Name = "Resultats";
            this.Text = "Resultats";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelOpProd;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxNomParticipant;
        public System.Windows.Forms.Button buttonAfegirPosicio;
        public System.Windows.Forms.Button buttonAfegirRsultat;
        public System.Windows.Forms.DataGridView dataGridViewResultats;
        private System.Windows.Forms.NumericUpDown numericUpDownPosicio;
    }
}