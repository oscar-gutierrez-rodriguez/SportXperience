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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAfegirProducte = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAfegirOpcio = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxNomOpProd = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxNomProd = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkBoxOpcio = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.dataGridViewOpcions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.labelOpProd = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpcions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonAfegirProducte);
            this.panel1.Controls.Add(this.buttonAfegirOpcio);
            this.panel1.Controls.Add(this.textBoxNomOpProd);
            this.panel1.Controls.Add(this.textBoxNomProd);
            this.panel1.Controls.Add(this.checkBoxOpcio);
            this.panel1.Controls.Add(this.dataGridViewOpcions);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.labelOpProd);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 521);
            this.panel1.TabIndex = 0;
            // 
            // buttonAfegirProducte
            // 
            this.buttonAfegirProducte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAfegirProducte.BorderRadius = 10;
            this.buttonAfegirProducte.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAfegirProducte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAfegirProducte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAfegirProducte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAfegirProducte.FillColor = System.Drawing.Color.Green;
            this.buttonAfegirProducte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAfegirProducte.ForeColor = System.Drawing.Color.White;
            this.buttonAfegirProducte.Location = new System.Drawing.Point(379, 442);
            this.buttonAfegirProducte.Name = "buttonAfegirProducte";
            this.buttonAfegirProducte.Size = new System.Drawing.Size(129, 33);
            this.buttonAfegirProducte.TabIndex = 143;
            this.buttonAfegirProducte.Text = "AFEGIR PRODUCTE";
            // 
            // buttonAfegirOpcio
            // 
            this.buttonAfegirOpcio.BorderRadius = 10;
            this.buttonAfegirOpcio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAfegirOpcio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAfegirOpcio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAfegirOpcio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAfegirOpcio.Enabled = false;
            this.buttonAfegirOpcio.FillColor = System.Drawing.Color.Green;
            this.buttonAfegirOpcio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAfegirOpcio.ForeColor = System.Drawing.Color.White;
            this.buttonAfegirOpcio.Location = new System.Drawing.Point(62, 235);
            this.buttonAfegirOpcio.Name = "buttonAfegirOpcio";
            this.buttonAfegirOpcio.Size = new System.Drawing.Size(112, 33);
            this.buttonAfegirOpcio.TabIndex = 142;
            this.buttonAfegirOpcio.Text = "AFEGIR OPCIÓ";
            // 
            // textBoxNomOpProd
            // 
            this.textBoxNomOpProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNomOpProd.DefaultText = "";
            this.textBoxNomOpProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxNomOpProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxNomOpProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNomOpProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNomOpProd.Enabled = false;
            this.textBoxNomOpProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNomOpProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxNomOpProd.ForeColor = System.Drawing.Color.Black;
            this.textBoxNomOpProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNomOpProd.Location = new System.Drawing.Point(21, 193);
            this.textBoxNomOpProd.Name = "textBoxNomOpProd";
            this.textBoxNomOpProd.PlaceholderText = "";
            this.textBoxNomOpProd.SelectedText = "";
            this.textBoxNomOpProd.Size = new System.Drawing.Size(145, 36);
            this.textBoxNomOpProd.TabIndex = 136;
            // 
            // textBoxNomProd
            // 
            this.textBoxNomProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNomProd.DefaultText = "";
            this.textBoxNomProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxNomProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxNomProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNomProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxNomProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNomProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxNomProd.ForeColor = System.Drawing.Color.Black;
            this.textBoxNomProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxNomProd.Location = new System.Drawing.Point(21, 48);
            this.textBoxNomProd.Name = "textBoxNomProd";
            this.textBoxNomProd.PlaceholderText = "";
            this.textBoxNomProd.SelectedText = "";
            this.textBoxNomProd.Size = new System.Drawing.Size(145, 36);
            this.textBoxNomProd.TabIndex = 135;
            // 
            // checkBoxOpcio
            // 
            this.checkBoxOpcio.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxOpcio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxOpcio.CheckedState.BorderRadius = 2;
            this.checkBoxOpcio.CheckedState.BorderThickness = 0;
            this.checkBoxOpcio.CheckedState.FillColor = System.Drawing.Color.Green;
            this.checkBoxOpcio.Location = new System.Drawing.Point(161, 112);
            this.checkBoxOpcio.Name = "checkBoxOpcio";
            this.checkBoxOpcio.Size = new System.Drawing.Size(22, 29);
            this.checkBoxOpcio.TabIndex = 134;
            this.checkBoxOpcio.Text = "guna2CustomCheckBox1";
            this.checkBoxOpcio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxOpcio.UncheckedState.BorderRadius = 2;
            this.checkBoxOpcio.UncheckedState.BorderThickness = 0;
            this.checkBoxOpcio.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // dataGridViewOpcions
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewOpcions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOpcions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOpcions.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewOpcions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOpcions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOpcions.ColumnHeadersHeight = 20;
            this.dataGridViewOpcions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOpcions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOpcions.GridColor = System.Drawing.Color.Black;
            this.dataGridViewOpcions.Location = new System.Drawing.Point(212, 48);
            this.dataGridViewOpcions.MultiSelect = false;
            this.dataGridViewOpcions.Name = "dataGridViewOpcions";
            this.dataGridViewOpcions.ReadOnly = true;
            this.dataGridViewOpcions.RowHeadersVisible = false;
            this.dataGridViewOpcions.Size = new System.Drawing.Size(296, 289);
            this.dataGridViewOpcions.TabIndex = 28;
            this.dataGridViewOpcions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewOpcions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewOpcions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewOpcions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewOpcions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewOpcions.ThemeStyle.BackColor = System.Drawing.Color.Honeydew;
            this.dataGridViewOpcions.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dataGridViewOpcions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewOpcions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewOpcions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewOpcions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewOpcions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewOpcions.ThemeStyle.HeaderStyle.Height = 20;
            this.dataGridViewOpcions.ThemeStyle.ReadOnly = true;
            this.dataGridViewOpcions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewOpcions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewOpcions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewOpcions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewOpcions.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewOpcions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewOpcions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(18, 116);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(137, 19);
            this.materialLabel3.TabIndex = 25;
            this.materialLabel3.Text = "Opció del producte:";
            // 
            // labelOpProd
            // 
            this.labelOpProd.AutoSize = true;
            this.labelOpProd.Depth = 0;
            this.labelOpProd.Enabled = false;
            this.labelOpProd.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelOpProd.Location = new System.Drawing.Point(23, 171);
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
            // LotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 585);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LotForm";
            this.Text = "Lots";
            this.Load += new System.EventHandler(this.LotForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpcions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public MaterialSkin.Controls.MaterialLabel materialLabel3;
        public MaterialSkin.Controls.MaterialLabel labelOpProd;
        public MaterialSkin.Controls.MaterialLabel materialLabel1;
        public Guna.UI2.WinForms.Guna2DataGridView dataGridViewOpcions;
        public Guna.UI2.WinForms.Guna2CustomCheckBox checkBoxOpcio;
        public Guna.UI2.WinForms.Guna2Button buttonAfegirOpcio;
        public Guna.UI2.WinForms.Guna2Button buttonAfegirProducte;
        public Guna.UI2.WinForms.Guna2TextBox textBoxNomProd;
        public Guna.UI2.WinForms.Guna2TextBox textBoxNomOpProd;
    }
}