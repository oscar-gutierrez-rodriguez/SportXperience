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
    public partial class AfegirActualitzarForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public AfegirActualitzarForm()
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonImagen_Click(object sender, EventArgs e)
        {

        }

        private void AfegirActualitzarForm_Load(object sender, EventArgs e)
        {

        }

        private void labelPreu_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerInici_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPreu_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerInici_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void buttonAfegirProducte_Click(object sender, EventArgs e)
        {

        }

        private void buttonActualitzarProducte_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminarProducte_Click(object sender, EventArgs e)
        {

        }

        private void buttonImagen_Click_1(object sender, EventArgs e)
        {

        }

        private void materialButtonUbi_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDescripcio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPremi_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFinal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEsport_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBoxNomCiutat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPagament_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxLot_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownEdatMaxima_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownEdatMinima_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxIlimitat_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownParticipants_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxNivell_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void listBoxLot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel16_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel15_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel14_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel13_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel12_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel11_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel10_Click(object sender, EventArgs e)
        {

        }

        private void labelPremi_Click(object sender, EventArgs e)
        {

        }

        private void labelPreu_Click_1(object sender, EventArgs e)
        {

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogoEvent_Click(object sender, EventArgs e)
        {

        }
    }
}
