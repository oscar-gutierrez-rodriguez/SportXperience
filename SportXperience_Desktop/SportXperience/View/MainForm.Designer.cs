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
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.monthCalendarEvents = new Pabo.Calendar.MonthCalendar();
            this.buttonAfegir = new MaterialSkin.Controls.MaterialButton();
            this.buttonActualitzar = new MaterialSkin.Controls.MaterialButton();
            this.buttonEliminar = new MaterialSkin.Controls.MaterialButton();
            this.buttonResultats = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEvents.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Location = new System.Drawing.Point(48, 99);
            this.dataGridViewEvents.MultiSelect = false;
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.ReadOnly = true;
            this.dataGridViewEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEvents.Size = new System.Drawing.Size(722, 390);
            this.dataGridViewEvents.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "SportXperience";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Location = new System.Drawing.Point(1283, 24);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
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
            this.monthCalendarEvents.Location = new System.Drawing.Point(1051, 158);
            this.monthCalendarEvents.MaxDate = new System.DateTime(2035, 3, 27, 15, 46, 19, 762);
            this.monthCalendarEvents.MinDate = new System.DateTime(2015, 3, 27, 15, 46, 19, 762);
            this.monthCalendarEvents.Month.BackgroundImage = null;
            this.monthCalendarEvents.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendarEvents.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendarEvents.Name = "monthCalendarEvents";
            this.monthCalendarEvents.Size = new System.Drawing.Size(348, 213);
            this.monthCalendarEvents.TabIndex = 7;
            this.monthCalendarEvents.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendarEvents.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAfegir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAfegir.Depth = 0;
            this.buttonAfegir.HighEmphasis = true;
            this.buttonAfegir.Icon = null;
            this.buttonAfegir.Location = new System.Drawing.Point(874, 158);
            this.buttonAfegir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAfegir.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAfegir.Size = new System.Drawing.Size(71, 36);
            this.buttonAfegir.TabIndex = 8;
            this.buttonAfegir.Text = "AFEGIR";
            this.buttonAfegir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAfegir.UseAccentColor = true;
            this.buttonAfegir.UseVisualStyleBackColor = true;
            // 
            // buttonActualitzar
            // 
            this.buttonActualitzar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonActualitzar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonActualitzar.Depth = 0;
            this.buttonActualitzar.HighEmphasis = true;
            this.buttonActualitzar.Icon = null;
            this.buttonActualitzar.Location = new System.Drawing.Point(874, 239);
            this.buttonActualitzar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonActualitzar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonActualitzar.Name = "buttonActualitzar";
            this.buttonActualitzar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonActualitzar.Size = new System.Drawing.Size(118, 36);
            this.buttonActualitzar.TabIndex = 9;
            this.buttonActualitzar.Text = "ACTUALITZAR";
            this.buttonActualitzar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonActualitzar.UseAccentColor = false;
            this.buttonActualitzar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonEliminar.Depth = 0;
            this.buttonEliminar.HighEmphasis = true;
            this.buttonEliminar.Icon = null;
            this.buttonEliminar.Location = new System.Drawing.Point(877, 324);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonEliminar.Size = new System.Drawing.Size(88, 36);
            this.buttonEliminar.TabIndex = 10;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonEliminar.UseAccentColor = true;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonResultats
            // 
            this.buttonResultats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonResultats.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonResultats.Depth = 0;
            this.buttonResultats.HighEmphasis = true;
            this.buttonResultats.Icon = null;
            this.buttonResultats.Location = new System.Drawing.Point(1228, 453);
            this.buttonResultats.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonResultats.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonResultats.Name = "buttonResultats";
            this.buttonResultats.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonResultats.Size = new System.Drawing.Size(155, 36);
            this.buttonResultats.TabIndex = 11;
            this.buttonResultats.Text = "AFEGIR RESULTATS";
            this.buttonResultats.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonResultats.UseAccentColor = false;
            this.buttonResultats.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 532);
            this.Controls.Add(this.buttonResultats);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonActualitzar);
            this.Controls.Add(this.buttonAfegir);
            this.Controls.Add(this.monthCalendarEvents);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEvents);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewEvents;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBoxLogo;
        public Pabo.Calendar.MonthCalendar monthCalendarEvents;
        public MaterialSkin.Controls.MaterialButton buttonResultats;
        public MaterialSkin.Controls.MaterialButton buttonEliminar;
        public MaterialSkin.Controls.MaterialButton buttonActualitzar;
        public MaterialSkin.Controls.MaterialButton buttonAfegir;
    }
}

