using DesktopModels.Model;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MaterialSkin.Controls;
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
    public partial class UbicacioForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        double LatInici = 41.6018532;
        double LongInici = 2.2834753;
        public UbicacioForm()
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

        private void UbicacioForm_Load(object sender, EventArgs e)
        {          
            gMapControlUbi.DragButton = MouseButtons.Left;
            gMapControlUbi.CanDragMap = true;
            gMapControlUbi.MapProvider = GMapProviders.GoogleMap;
            gMapControlUbi.Position = new GMap.NET.PointLatLng(LatInici, LongInici);
            gMapControlUbi.MinZoom = 5;
            gMapControlUbi.MaxZoom = 24;
            gMapControlUbi.Zoom = 9;
            gMapControlUbi.AutoScroll = true;

            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new GMap.NET.PointLatLng(LatInici, LongInici), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(marker);

            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = string.Format("Ubicació: \n Latitud: {0}\n Longitud: {1}", LatInici, LongInici);

            gMapControlUbi.Overlays.Add(markerOverlay);
            marker.IsVisible = false;

        }

        private void materialButtonAfegir_Click(object sender, EventArgs e)
        {
          
        }

        private void materialButtonSat_Click(object sender, EventArgs e)
        {
            gMapControlUbi.MapProvider = GMapProviders.GoogleSatelliteMap;
        }

        private void materialButtonOrg_Click(object sender, EventArgs e)
        {
            gMapControlUbi.MapProvider = GMapProviders.GoogleMap;

        }
    }
}
