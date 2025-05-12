using ApiSportXperience.Models;
using DesktopModels.Model;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MaterialSkin.Animations;
using Pabo.Calendar;
using SportXperience.Model;
using SportXperience.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GMap.NET.Entity.OpenStreetMapGraphHopperGeocodeEntity;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Result = SportXperience.Model.Result;

namespace SportXperience.Controller
{
    public class ControllerMain
    {
        Boolean actualitzarLot = true;
        Boolean botoAfegir = false;
        MainForm f = new MainForm();
        AfegirActualitzarForm fafegir = new AfegirActualitzarForm();
        LotForm lot = new LotForm();
        Resultats r = new Resultats();
        UbicacioForm ubi = new UbicacioForm();
        ProductesParticipantForm pr = new ProductesParticipantForm();
        DateTime dataMin = DateTime.Now.AddDays(2);
        List<Product> products = new List<Product>();
        List<Product> Actuproducts = new List<Product>();
        List<Option> options = new List<Option>();
        List<Option> Actuoptions = new List<Option>();
        List<ResultDTO> resultats = new List<ResultDTO>();
        Boolean afegir = false;
        OpenFileDialog archiu = new OpenFileDialog();
        Ubication ubication;
        EventDTO ev;
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        int filaSeleccionada = 0;
        double LatInici = 41.6018532;
        double LongInici = 2.2834753;
        private int? ubicationIdToSelect = null;
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
            var request = WebRequest.Create("http://172.16.24.191:5097/Images/SportXperience_logo.png");
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                f.pictureBoxLogo.Image = Image.FromStream(stream);
            }
            f.pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            f.pictureBoxLogo.Size = new Size(200, 200);
            fafegir.comboBoxNivell.DataSource = Repositori.GetRecommendedLevel();
            fafegir.comboBoxNivell.DisplayMember = "name";
            f.monthCalendarEvents.ActiveMonth.Month = DateTime.Now.Month;
            f.monthCalendarEvents.ActiveMonth.Year = DateTime.Now.Year;
            f.dataGridViewEvents.DataBindingComplete += (s, e) => Calendari();
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
            f.FormClosed += (s, e) => Application.Exit();
            fafegir.FormClosed += (s, e) => f.Show();
            lot.FormClosing += LotForm_FormClosing;
            fafegir.FormClosing += Fafegir_FormClosing;
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
            fafegir.CheckBoxIlimitat.CheckedChanged += CheckBoxIlimitat_CheckedChanged;
            fafegir.materialButtonUbi.Click += MaterialButtonUbi_Click;
            ubi.materialButtonAfegirUbi.Click += MaterialButtonAfegirUbi_Click;
            ubi.materialButtonConfirmarUbi.Click += MaterialButtonConfirmarUbi_Click;
            ubi.gMapControlUbi.DoubleClick += GMapControlUbi_DoubleClick;
            ubi.dataGridViewUbicacions.CellContentClick += DataGridViewUbicacions_CellContentClick;
            f.materialButtonProdPart.Click += MaterialButtonProdPart_Click;
            r.buttonAfegirPosicio.Click += ButtonAfegirPosicio_Click;
            r.buttonAfegirResultat.Click += ButtonAfegirResultat_Click;
            r.dataGridViewResultats.CellClick += DataGridViewResultats_CellClick;
        }

        private void Fafegir_FormClosing(object sender, FormClosingEventArgs e)
        {
            products = new List<Product>();
            Actuproducts = new List<Product>();
        }
        private void DataGridViewResultats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.RowIndex);
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                string nombre = r.dataGridViewResultats.Rows[e.RowIndex].Cells["Name"].Value?.ToString();
                ResultDTO deleteDto = null;
                Result delete = null;

                foreach (ResultDTO o in resultats)
                {
                    if (o.Name == nombre)
                    {
                        deleteDto = o;

                        delete = new Result
                        {
                            ResultId = o.ResultId,
                            UserDni = o.UserDni,
                            EventId = o.EventId,
                            Position = o.Position,
                        };
                        break;

                    }
                }

                if (delete != null)
                {
                    var result = MessageBox.Show("Segur que vols eliminar aquest resultat?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (delete.ResultId != 0)
                        {
                            Repositori.DelResultat(delete);
                        }
                        resultats.Remove(deleteDto);
                        ActualitzarGridResultats();
                    }
                }
            }
        }

        private void ButtonAfegirResultat_Click(object sender, EventArgs e)
        {
            List<Result> list = resultats.Select(x => new Result
            {
                ResultId = x.ResultId,
                EventId = x.EventId,
                Position = x.Position,
                UserDni = x.UserDni,
                Participant = null
            }).ToList();

            foreach (Result r in list)
            {
                if(r.ResultId == 0)
                {
                    InsertarResult();
                }
            }
            r.Close();
            f.Show();
        }

        void Calendari()
        {

            DateTime current;

            foreach (DataGridViewRow row in f.dataGridViewEvents.Rows)
            {
                var evento = row.DataBoundItem as EventDTO;

                DateTime start = evento.StartDate.Value;
                DateTime end = evento.EndDate.Value;
                current = start;

                while (current <= end)
                {
                    DateItem di = new DateItem
                    {
                        Date = current.Date,
                        BackColor1 = Color.FromArgb(196, 255, 186),
                    };

                    f.monthCalendarEvents.Dates.Add(di);
                    current = current.AddDays(1);
                }
            }

            if (f.dataGridViewEvents.Rows.Count > 0 && f.dataGridViewEvents.RowCount > 0)
            {
                if (f.dataGridViewEvents.SelectedRows.Count == 0 && f.dataGridViewEvents.Rows.Count > 0)
                {
                    ev = f.dataGridViewEvents.Rows[0].DataBoundItem as EventDTO;
                }
                else
                {
                    ev = f.dataGridViewEvents.SelectedRows[0].DataBoundItem as EventDTO;
                }

                List<DateTime> fechas = new List<DateTime>();
                current = (DateTime)ev.StartDate;
                f.monthCalendarEvents.ActiveMonth.Month = current.Month;
                f.monthCalendarEvents.ActiveMonth.Year = current.Year;
                while (current <= (DateTime)ev.EndDate)
                {
                    fechas.Add(current);
                    Console.WriteLine(current);
                    current = current.AddDays(1);
                }

                foreach (DateTime fecha in fechas)
                {
                    DateItem di = new DateItem
                    {
                        Date = fecha.Date,
                        BackColor1 = Color.FromArgb(0, 156, 80),
                    };

                    f.monthCalendarEvents.Dates.Add(di);
                }
                f.monthCalendarEvents.Refresh();
            }
            else
            {
                ev = null;
            }
        }

        private void MaterialButtonProdPart_Click(object sender, EventArgs e)
        {
            pr.dataGridViewProdPar.DataSource = Repositori.GetParticipantOptionsByEventId(ev.EventId);
            pr.dataGridViewProdPar.Columns["UserDni"].Visible = false;
            pr.dataGridViewProdPar.Columns["OptionId"].Visible = false;
            pr.dataGridViewProdPar.Columns["EventId"].Visible = false;
            pr.dataGridViewProdPar.Columns["ParticipantOptionId"].Visible = false;

            List<ParticipantOptionDTO> opcions = pr.dataGridViewProdPar.DataSource as List<ParticipantOptionDTO>;

            if (opcions == null)
            {
                MessageBox.Show("No s'han pogut obtenir les opcions dels participants.");
                return;
            }

            var totals = opcions
                .GroupBy(o => new { o.nomProducte, o.nomOpcio })
                .Select(g => new ViewTotalOption(g.Key.nomProducte, g.Key.nomOpcio, g.Count()))
                .ToList();

            pr.dataGridViewTotal.DataSource = totals;

            pr.ShowDialog();
        }

        private void DataGridViewUbicacions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;

            ubi.TextBoxLatitud.Text = ubi.dataGridViewUbicacions.Rows[filaSeleccionada].Cells[1].Value.ToString();
            ubi.TextBoxLongitud.Text = ubi.dataGridViewUbicacions.Rows[filaSeleccionada].Cells[2].Value.ToString();
            marker.Position = new GMap.NET.PointLatLng(Convert.ToDouble(ubi.TextBoxLatitud.Text), Convert.ToDouble(ubi.TextBoxLongitud.Text));

            ubi.gMapControlUbi.Position = marker.Position;
            marker.IsVisible = true;

            ubication = ubi.dataGridViewUbicacions.SelectedRows[0].DataBoundItem as Ubication;
        }

        private void GMapControlUbi_DoubleClick(object sender, EventArgs e)
        {
            double lat = ubi.gMapControlUbi.FromLocalToLatLng((e as MouseEventArgs).X, (e as MouseEventArgs).Y).Lat;
            double lng = ubi.gMapControlUbi.FromLocalToLatLng((e as MouseEventArgs).X, (e as MouseEventArgs).Y).Lng;

            ubi.TextBoxLatitud.Text = lat.ToString();
            ubi.TextBoxLongitud.Text = lng.ToString();
            marker.Position = new GMap.NET.PointLatLng(lat, lng);
            marker.ToolTipText = string.Format("Ubicació: \n Latitud: {0}\n Longitud: {1}", lat, lng);
            marker.IsVisible = true;
        }

        private void MaterialButtonConfirmarUbi_Click(object sender, EventArgs e)
        {
            ubication = ubi.dataGridViewUbicacions.SelectedRows[0].DataBoundItem as Ubication;
            fafegir.materialTextBoxNomCiutat.Text = ubication.CityName;
            ubi.Close();
        }

        private void MaterialButtonAfegirUbi_Click(object sender, EventArgs e)
        {
            InsertarUbicacions();
            ubi.dataGridViewUbicacions.DataSource = Repositori.GetUbicacions();
        }

        private void MaterialButtonUbi_Click(object sender, EventArgs e)
        {
            ubi.dataGridViewUbicacions.DataBindingComplete -= DataGridViewUbicacions_DataBindingComplete;
            List<Ubication> ubicacions = Repositori.GetUbicacions();
            ubi.dataGridViewUbicacions.DataSource = ubicacions;
            ubi.dataGridViewUbicacions.ClearSelection();
            ubi.dataGridViewUbicacions.Columns["UbicationId"].Visible = false;
            ubi.dataGridViewUbicacions.Columns["Events"].Visible = false;
            ubi.dataGridViewUbicacions.Columns["CityName"].Width = 200;
            ubi.dataGridViewUbicacions.Columns["CityName"].DisplayIndex = 0;

            if (!afegir)
            {
                ubicationIdToSelect = ev.UbicationId;
                var ubicacion = ubicacions.FirstOrDefault(u => u.UbicationId == ubicationIdToSelect);
                if (ubicacion != null)
                {
                    ubi.gMapControlUbi.Position = new GMap.NET.PointLatLng((double)ubicacion.Latitude, (double)ubicacion.Longitude);
                    marker = new GMarkerGoogle(new GMap.NET.PointLatLng((double)ubicacion.Latitude, (double)ubicacion.Longitude), GMarkerGoogleType.red);
                    ubi.gMapControlUbi.Zoom = 14;
                    marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    marker.ToolTipText = string.Format("Ubicació: \n Latitud: {0}\n Longitud: {1}", (double)ubicacion.Latitude, (double)ubicacion.Longitude);

                    ubi.gMapControlUbi.Overlays.Clear();

                    markerOverlay = new GMapOverlay("Marcador");
                    markerOverlay.Markers.Add(marker);
                    ubi.gMapControlUbi.Overlays.Add(markerOverlay);

                }
                ubi.dataGridViewUbicacions.DataBindingComplete += DataGridViewUbicacions_DataBindingComplete;


            }
            else
            {
                ubi.gMapControlUbi.Position = new GMap.NET.PointLatLng(LatInici, LongInici);
                ubi.gMapControlUbi.Overlays.Clear();

                markerOverlay = new GMapOverlay("Marcador");
                marker = new GMarkerGoogle(new GMap.NET.PointLatLng(LatInici, LongInici), GMarkerGoogleType.red);
                markerOverlay.Markers.Add(marker);

                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTipText = string.Format("Ubicació: \n Latitud: {0}\n Longitud: {1}", LatInici, LongInici);

                ubi.gMapControlUbi.Overlays.Add(markerOverlay);
                marker.IsVisible = false;
            }



            ubi.ShowDialog();
        }

        private void DataGridViewUbicacions_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (ubicationIdToSelect.HasValue)
            {
                foreach (DataGridViewRow row in ubi.dataGridViewUbicacions.Rows)
                {
                    if ((row.DataBoundItem as Ubication)?.UbicationId == ubicationIdToSelect)
                    {
                        row.Selected = true;
                        break;
                    }
                }
                ubicationIdToSelect = null;
            }
        }

        private void LotForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (botoAfegir == false)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {

                    MessageBox.Show("Per tancar la pestanya has de clickar en Afegir Producte.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
            
        }


        private void CheckBoxIlimitat_CheckedChanged(object sender, EventArgs e)
        {
            if (fafegir.CheckBoxIlimitat.Checked)
            {
                fafegir.numericUpDownParticipants.Enabled = false;
                fafegir.numericUpDownParticipants.Value = 0;
            }
            else
            {
                fafegir.numericUpDownParticipants.Enabled = true;
            }
        }

        private void ListBoxLot_Click(object sender, EventArgs e)
        {
            fafegir.buttonActualitzarProducte.Enabled = true;
        }

        private void ButtonActualitzarProducte_Click(object sender, EventArgs e)
        {
            if (actualitzarLot == false)
            {
                MessageBox.Show("No es poden actualitzar els productes d'un lot quan hi han participants inscrits.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                botoAfegir = false;

                int prod = fafegir.listBoxLot.SelectedIndex;

                if (prod >= 0)
                {
                    if (afegir)
                    {
                        lot.textBoxNomProd.Text = products[prod].Name;
                        ActualitzarProductesGridOptions(products[prod]);
                        Actuoptions.AddRange(products[prod].Options);
                        options = (List<Option>)products[prod].Options;
                        products.Remove(products[prod]);
                        lot.ShowDialog();
                    }
                    else
                    {
                        lot.textBoxNomProd.Text = Actuproducts[prod].Name;
                        ActualitzarProductesGridOptions(Actuproducts[prod]);
                        Actuoptions.AddRange(Actuproducts[prod].Options);
                        options = (List<Option>)Actuproducts[prod].Options;
                        Actuproducts.Remove(Actuproducts[prod]);
                        lot.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("Siusplau selecciona un producte.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void dataGridViewOpcions_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 1 && e.RowIndex > -1)
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
                    var result = MessageBox.Show("Segur que vols eliminar aquesta opció?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        options.Remove(delete);
                        ActualitzarGridOptions();
                    }

                }
            }
        }
        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Estàs segur que vols eliminar aquest event? ", "Eliminar Event", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                EventDTO ev = f.dataGridViewEvents.SelectedRows[0].DataBoundItem as EventDTO;

                Event evs = Repositori.GetEventById(ev.EventId);
                Repositori.DelEvent(evs);
                loadDataGrid();
            }
        }

        private void ButtonActualitzar_Click(object sender, EventArgs e)
        {
            NetejarDadesAfegirActualitzar();

            fafegir.listBoxLot.Items.Clear();
            ev = f.dataGridViewEvents.SelectedRows[0].DataBoundItem as EventDTO;

            if (ev.MaxParticipantsNumber == 0)
            {
                fafegir.CheckBoxIlimitat.Checked = true;
            }
            else
            {
                fafegir.CheckBoxIlimitat.Checked = false;
            }

            Lot l = Repositori.GetLotByEventId(ev.EventId);


            if (l != null)
            {

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
            ubi.TextBoxLatitud.Text = Repositori.GetUbicationById(ev.UbicationId).Latitude.ToString();
            ubi.TextBoxLongitud.Text = Repositori.GetUbicationById(ev.UbicationId).Longitude.ToString();
            fafegir.materialTextBoxNomCiutat.Text = ev.cityName;
            try
            {
                string imageUrl = "http://172.16.24.191:5097/" + ev.Image;
                using (WebClient client = new WebClient())
                {
                    byte[] imageBytes = client.DownloadData(imageUrl);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        fafegir.pictureBoxLogoEvent.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
            }



            foreach (Product p in products)
            {
                fafegir.listBoxLot.Items.Add(p.Name);
                p.Options = Repositori.GetOptionsByProductId(p.ProductId);
                Actuproducts.Add(p);

            }

            fafegir.textBoxEsport.Text = Repositori.GetSportById(ev.SportId).Name;

            if (!string.IsNullOrEmpty(ev.Reward))
            {
                fafegir.checkBoxPagament.Checked = true;
            }
            else
            {
                fafegir.checkBoxPagament.Checked = false;
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
            if (f.dataGridViewEvents.SelectedRows.Count == 0)
            {
                f.buttonEliminar.Enabled = false;
                f.buttonActualitzar.Enabled = false;
                f.buttonAfegir.Enabled = true;
            }
            else
            {
                f.monthCalendarEvents.Dates.Clear();
                Calendari();

                f.buttonEliminar.Enabled = true;
                f.buttonActualitzar.Enabled = true;
                f.buttonAfegir.Enabled = true;
            }

        }

        private void ButtonAfegirOpcio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lot.textBoxNomProd.Text))
            {
                MessageBox.Show("No pots afegir una opcio sense el nom del producte.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        private void ButtonAfegirPosicio_Click(object sender, EventArgs e)
        {

            if (r.numericUpDownPosicio.Value == 0)
            {
                MessageBox.Show("Cap participant pot tenir la posició 0.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ResultDTO re = new ResultDTO
                {
                    Name = r.comboBoxNomParticipant.Text,
                    Position = (int?)r.numericUpDownPosicio.Value,
                    EventId = ev.EventId,
                    UserDni = (r.comboBoxNomParticipant.SelectedItem as ParticipantDTO).UserDni
                };
                bool yaExiste = resultats.Any(x => x.UserDni == re.UserDni && x.EventId == ev.EventId);
                if (yaExiste)
                {
                    MessageBox.Show("Aquest participant ja té un resultat assignat.", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                resultats.Add(re);
                ActualitzarGridResultats();
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

        private void ActualitzarGridResultats()
        {
            List<ViewResultat> viewResultats = new List<ViewResultat>();

            viewResultats = resultats.Select(x => new ViewResultat(x.Name, x.Position)).ToList();
            r.dataGridViewResultats.DataSource = viewResultats;

            if (r.dataGridViewResultats.Columns.Contains("Eliminar"))
            {
                r.dataGridViewResultats.Columns.Remove("Eliminar");
            }
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Eliminar";
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "🗑";
            btnEliminar.UseColumnTextForButtonValue = true;
            btnEliminar.Width = 60;

            r.dataGridViewResultats.Columns.Add(btnEliminar);


        }

        private void ActualitzarProductesGridOptions(Product p)
        {
            List<ViewOption> viewOptions = new List<ViewOption>();

            viewOptions = p.Options.Select(x => new ViewOption(x.Name)).ToList();
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


            if (actualitzarLot == false)
            {
                MessageBox.Show("No es poden eliminar els productes d'un lot quan hi han participants inscrits.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
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

        private void AfegirProducte(){
            if (string.IsNullOrEmpty(lot.textBoxNomProd.Text))
            {
                MessageBox.Show("No pots afegir una opcio sense el nom del producte.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ProducteRepetit(lot.textBoxNomProd.Text))
            {
                MessageBox.Show("No pot haver productes repetits", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ActuProducteRepetit(lot.textBoxNomProd.Text))
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

                fafegir.listBoxLot.Items.Clear();
               
                if (afegir)
                {
                    foreach (Product pr in products)
                    {
                        fafegir.listBoxLot.Items.Add(pr.Name);
                    }
                }
                else
                {
                    foreach (Product pr in Actuproducts)
                    {
                        fafegir.listBoxLot.Items.Add(pr.Name);
                    }
                }
                options = new List<Option>();
                NetejarDadesLot();                
                
            }
        }

        private void ButtonAfegirProducte_Click1(object sender, EventArgs e)
        {
            botoAfegir = true;
            AfegirProducte();
            fafegir.Show();
            lot.Close();
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

        Boolean ActuProducteRepetit(string productes)
        {
            foreach (Product e in Actuproducts)
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
                else if (fafegir.numericUpDownParticipants.Value < 2 && !fafegir.CheckBoxIlimitat.Checked)
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
                                InsertarUbicacions();
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
                        InsertarUbicacions();
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
                else if (fafegir.numericUpDownParticipants.Value < 2 && !fafegir.CheckBoxIlimitat.Checked)
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
                                Actuproducts = new List<Product>();
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

                        UpdateEvent(award, price);
                        Actuproducts = new List<Product>();
                        products = new List<Product>();
                        loadDataGrid();
                        fafegir.Close();
                        f.Show();
                    }
                }

            }
            Actuproducts = new List<Product>();
            products = new List<Product>();

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

        private async void InsertarUbicacions()
        {
            double lat;
            double lng;


            if (double.TryParse(ubi.TextBoxLatitud.Text, out lat) &&
                double.TryParse(ubi.TextBoxLongitud.Text, out lng))
            {
              List<Ubicacio> u = await RepositoriUbicacions.GetUbicacio(lat, lng);

                if (u.Count > 0)
                {

                    Ubication ubi = new Ubication
                    {
                        UbicationId = 0,
                        Latitude = lat,
                        Longitude = lng,
                        CityName = u[0].NomPoblacio
                    };

                    Ubication ubicacio = Repositori.GetUbicationByLatitudLongitud(lat, lng);

                    if (ubicacio.Latitude == null && ubicacio.Longitude == null)
                    {
                        Repositori.InsUbication(ubi);
                    }
                }
                else
                {
                    MessageBox.Show("Aquesta població no és vàlida.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce valores válidos para latitud y longitud.");
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
            int numeroParticipants;

            if (fafegir.CheckBoxIlimitat.Checked)
            {
                numeroParticipants = 0;
            }
            else
            {
                numeroParticipants = (int)fafegir.numericUpDownParticipants.Value;
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
                    MaxParticipantsNumber = numeroParticipants,
                    Price = price,
                    Reward = award,
                    UbicationId = ubication.UbicationId,
                    RecommendedLevelId = (fafegir.comboBoxNivell.SelectedItem as RecommendedLevel).RecommendedLevelId,
                    SportId = s.SportId,
                };

            Repositori.InsEvents(ev);
        }


        void UpdateEvent(string award, double price)
        {
            EventDTO evs = f.dataGridViewEvents.SelectedRows[0].DataBoundItem as EventDTO;

            Lot l = Repositori.GetLotByEventId(evs.EventId);

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

            int numeroParticipants;

            if (fafegir.CheckBoxIlimitat.Checked)
            {
                numeroParticipants = 0;
            }
            else
            {
                numeroParticipants = (int)fafegir.numericUpDownParticipants.Value;
            }

            int ubicationId;
            if (ubication==null)
            {
                ubicationId = (int)evs.UbicationId;
            }
            else
            {
                ubicationId = ubication.UbicationId;
            }

                Event events = new Event
                {
                    EventId = evs.EventId,
                    Name = fafegir.textBoxNom.Text,
                    StartDate = fafegir.dateTimePickerInici.Value,
                    EndDate = fafegir.dateTimePickerFinal.Value,
                    Image = urlImage,
                    Description = fafegir.textBoxDescripcio.Text,
                    MinAge = (int?)fafegir.numericUpDownEdatMinima.Value,
                    MaxAge = (int?)fafegir.numericUpDownEdatMaxima.Value,
                    MaxParticipantsNumber = numeroParticipants,
                    Price = price,
                    Reward = award,
                    UbicationId = ubicationId,
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
            InsertarUbicacions();
            Repositori.DelLot(l);            
            InsertarActuProductes();
            InsertarActuOptions();
            Repositori.UpdEvent(events);
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
        void InsertarResult()
        {

            foreach (ResultDTO re in resultats)
            {
                Result r = new Result
                {
                    ResultId = 0,
                    Position = re.Position,
                    UserDni = re.UserDni,
                    EventId = re.EventId
                };
                Repositori.InsResultats(r);

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
                    LotId = Repositori.GetLotByEventId(ev.EventId).LotId
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
                        ProductId = Repositori.GetProductsByLotIdAndName(Repositori.GetLotByEventId(ev.EventId).LotId, s.Name).ProductId
                    };
                    Repositori.InsOptions(o);
                }
            }
        }

        private void ButtonResultats_Click(object sender, EventArgs e)
        {
            r.comboBoxNomParticipant.DataSource = Repositori.GetParticipantByEventId(ev.EventId);
            r.comboBoxNomParticipant.DisplayMember = "username";
            resultats = Repositori.GetResultByEventId(ev.EventId);

            ActualitzarGridResultats();


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

            if (actualitzarLot == false)
            {
                MessageBox.Show("No es poden afegir els productes d'un lot quan hi han participants inscrits.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                NetejarDadesLot();
                botoAfegir = false;
                lot.ShowDialog();
            }
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
            afegir = true;
            NetejarDadesAfegirActualitzar();
            fafegir.dateTimePickerInici.Value = dataMin;
            fafegir.dateTimePickerFinal.Value = dataMin;
            
            fafegir.ShowDialog();

        }

        void loadDataGrid()
        {
            List<EventDTO> events = new List<EventDTO>();
            events = Repositori.GetEventbyUserDNI(Repositori.usuari.Dni);
            f.dataGridViewEvents.DataSource = events;
            f.dataGridViewEvents.Columns["EventId"].Visible = false;
            f.dataGridViewEvents.Columns["Image"].Visible = false;
            f.dataGridViewEvents.Columns["Description"].Visible = false;
            f.dataGridViewEvents.Columns["UbicationId"].Visible = false;
            f.dataGridViewEvents.Columns["RecommendedLevelId"].Visible = false;
            f.dataGridViewEvents.Columns["SportId"].Visible = false;
            f.dataGridViewEvents.Columns["Latitude"].Visible = false;
            f.dataGridViewEvents.Columns["Longitude"].Visible = false;
        }

        void NetejarDadesAfegirActualitzar()
        {
            if(Repositori.GetParticipantByEventId(ev.EventId).Count() > 0 && !afegir)
            {
                actualitzarLot = false;
                fafegir.checkBoxLot.Checked = true;
                fafegir.checkBoxLot.Enabled = false;
                fafegir.checkBoxPagament.Checked = true;
                fafegir.checkBoxPagament.Enabled = false;
                fafegir.textBoxPremi.Enabled = false;
                fafegir.textBoxPreu.Enabled = false;

            }
            else
            {
                actualitzarLot = true;
                fafegir.checkBoxPagament.Checked = false;
                fafegir.checkBoxPagament.Enabled = true;
                fafegir.checkBoxLot.Enabled = true;
            }

            fafegir.textBoxNom.Text = "";
            ubi.TextBoxLongitud.Text = "";
            ubi.TextBoxLatitud.Text = "";
            fafegir.textBoxEsport.Text = "";
            fafegir.textBoxDescripcio.Text = "";
            fafegir.textBoxPremi.Text = "";
            fafegir.textBoxPreu.Text = "";
            fafegir.materialTextBoxNomCiutat.Text = "";
            fafegir.numericUpDownEdatMaxima.Value = 0;
            fafegir.numericUpDownEdatMinima.Value = 0;
            fafegir.numericUpDownParticipants.Value = 0;
            fafegir.listBoxLot.Items.Clear();
            fafegir.checkBoxLot.Checked = false;
            fafegir.comboBoxNivell.SelectedIndex = 0;
            fafegir.pictureBoxLogoEvent.Image = null;
            fafegir.CheckBoxIlimitat.Checked = false;
            
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
