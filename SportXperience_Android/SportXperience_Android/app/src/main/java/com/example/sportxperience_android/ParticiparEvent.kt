package com.example.sportxperience_android

import android.app.AlertDialog
import android.content.Intent
import android.os.Build
import android.os.Bundle
import android.view.View
import android.widget.LinearLayout
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.constraintlayout.widget.ConstraintLayout
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import androidx.recyclerview.widget.LinearLayoutManager
import com.bumptech.glide.Glide
import com.example.sportxperience_android.Adapters.AdapterEvents
import com.example.sportxperience_android.Adapters.AdapterProducts
import com.example.sportxperience_android.Api.CrudApi
import com.example.sportxperience_android.Api.Event
import com.example.sportxperience_android.Api.Participant
import com.example.sportxperience_android.Login.user
import com.example.sportxperience_android.databinding.ActivityParticiparEventBinding
import com.google.android.gms.maps.model.LatLng
import com.google.android.material.bottomsheet.BottomSheetBehavior
import com.google.android.material.dialog.MaterialAlertDialogBuilder

var eventParticipar : Event? = null
var numOpcions : Int = 0
class ParticiparEvent : AppCompatActivity() {

    lateinit var binding: ActivityParticiparEventBinding

    var event : Event? = null
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()

        binding = ActivityParticiparEventBinding.inflate(layoutInflater)

        setContentView(binding.root)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        numOpcions = 0


        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.TIRAMISU)
            event = intent.getParcelableExtra("event", Event::class.java)
        else
            event = intent.getParcelableExtra<Event>("event")

        eventParticipar = event!!

        binding.titolParticipar.setText(event!!.name)
        Glide.with(this).load(this.getString(R.string.ruta_api) + event!!.image).into(binding.imatgeParticipar)
        binding.descripcioParticipant.setText(event!!.description)
        binding.dada1.setText(event!!.recommendedLevelName)


        if(!event!!.reward.isNullOrEmpty()) {
            binding.dada2.setText(event!!.reward)
        } else{
            binding.dada2.setText("Sense premi")
        }

        binding.dada3.setText(event!!.minAge.toString() + " anys - " + event!!.maxAge.toString() + " anys")

        val api = CrudApi(this)

        val lot = api.getLotByEventId(event!!.eventId)

        if(lot != null){

            binding.noLot.visibility = View.INVISIBLE
            val productes = api.getProductsByLot(lot.lotId)

            if(productes != null) {

                val adapter = AdapterProducts(productes, this)

                binding.recyclerProducts.layoutManager = LinearLayoutManager(this)
                binding.recyclerProducts.adapter = adapter
            }

        } else{
            binding.noLot.visibility = View.VISIBLE
        }
        
        binding.creadorParticipant.setText(api.getUserByDni(api.getOrganizerByEvent(event!!.eventId)!!.userDni)!!.firstName)

        binding.btUbicacioParticipant.setOnClickListener{
            if(ubicacioActual != null) {
                val intent = Intent(this, ActivityRuta::class.java)
                startActivity(intent)
            } else{
                Toast.makeText(this, "No tens permís d'ubicació", Toast.LENGTH_SHORT).show()
            }
        }

        binding.btComentarisParticipant.setOnClickListener{
            val intent = Intent(this, ComentarisEvent::class.java)
            startActivity(intent)
        }


        binding.btParticipar.setOnClickListener {

            if(numOpcions == 0){

                val dialog = MaterialAlertDialogBuilder(this)
                    .setBackground(getDrawable(R.drawable.fons_dialegs))
                    .setIcon(this.getDrawable(R.drawable.baseline_sports_handball_24))
                    .setMessage("Aquest esdeveniment no té cap producte personalitzable. Vols apuntar-te a l'esdeveniment?")
                    .setTitle("Participació")
                    .setPositiveButton("Acceptar") { dialog, wich ->
                        val api = CrudApi(this)

                        data class Participant(
                            val event: Any,
                            val eventId: Int,
                            val organizer: Boolean,
                            val results: List<Any>,
                            val userDni: String,
                            val userDniNavigation: Any
                        )

                        val p = Participant(
                            null,
                            eventParticipar!!.eventId,
                            false,
                            null,
                            user!!.dni,
                            null
                        )

                        if (api.addParticipant(p) != null){
                            AlertDialog.Builder(this)
                                .setTitle("Missatge")
                                .setMessage("Ja ets participant d'aquest esdeveniment!")
                                .setPositiveButton("Acceptar") { dialog, _ -> dialog.dismiss() }
                                .show()
                        } else{
                            AlertDialog.Builder(this)
                                .setTitle("Missatge")
                                .setMessage("Es nulo")
                                .setPositiveButton("Acceptar") { dialog, _ -> dialog.dismiss() }
                                .show()
                        }

                    }
                    .setNegativeButton("Cancelar") { dialog, wich ->
                    }


                dialog.show()

            } else {
                val modal = ModalBottomSheetParticipar()
                modal.show(supportFragmentManager, "MyModalBottomSheet")
            }
        }


        binding.btTornar.setOnClickListener{
            onBackPressed()
        }


    }
}