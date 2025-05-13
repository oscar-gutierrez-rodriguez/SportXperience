namespace SportXperience.View
{
    partial class UbicacioForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gMapControlUbi = new GMap.NET.WindowsForms.GMapControl();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridViewUbicacions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TextBoxLatitud = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxLongitud = new Guna.UI2.WinForms.Guna2TextBox();
            this.materialButtonSat = new Guna.UI2.WinForms.Guna2Button();
            this.materialButtonOrg = new Guna.UI2.WinForms.Guna2Button();
            this.materialButtonAfegirUbi = new Guna.UI2.WinForms.Guna2Button();
            this.materialButtonConfirmarUbi = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUbicacions)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControlUbi
            // 
            this.gMapControlUbi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControlUbi.Bearing = 0F;
            this.gMapControlUbi.CanDragMap = true;
            this.gMapControlUbi.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControlUbi.GrayScaleMode = false;
            this.gMapControlUbi.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControlUbi.LevelsKeepInMemory = 5;
            this.gMapControlUbi.Location = new System.Drawing.Point(16, 98);
            this.gMapControlUbi.MarkersEnabled = true;
            this.gMapControlUbi.MaxZoom = 2;
            this.gMapControlUbi.MinZoom = 2;
            this.gMapControlUbi.MouseWheelZoomEnabled = true;
            this.gMapControlUbi.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControlUbi.Name = "gMapControlUbi";
            this.gMapControlUbi.NegativeMode = false;
            this.gMapControlUbi.PolygonsEnabled = true;
            this.gMapControlUbi.RetryLoadTile = 0;
            this.gMapControlUbi.RoutesEnabled = true;
            this.gMapControlUbi.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControlUbi.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControlUbi.ShowTileGridLines = false;
            this.gMapControlUbi.Size = new System.Drawing.Size(613, 356);
            this.gMapControlUbi.TabIndex = 25;
            this.gMapControlUbi.Zoom = 0D;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(660, 186);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 19);
            this.materialLabel2.TabIndex = 23;
            this.materialLabel2.Text = "Longitud:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(660, 98);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "Latitud:";
            // 
            // dataGridViewUbicacions
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dataGridViewUbicacions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewUbicacions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUbicacions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUbicacions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewUbicacions.ColumnHeadersHeight = 20;
            this.dataGridViewUbicacions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUbicacions.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewUbicacions.GridColor = System.Drawing.Color.Black;
            this.dataGridViewUbicacions.Location = new System.Drawing.Point(662, 277);
            this.dataGridViewUbicacions.MultiSelect = false;
            this.dataGridViewUbicacions.Name = "dataGridViewUbicacions";
            this.dataGridViewUbicacions.ReadOnly = true;
            this.dataGridViewUbicacions.RowHeadersVisible = false;
            this.dataGridViewUbicacions.Size = new System.Drawing.Size(375, 177);
            this.dataGridViewUbicacions.TabIndex = 30;
            this.dataGridViewUbicacions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewUbicacions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewUbicacions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewUbicacions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewUbicacions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewUbicacions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewUbicacions.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dataGridViewUbicacions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewUbicacions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewUbicacions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewUbicacions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewUbicacions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewUbicacions.ThemeStyle.HeaderStyle.Height = 20;
            this.dataGridViewUbicacions.ThemeStyle.ReadOnly = true;
            this.dataGridViewUbicacions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewUbicacions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewUbicacions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewUbicacions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewUbicacions.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewUbicacions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewUbicacions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TextBoxLatitud
            // 
            this.TextBoxLatitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLatitud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLatitud.DefaultText = "";
            this.TextBoxLatitud.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxLatitud.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxLatitud.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxLatitud.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxLatitud.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxLatitud.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxLatitud.ForeColor = System.Drawing.Color.Black;
            this.TextBoxLatitud.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxLatitud.Location = new System.Drawing.Point(662, 120);
            this.TextBoxLatitud.Name = "TextBoxLatitud";
            this.TextBoxLatitud.PlaceholderText = "";
            this.TextBoxLatitud.SelectedText = "";
            this.TextBoxLatitud.Size = new System.Drawing.Size(243, 36);
            this.TextBoxLatitud.TabIndex = 136;
            // 
            // TextBoxLongitud
            // 
            this.TextBoxLongitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLongitud.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLongitud.DefaultText = "";
            this.TextBoxLongitud.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxLongitud.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxLongitud.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxLongitud.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxLongitud.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxLongitud.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxLongitud.ForeColor = System.Drawing.Color.Black;
            this.TextBoxLongitud.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxLongitud.Location = new System.Drawing.Point(662, 208);
            this.TextBoxLongitud.Name = "TextBoxLongitud";
            this.TextBoxLongitud.PlaceholderText = "";
            this.TextBoxLongitud.SelectedText = "";
            this.TextBoxLongitud.Size = new System.Drawing.Size(243, 36);
            this.TextBoxLongitud.TabIndex = 137;
            // 
            // materialButtonSat
            // 
            this.materialButtonSat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialButtonSat.BorderRadius = 10;
            this.materialButtonSat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.materialButtonSat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.materialButtonSat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.materialButtonSat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.materialButtonSat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialButtonSat.ForeColor = System.Drawing.Color.White;
            this.materialButtonSat.Location = new System.Drawing.Point(76, 466);
            this.materialButtonSat.Name = "materialButtonSat";
            this.materialButtonSat.Size = new System.Drawing.Size(112, 33);
            this.materialButtonSat.TabIndex = 143;
            this.materialButtonSat.Text = "SATÈL·LIT";
            this.materialButtonSat.Click += new System.EventHandler(this.materialButtonSat_Click);
            // 
            // materialButtonOrg
            // 
            this.materialButtonOrg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialButtonOrg.BorderRadius = 10;
            this.materialButtonOrg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.materialButtonOrg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.materialButtonOrg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.materialButtonOrg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.materialButtonOrg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialButtonOrg.ForeColor = System.Drawing.Color.White;
            this.materialButtonOrg.Location = new System.Drawing.Point(343, 466);
            this.materialButtonOrg.Name = "materialButtonOrg";
            this.materialButtonOrg.Size = new System.Drawing.Size(112, 33);
            this.materialButtonOrg.TabIndex = 144;
            this.materialButtonOrg.Text = "ORIGINAL";
            this.materialButtonOrg.Click += new System.EventHandler(this.materialButtonOrg_Click);
            // 
            // materialButtonAfegirUbi
            // 
            this.materialButtonAfegirUbi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonAfegirUbi.BorderRadius = 10;
            this.materialButtonAfegirUbi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.materialButtonAfegirUbi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.materialButtonAfegirUbi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.materialButtonAfegirUbi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.materialButtonAfegirUbi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialButtonAfegirUbi.ForeColor = System.Drawing.Color.White;
            this.materialButtonAfegirUbi.Location = new System.Drawing.Point(662, 466);
            this.materialButtonAfegirUbi.Name = "materialButtonAfegirUbi";
            this.materialButtonAfegirUbi.Size = new System.Drawing.Size(112, 33);
            this.materialButtonAfegirUbi.TabIndex = 145;
            this.materialButtonAfegirUbi.Text = "AFEGIR";
            // 
            // materialButtonConfirmarUbi
            // 
            this.materialButtonConfirmarUbi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButtonConfirmarUbi.BorderRadius = 10;
            this.materialButtonConfirmarUbi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.materialButtonConfirmarUbi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.materialButtonConfirmarUbi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.materialButtonConfirmarUbi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.materialButtonConfirmarUbi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialButtonConfirmarUbi.ForeColor = System.Drawing.Color.White;
            this.materialButtonConfirmarUbi.Location = new System.Drawing.Point(925, 466);
            this.materialButtonConfirmarUbi.Name = "materialButtonConfirmarUbi";
            this.materialButtonConfirmarUbi.Size = new System.Drawing.Size(112, 33);
            this.materialButtonConfirmarUbi.TabIndex = 146;
            this.materialButtonConfirmarUbi.Text = "CONFIRMAR";
            // 
            // UbicacioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 527);
            this.Controls.Add(this.materialButtonConfirmarUbi);
            this.Controls.Add(this.materialButtonAfegirUbi);
            this.Controls.Add(this.materialButtonOrg);
            this.Controls.Add(this.materialButtonSat);
            this.Controls.Add(this.TextBoxLongitud);
            this.Controls.Add(this.TextBoxLatitud);
            this.Controls.Add(this.dataGridViewUbicacions);
            this.Controls.Add(this.gMapControlUbi);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "UbicacioForm";
            this.Text = "MapaForm";
            this.Load += new System.EventHandler(this.UbicacioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUbicacions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public GMap.NET.WindowsForms.GMapControl gMapControlUbi;
        public MaterialSkin.Controls.MaterialLabel materialLabel2;
        public MaterialSkin.Controls.MaterialLabel materialLabel1;
        public Guna.UI2.WinForms.Guna2DataGridView dataGridViewUbicacions;
        public Guna.UI2.WinForms.Guna2TextBox TextBoxLatitud;
        public Guna.UI2.WinForms.Guna2TextBox TextBoxLongitud;
        public Guna.UI2.WinForms.Guna2Button materialButtonSat;
        public Guna.UI2.WinForms.Guna2Button materialButtonOrg;
        public Guna.UI2.WinForms.Guna2Button materialButtonAfegirUbi;
        public Guna.UI2.WinForms.Guna2Button materialButtonConfirmarUbi;
    }
}