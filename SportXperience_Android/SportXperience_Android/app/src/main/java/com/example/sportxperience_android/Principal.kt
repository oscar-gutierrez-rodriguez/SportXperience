package com.example.sportxperience_android

import android.os.Bundle
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import androidx.fragment.app.Fragment
import com.example.sportxperience_android.FragmentsPrincipal.Events
import com.example.sportxperience_android.FragmentsPrincipal.Inici
import com.example.sportxperience_android.FragmentsPrincipal.Participants
import com.example.sportxperience_android.FragmentsPrincipal.Resultats
import com.example.sportxperience_android.databinding.ActivityMainBinding
import com.example.sportxperience_android.databinding.ActivityPrincipalBinding

class Principal : AppCompatActivity() {

    lateinit var binding: ActivityPrincipalBinding

    val inici = Inici()
    val events = Events()
    val participants = Participants()
    val resultats = Resultats()

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
}