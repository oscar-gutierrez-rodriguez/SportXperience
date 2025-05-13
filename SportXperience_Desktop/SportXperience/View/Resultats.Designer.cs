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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridViewResultats = new Guna.UI2.WinForms.Guna2DataGridView();
            this.comboBoxNomParticipant = new Guna.UI2.WinForms.Guna2ComboBox();
            this.numericUpDownPosicio = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.buttonAfegirPosicio = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAfegirResultat = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosicio)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 98);
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
            this.materialLabel2.Location = new System.Drawing.Point(6, 226);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(138, 19);
            this.materialLabel2.TabIndex = 23;
            this.materialLabel2.Text = "Posició Participant:";
            // 
            // dataGridViewResultats
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewResultats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewResultats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResultats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResultats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewResultats.ColumnHeadersHeight = 20;
            this.dataGridViewResultats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResultats.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewResultats.GridColor = System.Drawing.Color.Black;
            this.dataGridViewResultats.Location = new System.Drawing.Point(150, 117);
            this.dataGridViewResultats.MultiSelect = false;
            this.dataGridViewResultats.Name = "dataGridViewResultats";
            this.dataGridViewResultats.ReadOnly = true;
            this.dataGridViewResultats.RowHeadersVisible = false;
            this.dataGridViewResultats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewResultats.Size = new System.Drawing.Size(302, 167);
            this.dataGridViewResultats.TabIndex = 27;
            this.dataGridViewResultats.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewResultats.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewResultats.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewResultats.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewResultats.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewResultats.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewResultats.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dataGridViewResultats.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewResultats.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewResultats.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewResultats.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewResultats.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewResultats.ThemeStyle.HeaderStyle.Height = 20;
            this.dataGridViewResultats.ThemeStyle.ReadOnly = true;
            this.dataGridViewResultats.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewResultats.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewResultats.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewResultats.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewResultats.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewResultats.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewResultats.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // comboBoxNomParticipant
            // 
            this.comboBoxNomParticipant.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxNomParticipant.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxNomParticipant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNomParticipant.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxNomParticipant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxNomParticipant.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxNomParticipant.ForeColor = System.Drawing.Color.Black;
            this.comboBoxNomParticipant.ItemHeight = 30;
            this.comboBoxNomParticipant.Location = new System.Drawing.Point(6, 117);
            this.comboBoxNomParticipant.Name = "comboBoxNomParticipant";
            this.comboBoxNomParticipant.Size = new System.Drawing.Size(132, 36);
            this.comboBoxNomParticipant.TabIndex = 28;
            // 
            // numericUpDownPosicio
            // 
            this.numericUpDownPosicio.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownPosicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownPosicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDownPosicio.Location = new System.Drawing.Point(6, 248);
            this.numericUpDownPosicio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPosicio.Name = "numericUpDownPosicio";
            this.numericUpDownPosicio.Size = new System.Drawing.Size(132, 36);
            this.numericUpDownPosicio.TabIndex = 29;
            // 
            // buttonAfegirPosicio
            // 
            this.buttonAfegirPosicio.BorderRadius = 10;
            this.buttonAfegirPosicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAfegirPosicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAfegirPosicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAfegirPosicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAfegirPosicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAfegirPosicio.ForeColor = System.Drawing.Color.White;
            this.buttonAfegirPosicio.Location = new System.Drawing.Point(69, 290);
            this.buttonAfegirPosicio.Name = "buttonAfegirPosicio";
            this.buttonAfegirPosicio.Size = new System.Drawing.Size(75, 33);
            this.buttonAfegirPosicio.TabIndex = 141;
            this.buttonAfegirPosicio.Text = "AFEGIR";
            // 
            // buttonAfegirResultat
            // 
            this.buttonAfegirResultat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAfegirResultat.BorderRadius = 10;
            this.buttonAfegirResultat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAfegirResultat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAfegirResultat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAfegirResultat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAfegirResultat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAfegirResultat.ForeColor = System.Drawing.Color.White;
            this.buttonAfegirResultat.Location = new System.Drawing.Point(333, 379);
            this.buttonAfegirResultat.Name = "buttonAfegirResultat";
            this.buttonAfegirResultat.Size = new System.Drawing.Size(119, 33);
            this.buttonAfegirResultat.TabIndex = 142;
            this.buttonAfegirResultat.Text = "AFEGIR RESULTAT";
            // 
            // Resultats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.buttonAfegirResultat);
            this.Controls.Add(this.buttonAfegirPosicio);
            this.Controls.Add(this.numericUpDownPosicio);
            this.Controls.Add(this.comboBoxNomParticipant);
            this.Controls.Add(this.dataGridViewResultats);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Resultats";
            this.Text = "Resultats";
            this.Load += new System.EventHandler(this.Resultats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialLabel materialLabel2;
        public Guna.UI2.WinForms.Guna2DataGridView dataGridViewResultats;
        public Guna.UI2.WinForms.Guna2ComboBox comboBoxNomParticipant;
        public Guna.UI2.WinForms.Guna2NumericUpDown numericUpDownPosicio;
        public Guna.UI2.WinForms.Guna2Button buttonAfegirPosicio;
        public Guna.UI2.WinForms.Guna2Button buttonAfegirResultat;
    }
}