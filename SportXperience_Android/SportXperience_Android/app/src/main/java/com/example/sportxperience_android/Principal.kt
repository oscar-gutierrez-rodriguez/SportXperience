package com.example.sportxperience_android

import android.Manifest
import android.content.Intent
import android.content.pm.PackageManager
import android.location.Location
import android.os.Bundle
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.annotation.RequiresPermission
import androidx.appcompat.app.AppCompatActivity
import androidx.core.app.ActivityCompat
import androidx.core.content.ContextCompat
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import androidx.fragment.app.Fragment
import com.example.sportxperience_android.FragmentsPrincipal.Events
import com.example.sportxperience_android.FragmentsPrincipal.Inici
import com.example.sportxperience_android.FragmentsPrincipal.Participants
import com.example.sportxperience_android.FragmentsPrincipal.Resultats
import com.example.sportxperience_android.databinding.ActivityMainBinding
import com.example.sportxperience_android.databinding.ActivityPrincipalBinding
import com.google.android.gms.location.FusedLocationProviderClient
import com.google.android.gms.location.LocationServices
import com.google.android.gms.maps.CameraUpdateFactory
import com.google.android.gms.maps.model.LatLng

var ubicacioActual : LatLng? = null
class Principal : AppCompatActivity() {

    lateinit var binding: ActivityPrincipalBinding

    val inici = Inici()
    val events = Events()
    val participants = Participants()
    val resultats = Resultats()

    private lateinit var fusedLocationClient: FusedLocationProviderClient

    val REQUEST_LOCATION_CODE = 1
    var permisLocalitzacio = false


    @RequiresPermission(allOf = [Manifest.permission.ACCESS_FINE_LOCATION, Manifest.permission.ACCESS_COARSE_LOCATION])
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()

        binding = ActivityPrincipalBinding.inflate(layoutInflater)

        setContentView(binding.root)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, 0)
            insets
        }

        if (comprovarSiTenimElPermis()) {
            permisLocalitzacio = true

            fusedLocationClient = LocationServices.getFusedLocationProviderClient(this)

            fusedLocationClient.lastLocation
                .addOnSuccessListener { ubicacio: Location? ->
                    if (ubicacio != null) {
                        ubicacioActual = LatLng(ubicacio.latitude, ubicacio.longitude)
                    }
                }
        } else {
            demanarPermisos()
        }

        canviFragment(inici)

        binding.bnv1.setOnItemSelectedListener { item ->
            when(item.itemId){
                R.id.menu_inici -> {
                    canviFragment(inici)
                    true
                }
                R.id.menu_events -> {
                    canviFragment(events)
                    true
                }
                R.id.menu_participacions ->{
                    canviFragment(participants)
                    true
                }
                else -> {
                    canviFragment(resultats)
                    true
                }
            }
        }

    }

    fun canviFragment(frag: Fragment){
        val transaccio = supportFragmentManager.beginTransaction()
        transaccio.replace(R.id.fcv_principal, frag)
        transaccio.commit()
    }

    fun comprovarSiTenimElPermis(): Boolean {

        if (ContextCompat.checkSelfPermission(
                this,
                Manifest.permission.ACCESS_FINE_LOCATION
            ) == PackageManager.PERMISSION_GRANTED &&
            ContextCompat.checkSelfPermission(
                this,
                Manifest.permission.ACCESS_COARSE_LOCATION
            ) == PackageManager.PERMISSION_GRANTED
        ) {
            return true
        } else {
            return false
        }

    }


    fun demanarPermisos() {

        ActivityCompat.requestPermissions(
            this,
            arrayOf(
                Manifest.permission.ACCESS_FINE_LOCATION,
                Manifest.permission.ACCESS_COARSE_LOCATION
            ),
            REQUEST_LOCATION_CODE
        )

    }

    @RequiresPermission(allOf = [Manifest.permission.ACCESS_FINE_LOCATION, Manifest.permission.ACCESS_COARSE_LOCATION])
    override fun onRequestPermissionsResult(
        requestCode: Int,
        permissions: Array<out String>,
        grantResults: IntArray
    ) {
        super.onRequestPermissionsResult(requestCode, permissions, grantResults)
        if (requestCode == REQUEST_LOCATION_CODE) {
            if (grantResults.isNotEmpty() && grantResults[0] == PackageManager.PERMISSION_GRANTED) {
                permisLocalitzacio = true

                fusedLocationClient = LocationServices.getFusedLocationProviderClient(this)

                fusedLocationClient.lastLocation
                    .addOnSuccessListener { ubicacio: Location? ->
                        if (ubicacio != null) {
                            ubicacioActual = LatLng(ubicacio.latitude, ubicacio.longitude)
                        }
                    }
            }
        }
    }
}