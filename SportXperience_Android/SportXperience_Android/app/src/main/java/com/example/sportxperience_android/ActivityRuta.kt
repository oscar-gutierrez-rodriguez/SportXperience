package com.example.sportxperience_android

import android.Manifest
import android.location.Location
import android.os.Bundle
import androidx.activity.enableEdgeToEdge
import androidx.annotation.RequiresPermission
import androidx.appcompat.app.AppCompatActivity
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

        val mapFragment = supportFragmentManager
            .findFragmentById(R.id.rutes) as SupportMapFragment

        mapFragment.getMapAsync(this)

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
        val uDesti = LatLng(eventParticipar!!.latitude.toDouble(), eventParticipar!!.longitude.toDouble()
        )
        val central = LatLng(
            (uOrigen.latitude + uDesti.latitude) / 2,
            (uOrigen.longitude + uDesti.longitude) / 2
        )

        gmap!!.addMarker(
            MarkerOptions().position(uOrigen).title("Ubicació actual")
        )

        gmap!!.addMarker(
            MarkerOptions().position(uDesti).title(eventParticipar!!.name)
        )

        gmap!!.animateCamera(
            CameraUpdateFactory.newLatLngZoom(central, 8.0f), 3000, null
        )

        ApiCotxe(uOrigen, uDesti)
    }

    private fun drawRoute(map: GoogleMap, coordenades : Ruta){
        val polyLineOptions = PolylineOptions()
        coordenades.features[0].geometry.coordinates.forEach {
            polyLineOptions.add(LatLng(it[1], it[0]))
        }

        runOnUiThread{
            val ply = map.addPolyline(polyLineOptions)
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