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
            this.TextBoxLatitud = new MaterialSkin.Controls.MaterialTextBox();
            this.TextBoxLongitud = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonConfirmarUbi = new MaterialSkin.Controls.MaterialButton();
            this.gMapControlUbi = new GMap.NET.WindowsForms.GMapControl();
            this.dataGridViewUbicacions = new System.Windows.Forms.DataGridView();
            this.materialButtonAfegirUbi = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonSat = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonOrg = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUbicacions)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxLatitud
            // 
            this.TextBoxLatitud.AnimateReadOnly = false;
            this.TextBoxLatitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxLatitud.Depth = 0;
            this.TextBoxLatitud.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxLatitud.LeadingIcon = null;
            this.TextBoxLatitud.Location = new System.Drawing.Point(597, 47);
            this.TextBoxLatitud.MaxLength = 50;
            this.TextBoxLatitud.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxLatitud.Multiline = false;
            this.TextBoxLatitud.Name = "TextBoxLatitud";
            this.TextBoxLatitud.ReadOnly = true;
            this.TextBoxLatitud.Size = new System.Drawing.Size(243, 50);
            this.TextBoxLatitud.TabIndex = 0;
            this.TextBoxLatitud.Text = "";
            this.TextBoxLatitud.TrailingIcon = null;
            // 
            // TextBoxLongitud
            // 
            this.TextBoxLongitud.AnimateReadOnly = false;
            this.TextBoxLongitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxLongitud.Depth = 0;
            this.TextBoxLongitud.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextBoxLongitud.LeadingIcon = null;
            this.TextBoxLongitud.Location = new System.Drawing.Point(597, 135);
            this.TextBoxLongitud.MaxLength = 50;
            this.TextBoxLongitud.MouseState = MaterialSkin.MouseState.OUT;
            this.TextBoxLongitud.Multiline = false;
            this.TextBoxLongitud.Name = "TextBoxLongitud";
            this.TextBoxLongitud.ReadOnly = true;
            this.TextBoxLongitud.Size = new System.Drawing.Size(243, 50);
            this.TextBoxLongitud.TabIndex = 1;
            this.TextBoxLongitud.Text = "";
            this.TextBoxLongitud.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(594, 25);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Latitud:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(594, 113);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Longitud:";
            // 
            // materialButtonConfirmarUbi
            // 
            this.materialButtonConfirmarUbi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonConfirmarUbi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonConfirmarUbi.Depth = 0;
            this.materialButtonConfirmarUbi.HighEmphasis = true;
            this.materialButtonConfirmarUbi.Icon = null;
            this.materialButtonConfirmarUbi.Location = new System.Drawing.Point(734, 390);
            this.materialButtonConfirmarUbi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonConfirmarUbi.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonConfirmarUbi.Name = "materialButtonConfirmarUbi";
            this.materialButtonConfirmarUbi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonConfirmarUbi.Size = new System.Drawing.Size(105, 36);
            this.materialButtonConfirmarUbi.TabIndex = 4;
            this.materialButtonConfirmarUbi.Text = "CONFIRMAR";
            this.materialButtonConfirmarUbi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonConfirmarUbi.UseAccentColor = false;
            this.materialButtonConfirmarUbi.UseVisualStyleBackColor = true;
            // 
            // gMapControlUbi
            // 
            this.gMapControlUbi.Bearing = 0F;
            this.gMapControlUbi.CanDragMap = true;
            this.gMapControlUbi.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControlUbi.GrayScaleMode = false;
            this.gMapControlUbi.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControlUbi.LevelsKeepInMemory = 5;
            this.gMapControlUbi.Location = new System.Drawing.Point(33, 25);
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
            this.gMapControlUbi.Size = new System.Drawing.Size(527, 356);
            this.gMapControlUbi.TabIndex = 5;
            this.gMapControlUbi.Zoom = 0D;
            this.gMapControlUbi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControlUbi_MouseDoubleClick);
            // 
            // dataGridViewUbicacions
            // 
            this.dataGridViewUbicacions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUbicacions.Location = new System.Drawing.Point(597, 204);
            this.dataGridViewUbicacions.MultiSelect = false;
            this.dataGridViewUbicacions.Name = "dataGridViewUbicacions";
            this.dataGridViewUbicacions.ReadOnly = true;
            this.dataGridViewUbicacions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUbicacions.Size = new System.Drawing.Size(243, 177);
            this.dataGridViewUbicacions.TabIndex = 6;
            this.dataGridViewUbicacions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUbicacions_CellContentClick);
            // 
            // materialButtonAfegirUbi
            // 
            this.materialButtonAfegirUbi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAfegirUbi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAfegirUbi.Depth = 0;
            this.materialButtonAfegirUbi.HighEmphasis = true;
            this.materialButtonAfegirUbi.Icon = null;
            this.materialButtonAfegirUbi.Location = new System.Drawing.Point(597, 390);
            this.materialButtonAfegirUbi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonAfegirUbi.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAfegirUbi.Name = "materialButtonAfegirUbi";
            this.materialButtonAfegirUbi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAfegirUbi.Size = new System.Drawing.Size(71, 36);
            this.materialButtonAfegirUbi.TabIndex = 7;
            this.materialButtonAfegirUbi.Text = "AFEGIR";
            this.materialButtonAfegirUbi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAfegirUbi.UseAccentColor = false;
            this.materialButtonAfegirUbi.UseVisualStyleBackColor = true;
            this.materialButtonAfegirUbi.Click += new System.EventHandler(this.materialButtonAfegir_Click);
            // 
            // materialButtonSat
            // 
            this.materialButtonSat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSat.Depth = 0;
            this.materialButtonSat.HighEmphasis = true;
            this.materialButtonSat.Icon = null;
            this.materialButtonSat.Location = new System.Drawing.Point(106, 390);
            this.materialButtonSat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSat.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSat.Name = "materialButtonSat";
            this.materialButtonSat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSat.Size = new System.Drawing.Size(87, 36);
            this.materialButtonSat.TabIndex = 8;
            this.materialButtonSat.Text = "SATÉLITE";
            this.materialButtonSat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSat.UseAccentColor = false;
            this.materialButtonSat.UseVisualStyleBackColor = true;
            this.materialButtonSat.Click += new System.EventHandler(this.materialButtonSat_Click);
            // 
            // materialButtonOrg
            // 
            this.materialButtonOrg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonOrg.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonOrg.Depth = 0;
            this.materialButtonOrg.HighEmphasis = true;
            this.materialButtonOrg.Icon = null;
            this.materialButtonOrg.Location = new System.Drawing.Point(373, 390);
            this.materialButtonOrg.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonOrg.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonOrg.Name = "materialButtonOrg";
            this.materialButtonOrg.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonOrg.Size = new System.Drawing.Size(71, 36);
            this.materialButtonOrg.TabIndex = 9;
            this.materialButtonOrg.Text = "ORIGINAL";
            this.materialButtonOrg.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonOrg.UseAccentColor = false;
            this.materialButtonOrg.UseVisualStyleBackColor = true;
            this.materialButtonOrg.Click += new System.EventHandler(this.materialButtonOrg_Click);
            // 
            // UbicacioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.materialButtonOrg);
            this.Controls.Add(this.materialButtonSat);
            this.Controls.Add(this.materialButtonAfegirUbi);
            this.Controls.Add(this.dataGridViewUbicacions);
            this.Controls.Add(this.gMapControlUbi);
            this.Controls.Add(this.materialButtonConfirmarUbi);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TextBoxLongitud);
            this.Controls.Add(this.TextBoxLatitud);
            this.Name = "UbicacioForm";
            this.Text = "MapaForm";
            this.Load += new System.EventHandler(this.UbicacioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUbicacions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialTextBox TextBoxLatitud;
        public MaterialSkin.Controls.MaterialTextBox TextBoxLongitud;
        public MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialLabel materialLabel2;
        public MaterialSkin.Controls.MaterialButton materialButtonConfirmarUbi;
        public GMap.NET.WindowsForms.GMapControl gMapControlUbi;
        public System.Windows.Forms.DataGridView dataGridViewUbicacions;
        public MaterialSkin.Controls.MaterialButton materialButtonAfegirUbi;
        public MaterialSkin.Controls.MaterialButton materialButtonSat;
        public MaterialSkin.Controls.MaterialButton materialButtonOrg;
    }
}