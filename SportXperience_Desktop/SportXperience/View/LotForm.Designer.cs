namespace SportXperience.View
{
    partial class LotForm
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
            this.dataGridViewOpcions = new System.Windows.Forms.DataGridView();
            this.buttonAfegirProducte = new System.Windows.Forms.Button();
            this.buttonAfegirOpcio = new System.Windows.Forms.Button();
            this.textBoxNomOpProd = new System.Windows.Forms.TextBox();
            this.textBoxNomProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxOpcio = new System.Windows.Forms.CheckBox();
            this.labelOpProd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpcions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOpcions
            // 
            this.dataGridViewOpcions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOpcions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOpcions.Location = new System.Drawing.Point(179, 113);
            this.dataGridViewOpcions.Name = "dataGridViewOpcions";
            this.dataGridViewOpcions.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewOpcions.TabIndex = 0;
            // 
            // buttonAfegirProducte
            // 
            this.buttonAfegirProducte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAfegirProducte.Location = new System.Drawing.Point(308, 341);
            this.buttonAfegirProducte.Name = "buttonAfegirProducte";
            this.buttonAfegirProducte.Size = new System.Drawing.Size(111, 34);
            this.buttonAfegirProducte.TabIndex = 1;
            this.buttonAfegirProducte.Text = "Afegir Producte";
            this.buttonAfegirProducte.UseVisualStyleBackColor = true;
            // 
            // buttonAfegirOpcio
            // 
            this.buttonAfegirOpcio.Enabled = false;
            this.buttonAfegirOpcio.Location = new System.Drawing.Point(82, 293);
            this.buttonAfegirOpcio.Name = "buttonAfegirOpcio";
            this.buttonAfegirOpcio.Size = new System.Drawing.Size(75, 23);
            this.buttonAfegirOpcio.TabIndex = 2;
            this.buttonAfegirOpcio.Text = "Afegir opció";
            this.buttonAfegirOpcio.UseVisualStyleBackColor = true;
            // 
            // textBoxNomOpProd
            // 
            this.textBoxNomOpProd.Enabled = false;
            this.textBoxNomOpProd.Location = new System.Drawing.Point(36, 247);
            this.textBoxNomOpProd.Name = "textBoxNomOpProd";
            this.textBoxNomOpProd.Size = new System.Drawing.Size(121, 20);
            this.textBoxNomOpProd.TabIndex = 3;
            // 
            // textBoxNomProd
            // 
            this.textBoxNomProd.Location = new System.Drawing.Point(36, 113);
            this.textBoxNomProd.Name = "textBoxNomProd";
            this.textBoxNomProd.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomProd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom Producte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Opció del producte: ";
            // 
            // checkBoxOpcio
            // 
            this.checkBoxOpcio.AutoSize = true;
            this.checkBoxOpcio.Location = new System.Drawing.Point(142, 175);
            this.checkBoxOpcio.Name = "checkBoxOpcio";
            this.checkBoxOpcio.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOpcio.TabIndex = 7;
            this.checkBoxOpcio.UseVisualStyleBackColor = true;
            this.checkBoxOpcio.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelOpProd
            // 
            this.labelOpProd.AutoSize = true;
            this.labelOpProd.Enabled = false;
            this.labelOpProd.Location = new System.Drawing.Point(33, 221);
            this.labelOpProd.Name = "labelOpProd";
            this.labelOpProd.Size = new System.Drawing.Size(109, 13);
            this.labelOpProd.TabIndex = 8;
            this.labelOpProd.Text = "Nom Opció Producte:";
            // 
            // LotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 398);
            this.Controls.Add(this.labelOpProd);
            this.Controls.Add(this.checkBoxOpcio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomProd);
            this.Controls.Add(this.textBoxNomOpProd);
            this.Controls.Add(this.buttonAfegirOpcio);
            this.Controls.Add(this.buttonAfegirProducte);
            this.Controls.Add(this.dataGridViewOpcions);
            this.Name = "LotForm";
            this.Text = "LotForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpcions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonAfegirProducte;
        public System.Windows.Forms.Button buttonAfegirOpcio;
        public System.Windows.Forms.TextBox textBoxNomOpProd;
        public System.Windows.Forms.TextBox textBoxNomProd;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox checkBoxOpcio;
        public System.Windows.Forms.Label labelOpProd;
        public System.Windows.Forms.DataGridView dataGridViewOpcions;
    }
}