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
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.checkBoxOpcio = new MaterialSkin.Controls.MaterialCheckbox();
            this.labelOpProd = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxNomOpProd = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxNomProd = new MaterialSkin.Controls.MaterialTextBox();
            this.buttonAfegirProducte = new MaterialSkin.Controls.MaterialButton();
            this.buttonAfegirOpcio = new MaterialSkin.Controls.MaterialButton();
            this.dataGridViewOpcions = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpcions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.checkBoxOpcio);
            this.panel1.Controls.Add(this.labelOpProd);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.textBoxNomOpProd);
            this.panel1.Controls.Add(this.textBoxNomProd);
            this.panel1.Controls.Add(this.buttonAfegirProducte);
            this.panel1.Controls.Add(this.buttonAfegirOpcio);
            this.panel1.Controls.Add(this.dataGridViewOpcions);
            this.panel1.Location = new System.Drawing.Point(-3, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 341);
            this.panel1.TabIndex = 0;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(14, 108);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(137, 19);
            this.materialLabel3.TabIndex = 25;
            this.materialLabel3.Text = "Opció del producte:";
            // 
            // checkBoxOpcio
            // 
            this.checkBoxOpcio.AutoSize = true;
            this.checkBoxOpcio.Depth = 0;
            this.checkBoxOpcio.Location = new System.Drawing.Point(150, 97);
            this.checkBoxOpcio.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxOpcio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxOpcio.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxOpcio.Name = "checkBoxOpcio";
            this.checkBoxOpcio.ReadOnly = false;
            this.checkBoxOpcio.Ripple = true;
            this.checkBoxOpcio.Size = new System.Drawing.Size(35, 37);
            this.checkBoxOpcio.TabIndex = 24;
            this.checkBoxOpcio.UseVisualStyleBackColor = true;
            // 
            // labelOpProd
            // 
            this.labelOpProd.AutoSize = true;
            this.labelOpProd.Depth = 0;
            this.labelOpProd.Enabled = false;
            this.labelOpProd.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelOpProd.Location = new System.Drawing.Point(23, 160);
            this.labelOpProd.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelOpProd.Name = "labelOpProd";
            this.labelOpProd.Size = new System.Drawing.Size(151, 19);
            this.labelOpProd.TabIndex = 23;
            this.labelOpProd.Text = "Nom Opció Producte:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(23, 23);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(106, 19);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "Nom Producte:";
            // 
            // textBoxNomOpProd
            // 
            this.textBoxNomOpProd.AnimateReadOnly = false;
            this.textBoxNomOpProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNomOpProd.Depth = 0;
            this.textBoxNomOpProd.Enabled = false;
            this.textBoxNomOpProd.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxNomOpProd.LeadingIcon = null;
            this.textBoxNomOpProd.Location = new System.Drawing.Point(21, 182);
            this.textBoxNomOpProd.MaxLength = 50;
            this.textBoxNomOpProd.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxNomOpProd.Multiline = false;
            this.textBoxNomOpProd.Name = "textBoxNomOpProd";
            this.textBoxNomOpProd.Size = new System.Drawing.Size(145, 50);
            this.textBoxNomOpProd.TabIndex = 21;
            this.textBoxNomOpProd.Text = "";
            this.textBoxNomOpProd.TrailingIcon = null;
            // 
            // textBoxNomProd
            // 
            this.textBoxNomProd.AnimateReadOnly = false;
            this.textBoxNomProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNomProd.Depth = 0;
            this.textBoxNomProd.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxNomProd.LeadingIcon = null;
            this.textBoxNomProd.Location = new System.Drawing.Point(21, 48);
            this.textBoxNomProd.MaxLength = 50;
            this.textBoxNomProd.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxNomProd.Multiline = false;
            this.textBoxNomProd.Name = "textBoxNomProd";
            this.textBoxNomProd.Size = new System.Drawing.Size(145, 50);
            this.textBoxNomProd.TabIndex = 20;
            this.textBoxNomProd.Text = "";
            this.textBoxNomProd.TrailingIcon = null;
            // 
            // buttonAfegirProducte
            // 
            this.buttonAfegirProducte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAfegirProducte.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAfegirProducte.Depth = 0;
            this.buttonAfegirProducte.HighEmphasis = true;
            this.buttonAfegirProducte.Icon = null;
            this.buttonAfegirProducte.Location = new System.Drawing.Point(290, 282);
            this.buttonAfegirProducte.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAfegirProducte.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAfegirProducte.Name = "buttonAfegirProducte";
            this.buttonAfegirProducte.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAfegirProducte.Size = new System.Drawing.Size(150, 36);
            this.buttonAfegirProducte.TabIndex = 19;
            this.buttonAfegirProducte.Text = "Afegir Producte";
            this.buttonAfegirProducte.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAfegirProducte.UseAccentColor = false;
            this.buttonAfegirProducte.UseVisualStyleBackColor = true;
            // 
            // buttonAfegirOpcio
            // 
            this.buttonAfegirOpcio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAfegirOpcio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAfegirOpcio.Depth = 0;
            this.buttonAfegirOpcio.Enabled = false;
            this.buttonAfegirOpcio.HighEmphasis = true;
            this.buttonAfegirOpcio.Icon = null;
            this.buttonAfegirOpcio.Location = new System.Drawing.Point(16, 241);
            this.buttonAfegirOpcio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAfegirOpcio.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAfegirOpcio.Name = "buttonAfegirOpcio";
            this.buttonAfegirOpcio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAfegirOpcio.Size = new System.Drawing.Size(118, 36);
            this.buttonAfegirOpcio.TabIndex = 18;
            this.buttonAfegirOpcio.Text = "Afegir Opció";
            this.buttonAfegirOpcio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAfegirOpcio.UseAccentColor = false;
            this.buttonAfegirOpcio.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOpcions
            // 
            this.dataGridViewOpcions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOpcions.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewOpcions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOpcions.Location = new System.Drawing.Point(188, 48);
            this.dataGridViewOpcions.MultiSelect = false;
            this.dataGridViewOpcions.Name = "dataGridViewOpcions";
            this.dataGridViewOpcions.ReadOnly = true;
            this.dataGridViewOpcions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOpcions.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewOpcions.TabIndex = 17;
            this.dataGridViewOpcions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOpcions_CellContentClick);
            // 
            // LotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 398);
            this.Controls.Add(this.panel1);
            this.Name = "LotForm";
            this.Text = "LotForm";
            this.Load += new System.EventHandler(this.LotForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpcions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public MaterialSkin.Controls.MaterialLabel materialLabel3;
        public MaterialSkin.Controls.MaterialCheckbox checkBoxOpcio;
        public MaterialSkin.Controls.MaterialLabel labelOpProd;
        public MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialTextBox textBoxNomOpProd;
        public MaterialSkin.Controls.MaterialTextBox textBoxNomProd;
        public MaterialSkin.Controls.MaterialButton buttonAfegirProducte;
        public MaterialSkin.Controls.MaterialButton buttonAfegirOpcio;
        public System.Windows.Forms.DataGridView dataGridViewOpcions;
    }
}