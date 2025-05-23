package com.example.sportxperience_android

import android.Manifest
import android.content.Intent
import android.graphics.Color
import android.location.Location
import android.net.Uri
import android.os.Bundle
import android.widget.PopupMenu
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.annotation.RequiresPermission
import androidx.appcompat.app.AppCompatActivity
import androidx.core.content.ContextCompat
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.example.sportxperience_android.Api.Ruta
import com.example.sportxperience_android.WebServiceRuta.ApiRutes
import com.example.sportxperience_android.databinding.ActivityRutaBinding
import com.google.android.gms.maps.CameraUpdateFactory
import com.google.android.gms.maps.GoogleMap
import com.google.android.gms.maps.OnMapReadyCallback
import com.google.android.gms.maps.SupportMapFragment
import com.google.android.gms.maps.model.LatLng
import com.google.android.gms.maps.model.MarkerOptions
import com.google.android.gms.maps.model.PolylineOptions
import com.leinardi.android.speeddial.SpeedDialActionItem
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.Job
import kotlinx.coroutines.launch
import java.math.RoundingMode
import kotlin.coroutines.CoroutineContext

class ActivityRuta : AppCompatActivity(), CoroutineScope, OnMapReadyCallback, GoogleMap.OnMyLocationClickListener,
    GoogleMap.OnMyLocationButtonClickListener {

    lateinit var binding: ActivityRutaBinding
    var gmap : GoogleMap? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()

        binding = ActivityRutaBinding.inflate(layoutInflater)

        setContentView(binding.root)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.rutes)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        binding.normal.isChecked = true

        val mapFragment = supportFragmentManager
            .findFragmentById(R.id.rutes) as SupportMapFragment

        mapFragment.getMapAsync { googleMap ->
            googleMap.mapType = GoogleMap.MAP_TYPE_NORMAL
        }

        mapFragment.getMapAsync(this)

        val speedDialView = binding.speedDial


        speedDialView.addActionItem(
            SpeedDialActionItem.Builder(R.id.opc_coche, R.drawable.baseline_directions_car_24)
                .setLabel("Cotxe")
                .create()
        )

        speedDialView.addActionItem(
            SpeedDialActionItem.Builder(R.id.opc_bici, R.drawable.baseline_pedal_bike_24)
                .setLabel("Bicicleta")
                .create()
        )

        speedDialView.addActionItem(
            SpeedDialActionItem.Builder(R.id.opc_caminar, R.drawable.baseline_directions_walk_24)
                .setLabel("Caminant")
                .create()
        )

        speedDialView.setOnActionSelectedListener { actionItem ->
            when (actionItem.id) {
                R.id.opc_coche -> {
                    abrirRuta("driving")
                    true
                }

                R.id.opc_bici -> {
                    abrirRuta("bicycling")
                    true
                }

                R.id.opc_caminar -> {
                    abrirRuta("walking")
                    true
                }

                else -> false
            }
        }


        binding.normal.setOnClickListener {
            gmap?.let { map ->
                val currentCamera = map.cameraPosition
                map.mapType = GoogleMap.MAP_TYPE_NORMAL
                map.moveCamera(CameraUpdateFactory.newCameraPosition(currentCamera))
            }
        }

        binding.satelit.setOnClickListener {
            gmap?.let { map ->
                val currentCamera = map.cameraPosition
                map.mapType = GoogleMap.MAP_TYPE_HYBRID
                map.moveCamera(CameraUpdateFactory.newCameraPosition(currentCamera))
            }
        }

    }


        fun abrirRuta(modo: String) {
        val latOrigen = ubicacioActual!!.latitude
        val lngOrigen = ubicacioActual!!.longitude
        val latDestino = eventParticipar!!.latitude.toDouble()
        val lngDestino = eventParticipar!!.longitude.toDouble()

        val uri = Uri.parse("https://www.google.com/maps/dir/?api=1&origin=$latOrigen,$lngOrigen&destination=$latDestino,$lngDestino&travelmode=$modo")
        val intent = Intent(Intent.ACTION_VIEW, uri)
        intent.setPackage("com.google.android.apps.maps")
        if (intent.resolveActivity(packageManager) != null) {
            startActivity(intent)
        } else {
            Toast.makeText(this, "Google Maps no està instal·lat!", Toast.LENGTH_SHORT).show()
        }
    }


    private var job = Job()

    override val coroutineContext: CoroutineContext
        get() = Dispatchers.Main + job

    @RequiresPermission(allOf = [Manifest.permission.ACCESS_FINE_LOCATION, Manifest.permission.ACCESS_COARSE_LOCATION])
    override fun onMapReady(p0: GoogleMap) {
        gmap = p0

        gmap!!.isMyLocationEnabled = true
        gmap!!.setOnMyLocationClickListener(this)
        gmap!!.setOnMyLocationButtonClickListener(this)

        val uOrigen = LatLng(ubicacioActual!!.latitude, ubicacioActual!!.longitude)
        val uDesti = LatLng(eventParticipar!!.latitude.toDouble(), eventParticipar!!.longitude.toDouble())

        val central = LatLng(
            (uOrigen.latitude + uDesti.latitude) / 2,
            (uOrigen.longitude + uDesti.longitude) / 2
        )

        val marcadorOrigen = gmap!!.addMarker(
            MarkerOptions().position(uOrigen).title("Ubicació actual")
        )
        marcadorOrigen?.showInfoWindow()


        gmap!!.addMarker(
            MarkerOptions().position(uDesti).title(eventParticipar!!.name)
        )

        gmap!!.animateCamera(
            CameraUpdateFactory.newLatLngZoom(central, 8.0f), 3000, null
        )

        ApiCotxe(uOrigen, uDesti)

    }


    private fun drawRoute(map: GoogleMap, coordenades: Ruta) {
        val polyLineOptions = PolylineOptions().apply {
            coordenades.features[0].geometry.coordinates.forEach {
                add(LatLng(it[1], it[0]))
            }
            color(Color.RED)
            width(8f)
            geodesic(true)
        }

        runOnUiThread {
            map.addPolyline(polyLineOptions)
        }
    }


    private fun ApiCotxe(uOrigen : LatLng, uDesti: LatLng){

        var resposta : Ruta? = null

        launch {
            val uOrigenString =
                uOrigen.longitude.toString() + "," + uOrigen.latitude.toString()

            val uDestiString =
                uDesti.longitude.toString() + "," + uDesti.latitude.toString()

            resposta = ApiRutes().getRutaCotxe(uOrigenString, uDestiString, this@ActivityRuta)
            if(resposta != null){
                drawRoute(gmap!!, resposta!!)
                val distancia = (resposta!!.features[0].properties.summary.distance / 1000)
                binding.tvDistancia.setText(round2Decimals(distancia).toString() + " Km")
            }
        }
    }

    fun round2Decimals(number: Double): Double {
        return number.toBigDecimal().setScale(2, RoundingMode.HALF_UP).toDouble()
    }

    override fun onMyLocationClick(p0: Location) {
    }

    override fun onMyLocationButtonClick(): Boolean {
        return false
    }


}