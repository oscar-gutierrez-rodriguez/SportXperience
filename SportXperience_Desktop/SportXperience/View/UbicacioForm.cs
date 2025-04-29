using DesktopModels.Model;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using SportXperience.Controller;
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
    public partial class UbicacioForm : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        double LatInici = 41.6018532;
        double LongInici = 2.2834753;
        int filaSeleccionada = 0;
        public UbicacioForm()
        {
            InitializeComponent();
        }

        private void UbicacioForm_Load(object sender, EventArgs e)
        {
            dataGridViewUbicacions.DataSource = Repositori.GetUbicacions();
            dataGridViewUbicacions.Columns["UbicationId"].Visible = false;
            dataGridViewUbicacions.Columns["Events"].Visible = false;
            dataGridViewUbicacions.Columns["CityName"].Width = 200;
            dataGridViewUbicacions.Columns["CityName"].DisplayIndex = 0;



            gMapControlUbi.DragButton = MouseButtons.Left;
            gMapControlUbi.CanDragMap = true;
            gMapControlUbi.MapProvider = GMapProviders.GoogleMap;
            gMapControlUbi.Position = new GMap.NET.PointLatLng(LatInici, LongInici);
            gMapControlUbi.MinZoom = 0;
            gMapControlUbi.MaxZoom = 24;
            gMapControlUbi.Zoom = 9;
            gMapControlUbi.AutoScroll = true;

            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new GMap.NET.PointLatLng(LatInici, LongInici), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(marker);

            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = string.Format("Ubicació: \n Latitud: {0}\n Longitud: {1}", LatInici, LongInici);

            gMapControlUbi.Overlays.Add(markerOverlay);
        }

        private void dataGridViewUbicacions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;

            TextBoxLatitud.Text = dataGridViewUbicacions.Rows[filaSeleccionada].Cells[1].Value.ToString();
            TextBoxLongitud.Text = dataGridViewUbicacions.Rows[filaSeleccionada].Cells[2].Value.ToString();

            marker.Position = new GMap.NET.PointLatLng(Convert.ToDouble(TextBoxLatitud.Text), Convert.ToDouble(TextBoxLongitud.Text));

            gMapControlUbi.Position = marker.Position;
        }

        private void gMapControlUbi_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            double lat = gMapControlUbi.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControlUbi.FromLocalToLatLng(e.X, e.Y).Lng;

            TextBoxLatitud.Text = lat.ToString();
            TextBoxLongitud.Text = lng.ToString();

            marker.Position = new GMap.NET.PointLatLng(lat, lng);
            marker.ToolTipText = string.Format("Ubicació: \n Latitud: {0}\n Longitud: {1}", lat, lng);

        }

        private void materialButtonAfegir_Click(object sender, EventArgs e)
        {
          
        }
    }
}
