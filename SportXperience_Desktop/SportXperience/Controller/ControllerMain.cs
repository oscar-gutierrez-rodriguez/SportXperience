using DesktopModels.Model;
using SportXperience.Model;
using SportXperience.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        List<Product> products = new List<Product>();
        List<Option> options = new List<Option>();

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
            fafegir.AllowDrop = true;
            f.pictureBoxLogo.Image = Image.FromFile(@"C:\Users\cv\Desktop\PROJECTEFINAL\logo.png");
            f.pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            fafegir.comboBoxNivell.DataSource = Repositori.GetRecommendedLevel();
            fafegir.comboBoxNivell.DisplayMember = "name";

            loadDataGrid();

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
            fafegir.buttonConfirmar.Click += ButtonConfirmar_Click;
            lot.buttonAfegirProducte.Click += ButtonAfegirProducte_Click1;
            fafegir.buttonImagen.Click += ButtonImagen_Click;
            fafegir.buttonEliminarProducte.Click += ButtonEliminarProducte_Click;
            lot.buttonAfegirOpcio.Click += ButtonAfegirOpcio_Click;
            f.dataGridViewEvents.SelectionChanged += DataGridViewEvents_SelectionChanged;
            f.buttonActualitzar.Click += ButtonActualitzar_Click;
        }

        private void ButtonActualitzar_Click(object sender, EventArgs e)
        {
            Event ev = f.dataGridViewEvents.SelectedRows[0].DataBoundItem as Event;
            
            fafegir.textBoxNom.Text = ev.Name;
            fafegir.textBoxDescripcio.Text = ev.Description;
            fafegir.textBoxPremi.Text = ev.Reward;
            fafegir.textBoxPreu.Text = ev.Price.ToString();
            fafegir.numericUpDownEdatMinima.Value = ev.MinAge.Value;
            fafegir.numericUpDownEdatMaxima.Value = ev.MaxAge.Value;
            fafegir.numericUpDownParticipants.Value = ev.MaxParticipantsNumber.Value;
           // fafegir.comboBoxNivell.Text = ev.RecommendedLevel.Name;
           // fafegir.textBoxEsport.Text = ev.Sport.Name;
            fafegir.ShowDialog();
            
        }

        private void DataGridViewEvents_SelectionChanged(object sender, EventArgs e)
        {
            if (f.dataGridViewEvents.SelectedRows.Count == 0 )
            {
                f.buttonEliminar.Enabled = false;
                f.buttonActualitzar.Enabled = false;
                f.buttonAfegir.Enabled = true;
            }
            else
            {
                f.buttonEliminar.Enabled = true;
                f.buttonActualitzar.Enabled = true;
                f.buttonAfegir.Enabled = true;
            }

        }

        private void ButtonAfegirOpcio_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(lot.textBoxNomProd.Text))
            {
                MessageBox.Show("No pots afegir una opcio sense el nom del producte.");
                
            }
            else{
                if (lot.checkBoxOpcio.Checked)
                {
                    if (OpcioRepetit(lot.textBoxNomOpProd.Text))
                    {
                        MessageBox.Show("No pot haver opcions repetides");
                    }
                    else
                    {
                        Option o = new Option
                        {
                            Name = lot.textBoxNomOpProd.Text,

                        };
                        options.Add(o);
                        ActualitzarGridOptions();
                    }
                }
            }
        }

        private void ActualitzarGridOptions()
        {
            List<ViewOption> viewOptions = new List<ViewOption>();

            viewOptions = options.Select(x => new ViewOption(x.Name)).ToList();
            lot.dataGridViewOpcions.DataSource = viewOptions;

        }

        private void ButtonEliminarProducte_Click(object sender, EventArgs e)
        { 

            List<int> indices = fafegir.listBoxLot.SelectedIndices.Cast<int>().OrderByDescending(i => i).ToList();

            foreach (int index in indices)
            {
                fafegir.listBoxLot.Items.RemoveAt(index);
                products.RemoveAt(index);
            }
        }
        private void ButtonImagen_Click(object sender, EventArgs e)
        {

            OpenFileDialog archiu = new OpenFileDialog();
            archiu.Title = "Imagenes";
            archiu.ShowHelp = true;
            if (archiu.ShowDialog() == DialogResult.OK)
            {
                fafegir.pictureBoxLogoEvent.Image = Image.FromFile(archiu.FileName);
            }
            else
            {
                Console.WriteLine("algo");
            }
        }


        private void ButtonAfegirProducte_Click1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lot.textBoxNomProd.Text))
            {
                MessageBox.Show("No pots afegir una opcio sense el nom del producte.");
            }
            else if (ProducteRepetit(lot.textBoxNomProd.Text))
            {
                MessageBox.Show("No pot haver productes repetits");
            }
            else
            {
                Product p = new Product 
                { 
                    Name = lot.textBoxNomProd.Text,
                    Options = options
                };
                products.Add(p);    
                fafegir.listBoxLot.Items.Add(lot.textBoxNomProd.Text);
                options = new List<Option>();
                NetejarDadesLot();
                lot.Close();
                f.Show();

            }
        }

        Boolean OpcioRepetit(string opcions)
        {
            foreach (Option e in options)
            {
                if (e.Name.ToLower().Equals(opcions))
                {
                    return true;
                }
            }
            return false;
        }
        Boolean ProducteRepetit(string productes)
        {
            foreach (Product e in products) 
            {
                if (e.Name.ToLower().Equals(productes))
                {
                    return true;
                }
            }
            return false;
            }

        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {

            double price = 0;
            double priceText = 0;
            String award = "";
            if (fafegir.numericUpDownEdatMinima.Value > fafegir.numericUpDownEdatMaxima.Value)
            {
                MessageBox.Show("La edat màxima no potser inferior a " + fafegir.numericUpDownEdatMinima.Value.ToString());
                fafegir.numericUpDownEdatMaxima.Value = fafegir.numericUpDownEdatMinima.Value;
            }
            else if (fafegir.numericUpDownParticipants.Value < 2)
            {
                MessageBox.Show("Mínim ha d'haver 2 participants ");
                fafegir.numericUpDownParticipants.Value = 2;
            }
            else
            {

                if (fafegir.checkBoxPagament.Checked)
                {
                    if (Double.TryParse(fafegir.textBoxPreu.Text, out priceText))
                    {
                        award = fafegir.textBoxPremi.Text;
                        price = priceText;
                        InsertarSport();
                        InsertarEvent(award, price);
                        InsertarParticipant();
                        if (fafegir.checkBoxLot.Checked)
                        {
                            InsertarLot();
                            InsertarProductes();
                            InsertarOptions();

                        }


                    }
                    else
                    {
                        MessageBox.Show("El valor introduït no es vàlid");
                    }
                }
                else
                {
                    award = null;
                    InsertarSport();
                    InsertarEvent(award, price);
                    InsertarParticipant();
                    if (fafegir.checkBoxLot.Checked)
                    {
                        InsertarLot();
                        InsertarProductes();
                        InsertarOptions();
                    }


                }
                NetejarDadesAfegirActualitzar();
                products = new List<Product>();
                loadDataGrid();
                fafegir.Close();
                f.Show();
            }
        }

        void InsertarSport()
        {
            Sport sport = new Sport
            {
                SportId = 0,
                Name = fafegir.textBoxEsport.Text
            };

            Sport esport = Repositori.GetSportByName(fafegir.textBoxEsport.Text);

            if (esport.Name == null)
            {
                Repositori.InsSport(sport);
            }
        }

        void InsertarEvent(string award, double price)
        {

            Sport s = Repositori.GetSportByName(fafegir.textBoxEsport.Text);

            Event ev = new Event
            {
                EventId = 0,
                Name = fafegir.textBoxNom.Text,
                StartDate = fafegir.dateTimePickerInici.Value,
                EndDate = fafegir.dateTimePickerFinal.Value,
                Image = null,
                Description = fafegir.textBoxDescripcio.Text,
                MinAge = (int?)fafegir.numericUpDownEdatMinima.Value,
                MaxAge = (int?)fafegir.numericUpDownEdatMaxima.Value,
                MaxParticipantsNumber = (int?)fafegir.numericUpDownParticipants.Value,
                Price = price,
                Reward = award,
                UbicationId = 1,
                RecommendedLevelId = (fafegir.comboBoxNivell.SelectedItem as RecommendedLevel).RecommendedLevelId,
                SportId = s.SportId,
                Sport = s
            };
            Repositori.InsEvents(ev);   
        }

        void InsertarParticipant()
        {
            Event e = Repositori.GetEventMax();

            Participant p = new Participant
            {
                Organizer = true,
                EventId = e.EventId,
                UserDni = Repositori.usuari.Dni
            };
            Repositori.InsParticipant(p);
        }

        void InsertarLot()
        {
            Lot l = new Lot
            {
                LotId = 0,
                EventId = Repositori.GetEventMax().EventId
            };
            Repositori.InsLot(l);
        }

        void InsertarProductes()
        {
      
            foreach (Product s in products)
            {
                Product p = new Product
                {
                    ProductId = 0,
                    Name = s.Name,
                    LotId = Repositori.GetLotMax()
                };
                Repositori.InsProduct(p);
                
            }
        }

        void InsertarOptions()
        {

            foreach (Product s in products)
            {
                foreach (Option op in s.Options)
                {
                    Option o = new Option
                    {
                        OptionId = 0,
                        Name = op.Name,
                        ProductId = Repositori.GetProductsByLotIdAndName(Repositori.GetLotMax(), s.Name).ProductId
                    };
                    Repositori.InsOptions(o);
                }
            }
        }

        private void ButtonAfegirRsultat_Click(object sender, EventArgs e)
        {
            r.Close();
            f.Show();
        }

        private void ButtonResultats_Click(object sender, EventArgs e)
        {
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
            NetejarDadesLot();
            lot.ShowDialog();
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
            fafegir.dateTimePickerInici.Value = dataMin;
            fafegir.dateTimePickerFinal.Value = dataMin;
            fafegir.ShowDialog();

        }

        void loadDataGrid()
        {
            f.dataGridViewEvents.DataSource = Repositori.GetEventbyUserDNI(Repositori.usuari.Dni);
        }

        void NetejarDadesAfegirActualitzar()
        {
            fafegir.textBoxNom.Text = "";
            fafegir.textBoxLongitud.Text = "";
            fafegir.textBoxLatitud.Text = "";
            fafegir.textBoxEsport.Text = "";
            fafegir.textBoxDescripcio.Text = "";
            fafegir.numericUpDownEdatMaxima.Value = 0;
            fafegir.numericUpDownEdatMinima.Value = 0;
            fafegir.numericUpDownParticipants.Value = 0;
            fafegir.listBoxLot.Items.Clear();
            fafegir.checkBoxLot.Checked = false;
            fafegir.checkBoxPagament.Checked = false;
        }

        void NetejarDadesLot()
        {
            lot.textBoxNomProd.Text = "";
            lot.textBoxNomOpProd.Text = "";
            lot.checkBoxOpcio.Checked = false;
            lot.dataGridViewOpcions.DataSource = new List<ViewOption>();
        }
    }
}
