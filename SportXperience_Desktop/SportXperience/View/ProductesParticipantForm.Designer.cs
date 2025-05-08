namespace SportXperience.View
{
    partial class ProductesParticipantForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridViewProdPar = new System.Windows.Forms.DataGridView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridViewTotal = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdPar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.dataGridViewTotal);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.dataGridViewProdPar);
            this.panel1.Location = new System.Drawing.Point(-1, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 437);
            this.panel1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(81, 16);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(182, 19);
            this.materialLabel1.TabIndex = 23;
            this.materialLabel1.Text = "Productes per participant:";
            // 
            // dataGridViewProdPar
            // 
            this.dataGridViewProdPar.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewProdPar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdPar.Location = new System.Drawing.Point(84, 38);
            this.dataGridViewProdPar.MultiSelect = false;
            this.dataGridViewProdPar.Name = "dataGridViewProdPar";
            this.dataGridViewProdPar.ReadOnly = true;
            this.dataGridViewProdPar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewProdPar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdPar.Size = new System.Drawing.Size(342, 171);
            this.dataGridViewProdPar.TabIndex = 2;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(81, 224);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(42, 19);
            this.materialLabel2.TabIndex = 24;
            this.materialLabel2.Text = "Total:";
            // 
            // dataGridViewTotal
            // 
            this.dataGridViewTotal.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTotal.Location = new System.Drawing.Point(84, 246);
            this.dataGridViewTotal.MultiSelect = false;
            this.dataGridViewTotal.Name = "dataGridViewTotal";
            this.dataGridViewTotal.ReadOnly = true;
            this.dataGridViewTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTotal.Size = new System.Drawing.Size(342, 159);
            this.dataGridViewTotal.TabIndex = 25;
            this.dataGridViewTotal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProductesParticipantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 494);
            this.Controls.Add(this.panel1);
            this.Name = "ProductesParticipantForm";
            this.Text = "ProductesParticipantForm";
            this.Load += new System.EventHandler(this.ProductesParticipantForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdPar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataGridViewProdPar;
        public MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        public System.Windows.Forms.DataGridView dataGridViewTotal;
    }
}