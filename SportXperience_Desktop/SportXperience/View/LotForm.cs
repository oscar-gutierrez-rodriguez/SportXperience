using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportXperience.View
{
    public partial class LotForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public LotForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                       MaterialSkin.Primary.Green600,
                       MaterialSkin.Primary.Green600,
                       MaterialSkin.Primary.Purple700,
                       MaterialSkin.Accent.Red200,
                       MaterialSkin.TextShade.WHITE
                   );
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAfegirOpcio_Click(object sender, EventArgs e)
        {

        }

        private void LotForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewOpcions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
