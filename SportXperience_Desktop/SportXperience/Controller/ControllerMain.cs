using SportXperience.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportXperience.Controller
{
    public class ControllerMain
    {
        MainForm f = new MainForm();
        AfegirActualitzarForm fafegir = new AfegirActualitzarForm();
        LotForm lot = new LotForm();
        Resultats r = new Resultats();
        DateTime dataMin = DateTime.Now.AddDays(2);

        public ControllerMain()
        {
            loadData();
            setListeners();
            f.Show();
            
        }

        void loadData()
        {
            f.buttonEliminar.Enabled = false;
            f.buttonActualitzar.Enabled = false;
            f.buttonAfegir.Enabled = true;
           

            f.pictureBoxLogo.Image = Image.FromFile(@"C:\Users\cv\Desktop\PROJECTEFINAL\logo.png");
            f.pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
        }

        void setListeners()
        {
            f.buttonAfegir.Click += ButtonAfegir_Click;
            fafegir.checkBoxLot.CheckedChanged += CheckBoxLot_CheckedChanged;
            fafegir.checkBoxPagament.CheckedChanged += CheckBoxPagamanet_CheckedChanged;
            fafegir.dateTimePickerInici.ValueChanged += DateTimePickerInici_ValueChanged;
            fafegir.dateTimePickerFinal.ValueChanged += DateTimePickerFinal_ValueChanged;
            fafegir.buttonAfegirProducte.Click += ButtonAfegirProducte_Click;
            lot.checkBoxOpcio.CheckedChanged += CheckBoxOpcio_CheckedChanged;
            f.buttonResultats.Click += ButtonResultats_Click;
            r.buttonAfegirRsultat.Click += ButtonAfegirRsultat_Click;
            f.FormClosed += (s, e) => Application.Exit();
            fafegir.FormClosed += (s, e) => f.Show();
            lot.FormClosed += (s, e) => fafegir.Show();
            r.FormClosed += (s, e) => f.Show();
        }

        private void ButtonAfegirRsultat_Click(object sender, EventArgs e)
        {
            r.Close();
            f.Show();
        }

        private void ButtonResultats_Click(object sender, EventArgs e)
        {
            f.Hide();
            r.ShowDialog();
        }

        private void CheckBoxOpcio_CheckedChanged(object sender, EventArgs e)
        {
            if (lot.checkBoxOpcio.Checked)
            {
                lot.textBoxNomOpProd.Enabled = true;
                lot.buttonAfegirOpcio.Enabled = true;
                lot.labelOpProd.Enabled = true;
            }
            else
            {
                lot.textBoxNomOpProd.Enabled = false;
                lot.buttonAfegirOpcio.Enabled = false;
                lot.labelOpProd.Enabled = false;
                lot.textBoxNomOpProd.Clear();
            }
        }

        private void ButtonAfegirProducte_Click(object sender, EventArgs e)
        {
            fafegir.Hide();
            lot.Show();
        }

        private void DateTimePickerFinal_ValueChanged(object sender, EventArgs e)
        {
            if (fafegir.dateTimePickerFinal.Value < fafegir.dateTimePickerInici.Value)
            {
                MessageBox.Show("La data final no pot ser inferior a " + fafegir.dateTimePickerInici.Value.ToString("dd/MM/yyyy"));
                fafegir.dateTimePickerFinal.Value = fafegir.dateTimePickerInici.Value;
            }
        }

        private void DateTimePickerInici_ValueChanged(object sender, EventArgs e)
        {
            if (fafegir.dateTimePickerInici.Value < dataMin)
            {
                MessageBox.Show("La data de inici no pot ser inferior a " + dataMin.ToString("dd/MM/yyyy"));
                fafegir.dateTimePickerInici.Value = dataMin;

            }
            else
            {
                fafegir.dateTimePickerFinal.Value = fafegir.dateTimePickerInici.Value;
            }
        }



        private void CheckBoxPagamanet_CheckedChanged(object sender, EventArgs e)
        {
            if (fafegir.checkBoxPagament.Checked)
            {
                fafegir.textBoxPreu.Enabled = true;
                fafegir.textBoxPremi.Enabled = true;
                fafegir.labelPreu.Enabled = true;
                fafegir.labelPremi.Enabled = true;
            }
            else
            {
                fafegir.textBoxPreu.Enabled = false;
                fafegir.textBoxPremi.Enabled = false;
                fafegir.labelPreu.Enabled = false;
                fafegir.labelPremi.Enabled = false;
                fafegir.textBoxPreu.Clear();
                fafegir.textBoxPremi.Clear();
            }
        }

        private void CheckBoxLot_CheckedChanged(object sender, EventArgs e)
        {
            if (fafegir.checkBoxLot.Checked)
            {
                fafegir.listBoxLot.Enabled = true;
                fafegir.buttonAfegirProducte.Enabled = true;
                fafegir.buttonEliminarProducte.Enabled = true;
            }
            else
            {
                fafegir.listBoxLot.Enabled = false;
                fafegir.buttonAfegirProducte.Enabled = false;
                fafegir.buttonEliminarProducte.Enabled = false;

                fafegir.listBoxLot.Items.Clear();

            }

        }

        private void ButtonAfegir_Click(object sender, EventArgs e)
        {
            f.Hide();
            fafegir.dateTimePickerInici.Value = dataMin;
            fafegir.dateTimePickerFinal.Value = dataMin;
            fafegir.Show();

        }
    }
}
