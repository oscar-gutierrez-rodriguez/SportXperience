using DesktopModels.Model;
using SportXperience.Model;
using SportXperience.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
        List<Product> Actuproducts = new List<Product>();
        List<Option> options = new List<Option>();
        Boolean afegir = false;
        OpenFileDialog archiu = new OpenFileDialog();

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
            var request = WebRequest.Create("http://172.16.24.191:5097/Images/logo.png");
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                f.pictureBoxLogo.Image = Image.FromStream(stream);
            }
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
            f.buttonEliminar.Click += ButtonEliminar_Click;
            lot.dataGridViewOpcions.CellClick += dataGridViewOpcions_CellClick;
            fafegir.buttonActualitzarProducte.Click += ButtonActualitzarProducte_Click;
            fafegir.listBoxLot.Click += ListBoxLot_Click;
        }

        private void ListBoxLot_Click(object sender, EventArgs e)
        {
            fafegir.buttonActualitzarProducte.Enabled = true;
        }

        private void ButtonActualitzarProducte_Click(object sender, EventArgs e)
        {
            int prod = fafegir.listBoxLot.SelectedIndex;
            Console.WriteLine(Actuproducts[prod].ProductId);

            if (prod >= 0) 
            {
                if (afegir)
                {
                    lot.textBoxNomProd.Text = products[prod].Name;
                    ActualitzarProductesGridOptions(products[prod].ProductId);
                }
                else
                {
                    lot.textBoxNomProd.Text = Actuproducts[prod].Name;
                    ActualitzarProductesGridOptions(Actuproducts[prod].ProductId);
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un producto.");
            }

            lot.ShowDialog();
        }

        private void dataGridViewOpcions_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string nombre = lot.dataGridViewOpcions.Rows[e.RowIndex].Cells["Name"].Value?.ToString();
            Option delete = null;

            foreach (Option o in options)
            {
                if (o.Name == nombre)
                {
                    delete = o;
                    break;
                }
            }

            if (delete != null)
            {
                MessageBox.Show("Segur que vols eliminar aquesta opció?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                options.Remove(delete);
                ActualitzarGridOptions();
            }

        }
        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Estàs segur que vols eliminar aquest event? ", "Eliminar Event", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Event ev = f.dataGridViewEvents.SelectedRows[0].DataBoundItem as Event;
                Repositori.DelEvent(ev);
                loadDataGrid();
            }
        }

        private void ButtonActualitzar_Click(object sender, EventArgs e)
        {
            NetejarDadesAfegirActualitzar();

            fafegir.listBoxLot.Items.Clear();
            Event ev = f.dataGridViewEvents.SelectedRows[0].DataBoundItem as Event;

            Lot l = Repositori.GetLotByEventId(ev.EventId);
            

            if (l != null) {

                products = Repositori.GetProductsByLotId(l.LotId);
            }
            else
            {
                products = new List<Product>();
            }
            fafegir.textBoxNom.Text = ev.Name;
            fafegir.textBoxDescripcio.Text = ev.Description;
            fafegir.textBoxPremi.Text = ev.Reward;
            fafegir.textBoxPreu.Text = ev.Price.ToString();
            fafegir.numericUpDownEdatMinima.Value = ev.MinAge.Value;
            fafegir.numericUpDownEdatMaxima.Value = ev.MaxAge.Value;
            fafegir.numericUpDownParticipants.Value = ev.MaxParticipantsNumber.Value;
            fafegir.comboBoxNivell.Text = Repositori.GetRecommendedLevelById(ev.RecommendedLevelId).Name;

            foreach (Product p in products)
            {
                fafegir.listBoxLot.Items.Add(p.Name);
                Actuproducts.Add(p);
            }

            fafegir.textBoxEsport.Text = Repositori.GetSportById(ev.SportId).Name;

            if (ev.Reward != null)
            {
                fafegir.checkBoxPagament.Checked = true;
            }
            else
            {
                fafegir.textBoxPreu.Text = "";
                fafegir.textBoxPremi.Text = "";
            }
            if (products.Count() != 0)
            {
                fafegir.checkBoxLot.Checked = true;
            }
            afegir = false;
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
                MessageBox.Show("No pots afegir una opcio sense el nom del producte.", "" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                if (lot.checkBoxOpcio.Checked)
                {
                    if (OpcioRepetit(lot.textBoxNomOpProd.Text))
                    {
                        MessageBox.Show("No pot haver opcions repetides", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (lot.dataGridViewOpcions.Columns.Contains("Eliminar"))
            {
                lot.dataGridViewOpcions.Columns.Remove("Eliminar");
            }
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Eliminar";
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "🗑";
            btnEliminar.UseColumnTextForButtonValue = true;
            btnEliminar.Width = 60;

            lot.dataGridViewOpcions.Columns.Add(btnEliminar);


        }

        private void ActualitzarProductesGridOptions(int ProductId)
        {
            List<ViewOption> viewOptions = new List<ViewOption>();

            viewOptions = Repositori.GetOptionsByProductId(ProductId).Select(x => new ViewOption(x.Name)).ToList();
            lot.dataGridViewOpcions.DataSource = viewOptions;

            if (lot.dataGridViewOpcions.Columns.Contains("Eliminar"))
            {
                lot.dataGridViewOpcions.Columns.Remove("Eliminar");
            }
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Eliminar";
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "🗑";
            btnEliminar.UseColumnTextForButtonValue = true;
            btnEliminar.Width = 60;

            lot.dataGridViewOpcions.Columns.Add(btnEliminar);


        }

        private void ButtonEliminarProducte_Click(object sender, EventArgs e)
        { 

            List<int> indices = fafegir.listBoxLot.SelectedIndices.Cast<int>().OrderByDescending(i => i).ToList();

            foreach (int index in indices)
            {
                fafegir.listBoxLot.Items.RemoveAt(index);
                if (afegir)
                {
                    products.RemoveAt(index);
                }
                else
                {
                    Actuproducts.RemoveAt(index);
                }
            }
        }
        private void ButtonImagen_Click(object sender, EventArgs e)
        {

            archiu = new OpenFileDialog();
            archiu.Title = "Imagenes";
            archiu.ShowHelp = true;
            if (archiu.ShowDialog() == DialogResult.OK)
            {
                fafegir.pictureBoxLogoEvent.Image = Image.FromFile(archiu.FileName);               
            }
            
        }


        private void ButtonAfegirProducte_Click1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lot.textBoxNomProd.Text))
            {
                MessageBox.Show("No pots afegir una opcio sense el nom del producte.","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ProducteRepetit(lot.textBoxNomProd.Text))
            {
                MessageBox.Show("No pot haver productes repetits", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Product p = new Product 
                { 
                    Name = lot.textBoxNomProd.Text,
                    Options = options
                };
                if (afegir)
                {
                    products.Add(p);
                }
                else
                {
                    Actuproducts.Add(p);
                }
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
                if (e.Name.ToLower() == opcions.ToLower())
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
                if (e.Name.ToLower() == productes.ToLower())
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
            if (afegir)
            {
                if (fafegir.numericUpDownEdatMinima.Value > fafegir.numericUpDownEdatMaxima.Value)
                {
                    MessageBox.Show("La edat màxima no potser inferior a " + fafegir.numericUpDownEdatMinima.Value.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fafegir.numericUpDownEdatMaxima.Value = fafegir.numericUpDownEdatMinima.Value;
                }
                else if (fafegir.numericUpDownParticipants.Value < 2)
                {
                    MessageBox.Show("Mínim ha d'haver 2 participants ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fafegir.numericUpDownParticipants.Value = 2;
                }
                else
                {

                    if (fafegir.checkBoxPagament.Checked)
                    {
                        if (Double.TryParse(fafegir.textBoxPreu.Text, out priceText))
                        {
                            if (!fafegir.textBoxPremi.Text.Equals(""))
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

                                NetejarDadesAfegirActualitzar();
                                products = new List<Product>();
                                loadDataGrid();
                                fafegir.Close();
                                f.Show();

                            }
                            else
                            {
                                MessageBox.Show("Si l'event és de pagament ha d'haver una recompensa pel guanyador", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            MessageBox.Show("El valor introduït no es vàlid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        NetejarDadesAfegirActualitzar();
                        products = new List<Product>();
                        loadDataGrid();
                        fafegir.Close();
                        f.Show();

                    }
                }
            }
            else
            {
                if (fafegir.numericUpDownEdatMinima.Value > fafegir.numericUpDownEdatMaxima.Value)
                {
                    MessageBox.Show("La edat màxima no potser inferior a " + fafegir.numericUpDownEdatMinima.Value.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fafegir.numericUpDownEdatMaxima.Value = fafegir.numericUpDownEdatMinima.Value;
                }
                else if (fafegir.numericUpDownParticipants.Value < 2)
                {
                    MessageBox.Show("Mínim ha d'haver 2 participants ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fafegir.numericUpDownParticipants.Value = 2;
                }
                else
                {
                    if (fafegir.checkBoxPagament.Checked)
                    {
                        if (Double.TryParse(fafegir.textBoxPreu.Text, out priceText))
                        {
                            if (!fafegir.textBoxPremi.Text.Equals(""))
                            {
                                award = fafegir.textBoxPremi.Text;
                                price = priceText;
                                UpdateEvent(award, price);
                                loadDataGrid();
                                fafegir.Close();
                                f.Show();
                            }
                            else
                            {
                                MessageBox.Show("Si l'event és de pagament ha d'haver una recompensa pel guanyador", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            MessageBox.Show("El valor introduït no es vàlid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {

                        UpdateEvent(award, price);
                        Actuproducts = new List<Product>();
                        loadDataGrid();
                        fafegir.Close();
                        f.Show();
                    }
                }

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

            string urlImage = null;

            if (!String.IsNullOrEmpty(archiu.FileName))
            {
                var task = Task.Run(async () =>
                {
                    return await Repositori.PostImageEvent(archiu.FileName);
                });

                urlImage = task.Result;
            }

            Event ev = new Event
            {
                EventId = 0,
                Name = fafegir.textBoxNom.Text,
                StartDate = fafegir.dateTimePickerInici.Value,
                EndDate = fafegir.dateTimePickerFinal.Value,
                Image = urlImage,  
                Description = fafegir.textBoxDescripcio.Text,
                MinAge = (int?)fafegir.numericUpDownEdatMinima.Value,
                MaxAge = (int?)fafegir.numericUpDownEdatMaxima.Value,
                MaxParticipantsNumber = (int?)fafegir.numericUpDownParticipants.Value,
                Price = price,
                Reward = award,
                UbicationId = 1,
                RecommendedLevelId = (fafegir.comboBoxNivell.SelectedItem as RecommendedLevel).RecommendedLevelId,
                SportId = s.SportId,
            };

            Repositori.InsEvents(ev);
        }


        void UpdateEvent(string award, double price)
        {
            Event evs = f.dataGridViewEvents.SelectedRows[0].DataBoundItem as Event;

            Lot l = Repositori.GetLotByEventId(evs.EventId);

            Sport s = Repositori.GetSportByName(fafegir.textBoxEsport.Text);
         
            Event ev = new Event
            {
                EventId = evs.EventId,
                Name = fafegir.textBoxNom.Text,
                StartDate = fafegir.dateTimePickerInici.Value,
                EndDate = fafegir.dateTimePickerFinal.Value,
                Image = evs.Image,
                Description = fafegir.textBoxDescripcio.Text,
                MinAge = (int?)fafegir.numericUpDownEdatMinima.Value,
                MaxAge = (int?)fafegir.numericUpDownEdatMaxima.Value,
                MaxParticipantsNumber = (int?)fafegir.numericUpDownParticipants.Value,
                Price = price,
                Reward = award,
                UbicationId = 1,
                RecommendedLevelId = (fafegir.comboBoxNivell.SelectedItem as RecommendedLevel).RecommendedLevelId,
                SportId = s.SportId,
            };
            
            if (fafegir.checkBoxLot.Checked)
            {
                if (l.LotId == 0)
                {
                    InsertarLot();
                }
            }
            Repositori.DelLot(l);
            InsertarActuProductes();
            InsertarActuOptions();
            Repositori.UpdEvent(ev);
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

        void InsertarActuProductes()
        {

            foreach (Product s in Actuproducts)
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
        void InsertarActuOptions()
        {

            foreach (Product s in Actuproducts)
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
                MessageBox.Show("La data final no pot ser inferior a " + fafegir.dateTimePickerInici.Value.ToString("dd/MM/yyyy"), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fafegir.dateTimePickerFinal.Value = fafegir.dateTimePickerInici.Value;
            }
        }

        private void DateTimePickerInici_ValueChanged(object sender, EventArgs e)
        {
            if (fafegir.dateTimePickerInici.Value < dataMin)
            {
                MessageBox.Show("La data de inici no pot ser inferior a " + dataMin.ToString("dd/MM/yyyy"), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                products = new List<Product>();
                options = new List<Option>();
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
            NetejarDadesAfegirActualitzar();
            fafegir.dateTimePickerInici.Value = dataMin;
            fafegir.dateTimePickerFinal.Value = dataMin;
            afegir = true;
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
            fafegir.textBoxPremi.Text = "";
            fafegir.textBoxPreu.Text = "";
            fafegir.numericUpDownEdatMaxima.Value = 0;
            fafegir.numericUpDownEdatMinima.Value = 0;
            fafegir.numericUpDownParticipants.Value = 0;
            fafegir.listBoxLot.Items.Clear();
            fafegir.checkBoxLot.Checked = false;
            fafegir.checkBoxPagament.Checked = false;
            fafegir.comboBoxNivell.SelectedIndex = 0;
            fafegir.pictureBoxLogoEvent.Image = null;
            
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
