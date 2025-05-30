package com.example.sportxperience_android.Login

import android.os.Bundle
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import androidx.fragment.app.Fragment
import com.example.sportxperience_android.R
import com.example.sportxperience_android.databinding.ActivityMainBinding

class Credencials : AppCompatActivity() {

    private lateinit var binding: ActivityMainBinding

    override fun onSaveInstanceState(outState: Bundle) {
        super.onSaveInstanceState(outState)
        val currentFragment = supportFragmentManager.findFragmentById(R.id.fcv1)
        currentFragment?.let {
            supportFragmentManager.putFragment(outState, "currentFragment", it)
        }
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.credencials)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        if (savedInstanceState != null) {
            val restoredFragment = supportFragmentManager.getFragment(savedInstanceState, "currentFragment")
            if (restoredFragment != null) {
                iniciarFragment(restoredFragment)
            }
        } else {
            iniciarFragment(IniciarSessio())
        }
    }

    private fun iniciarFragment(frag: Fragment) {
        val transaccio = supportFragmentManager.beginTransaction()
        transaccio.replace(R.id.fcv1, frag)
        transaccio.commit()
    }
}
