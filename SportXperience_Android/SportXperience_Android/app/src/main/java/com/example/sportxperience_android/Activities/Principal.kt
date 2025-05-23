package com.example.sportxperience_android.Activities

import android.Manifest
import android.content.pm.PackageManager
import android.location.Location
import android.os.Bundle
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
import com.example.sportxperience_android.R
import com.example.sportxperience_android.databinding.ActivityPrincipalBinding
import com.google.android.gms.location.FusedLocationProviderClient
import com.google.android.gms.location.LocationServices
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

    companion object {
        const val SELECTED_ITEM_ID = "selectedItemId"
    }


    override fun onSaveInstanceState(outState: Bundle) {
        super.onSaveInstanceState(outState)
        val currentFragment = supportFragmentManager.findFragmentById(R.id.fcv_principal)
        currentFragment?.let {
            supportFragmentManager.putFragment(outState, "currentFragment", it)
        }
        outState.putInt(SELECTED_ITEM_ID, binding.bnv1.selectedItemId)
    }


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
            fusedLocationClient.lastLocation.addOnSuccessListener { ubicacio: Location? ->
                if (ubicacio != null) {
                    ubicacioActual = LatLng(ubicacio.latitude, ubicacio.longitude)
                }
            }
        } else {
            demanarPermisos()
        }

        if (savedInstanceState != null) {
            val fragment = supportFragmentManager.getFragment(savedInstanceState, "currentFragment")
            fragment?.let {
                supportFragmentManager.beginTransaction()
                    .replace(R.id.fcv_principal, it)
                    .commit()
            }
            val selectedItemId = savedInstanceState.getInt(SELECTED_ITEM_ID, R.id.menu_inici)
            binding.bnv1.selectedItemId = selectedItemId // <- Esto restaura el ítem visual
        } else {
            canviFragment(inici)
            binding.bnv1.selectedItemId = R.id.menu_inici
        }

        binding.bnv1.setOnItemSelectedListener { item ->
            when (item.itemId) {
                R.id.menu_inici -> {
                    canviFragment(inici)
                    true
                }
                R.id.menu_events -> {
                    canviFragment(events)
                    true
                }
                R.id.menu_participacions -> {
                    canviFragment(participants)
                    true
                }
                R.id.menu_resultats -> {
                    canviFragment(resultats)
                    true
                }
                else -> false
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