namespace SportXperience
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonResultats = new MaterialSkin.Controls.MaterialButton();
            this.buttonEliminar = new MaterialSkin.Controls.MaterialButton();
            this.buttonActualitzar = new MaterialSkin.Controls.MaterialButton();
            this.buttonAfegir = new MaterialSkin.Controls.MaterialButton();
            this.monthCalendarEvents = new Pabo.Calendar.MonthCalendar();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Location = new System.Drawing.Point(-3, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1435, 626);
            this.panel1.TabIndex = 12;
            // 
            // buttonResultats
            // 
            this.buttonResultats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonResultats.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonResultats.Depth = 0;
            this.buttonResultats.HighEmphasis = true;
            this.buttonResultats.Icon = null;
            this.buttonResultats.Location = new System.Drawing.Point(1219, 566);
            this.buttonResultats.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonResultats.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonResultats.Name = "buttonResultats";
            this.buttonResultats.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonResultats.Size = new System.Drawing.Size(155, 36);
            this.buttonResultats.TabIndex = 19;
            this.buttonResultats.Text = "AFEGIR RESULTATS";
            this.buttonResultats.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonResultats.UseAccentColor = false;
            this.buttonResultats.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonEliminar.Depth = 0;
            this.buttonEliminar.HighEmphasis = true;
            this.buttonEliminar.Icon = null;
            this.buttonEliminar.Location = new System.Drawing.Point(868, 437);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonEliminar.Size = new System.Drawing.Size(88, 36);
            this.buttonEliminar.TabIndex = 18;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonEliminar.UseAccentColor = true;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonActualitzar
            // 
            this.buttonActualitzar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonActualitzar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonActualitzar.Depth = 0;
            this.buttonActualitzar.HighEmphasis = true;
            this.buttonActualitzar.Icon = null;
            this.buttonActualitzar.Location = new System.Drawing.Point(865, 352);
            this.buttonActualitzar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonActualitzar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonActualitzar.Name = "buttonActualitzar";
            this.buttonActualitzar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonActualitzar.Size = new System.Drawing.Size(118, 36);
            this.buttonActualitzar.TabIndex = 17;
            this.buttonActualitzar.Text = "ACTUALITZAR";
            this.buttonActualitzar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonActualitzar.UseAccentColor = false;
            this.buttonActualitzar.UseVisualStyleBackColor = true;
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAfegir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAfegir.Depth = 0;
            this.buttonAfegir.HighEmphasis = true;
            this.buttonAfegir.Icon = null;
            this.buttonAfegir.Location = new System.Drawing.Point(865, 271);
            this.buttonAfegir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAfegir.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAfegir.Size = new System.Drawing.Size(71, 36);
            this.buttonAfegir.TabIndex = 16;
            this.buttonAfegir.Text = "AFEGIR";
            this.buttonAfegir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAfegir.UseAccentColor = true;
            this.buttonAfegir.UseVisualStyleBackColor = true;
            // 
            // monthCalendarEvents
            // 
            this.monthCalendarEvents.ActiveMonth.Month = 3;
            this.monthCalendarEvents.ActiveMonth.Year = 2025;
            this.monthCalendarEvents.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.monthCalendarEvents.Culture = new System.Globalization.CultureInfo("es");
            this.monthCalendarEvents.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendarEvents.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendarEvents.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendarEvents.ImageList = null;
            this.monthCalendarEvents.Location = new System.Drawing.Point(1042, 260);
            this.monthCalendarEvents.MaxDate = new System.DateTime(2035, 3, 27, 15, 46, 19, 762);
            this.monthCalendarEvents.MinDate = new System.DateTime(2015, 3, 27, 15, 46, 19, 762);
            this.monthCalendarEvents.Month.BackgroundImage = null;
            this.monthCalendarEvents.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendarEvents.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendarEvents.Name = "monthCalendarEvents";
            this.monthCalendarEvents.Size = new System.Drawing.Size(348, 213);
            this.monthCalendarEvents.TabIndex = 15;
            this.monthCalendarEvents.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendarEvents.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Location = new System.Drawing.Point(1301, 13);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxLogo.TabIndex = 14;
            this.pictureBoxLogo.TabStop = false;
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEvents.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Location = new System.Drawing.Point(40, 177);
            this.dataGridViewEvents.MultiSelect = false;
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.ReadOnly = true;
            this.dataGridViewEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEvents.Size = new System.Drawing.Size(722, 451);
            this.dataGridViewEvents.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1430, 684);
            this.Controls.Add(this.buttonResultats);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonActualitzar);
            this.Controls.Add(this.buttonAfegir);
            this.Controls.Add(this.monthCalendarEvents);
            this.Controls.Add(this.dataGridViewEvents);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SportXperience";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureBoxLogo;
        public MaterialSkin.Controls.MaterialButton buttonResultats;
        public MaterialSkin.Controls.MaterialButton buttonEliminar;
        public MaterialSkin.Controls.MaterialButton buttonActualitzar;
        public MaterialSkin.Controls.MaterialButton buttonAfegir;
        public Pabo.Calendar.MonthCalendar monthCalendarEvents;
        public System.Windows.Forms.DataGridView dataGridViewEvents;
    }
}

