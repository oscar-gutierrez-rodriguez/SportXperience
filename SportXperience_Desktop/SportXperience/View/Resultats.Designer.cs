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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAfegirResultat = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAfegirPosicio = new Guna.UI2.WinForms.Guna2Button();
            this.numericUpDownPosicio = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.comboBoxNomParticipant = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dataGridViewResultats = new Guna.UI2.WinForms.Guna2DataGridView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultats)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonAfegirResultat);
            this.panel1.Controls.Add(this.buttonAfegirPosicio);
            this.panel1.Controls.Add(this.numericUpDownPosicio);
            this.panel1.Controls.Add(this.comboBoxNomParticipant);
            this.panel1.Controls.Add(this.dataGridViewResultats);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 387);
            this.panel1.TabIndex = 0;
            // 
            // buttonAfegirResultat
            // 
            this.buttonAfegirResultat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAfegirResultat.BorderRadius = 10;
            this.buttonAfegirResultat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAfegirResultat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAfegirResultat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAfegirResultat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAfegirResultat.FillColor = System.Drawing.Color.Green;
            this.buttonAfegirResultat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAfegirResultat.ForeColor = System.Drawing.Color.White;
            this.buttonAfegirResultat.Location = new System.Drawing.Point(336, 314);
            this.buttonAfegirResultat.Name = "buttonAfegirResultat";
            this.buttonAfegirResultat.Size = new System.Drawing.Size(119, 33);
            this.buttonAfegirResultat.TabIndex = 149;
            this.buttonAfegirResultat.Text = "AFEGIR RESULTAT";
            // 
            // buttonAfegirPosicio
            // 
            this.buttonAfegirPosicio.BorderRadius = 10;
            this.buttonAfegirPosicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAfegirPosicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAfegirPosicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAfegirPosicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAfegirPosicio.FillColor = System.Drawing.Color.Green;
            this.buttonAfegirPosicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAfegirPosicio.ForeColor = System.Drawing.Color.White;
            this.buttonAfegirPosicio.Location = new System.Drawing.Point(78, 229);
            this.buttonAfegirPosicio.Name = "buttonAfegirPosicio";
            this.buttonAfegirPosicio.Size = new System.Drawing.Size(75, 33);
            this.buttonAfegirPosicio.TabIndex = 148;
            this.buttonAfegirPosicio.Text = "AFEGIR";
            // 
            // numericUpDownPosicio
            // 
            this.numericUpDownPosicio.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownPosicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownPosicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDownPosicio.Location = new System.Drawing.Point(15, 187);
            this.numericUpDownPosicio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPosicio.Name = "numericUpDownPosicio";
            this.numericUpDownPosicio.Size = new System.Drawing.Size(132, 36);
            this.numericUpDownPosicio.TabIndex = 147;
            this.numericUpDownPosicio.UpDownButtonFillColor = System.Drawing.Color.Green;
            this.numericUpDownPosicio.UpDownButtonForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.comboBoxNomParticipant.Location = new System.Drawing.Point(15, 56);
            this.comboBoxNomParticipant.Name = "comboBoxNomParticipant";
            this.comboBoxNomParticipant.Size = new System.Drawing.Size(132, 36);
            this.comboBoxNomParticipant.TabIndex = 146;
            // 
            // dataGridViewResultats
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridViewResultats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewResultats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResultats.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewResultats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResultats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewResultats.ColumnHeadersHeight = 20;
            this.dataGridViewResultats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResultats.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewResultats.GridColor = System.Drawing.Color.Black;
            this.dataGridViewResultats.Location = new System.Drawing.Point(159, 56);
            this.dataGridViewResultats.MultiSelect = false;
            this.dataGridViewResultats.Name = "dataGridViewResultats";
            this.dataGridViewResultats.ReadOnly = true;
            this.dataGridViewResultats.RowHeadersVisible = false;
            this.dataGridViewResultats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewResultats.Size = new System.Drawing.Size(296, 163);
            this.dataGridViewResultats.TabIndex = 145;
            this.dataGridViewResultats.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewResultats.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewResultats.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewResultats.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewResultats.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewResultats.ThemeStyle.BackColor = System.Drawing.Color.Honeydew;
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
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(15, 165);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(138, 19);
            this.materialLabel2.TabIndex = 144;
            this.materialLabel2.Text = "Posició Participant:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(15, 37);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(120, 19);
            this.materialLabel1.TabIndex = 143;
            this.materialLabel1.Text = "Nom Participant:";
            // 
            // Resultats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Resultats";
            this.Text = "Resultats";
            this.Load += new System.EventHandler(this.Resultats_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public Guna.UI2.WinForms.Guna2Button buttonAfegirResultat;
        public Guna.UI2.WinForms.Guna2Button buttonAfegirPosicio;
        public Guna.UI2.WinForms.Guna2NumericUpDown numericUpDownPosicio;
        public Guna.UI2.WinForms.Guna2ComboBox comboBoxNomParticipant;
        public Guna.UI2.WinForms.Guna2DataGridView dataGridViewResultats;
        public MaterialSkin.Controls.MaterialLabel materialLabel2;
        public MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}