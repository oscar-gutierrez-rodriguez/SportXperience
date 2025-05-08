package com.example.sportxperience_android.Adapters

import android.app.Activity
import android.app.AlertDialog
import android.content.Context
import android.content.Intent
import android.util.Log
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import android.widget.TextView
import android.widget.Toast
import androidx.core.content.ContextCompat
import androidx.core.content.ContextCompat.startActivity
import androidx.recyclerview.widget.RecyclerView
import com.bumptech.glide.Glide
import com.example.sportxperience_android.ActivityRuta
import com.example.sportxperience_android.Api.CrudApi
import com.example.sportxperience_android.Api.Event
import com.example.sportxperience_android.Api.Participant
import com.example.sportxperience_android.Api.ParticipantOption
import com.example.sportxperience_android.FragmentsPrincipal.Events
import com.example.sportxperience_android.Login.user
import com.example.sportxperience_android.ParticiparEvent
import com.example.sportxperience_android.R
import com.example.sportxperience_android.eventParticipar
import com.example.sportxperience_android.ubicacioActual
import com.google.android.material.button.MaterialButton
import java.text.SimpleDateFormat
import java.util.Date
import java.util.Locale


class AdapterEventsParticipar(val llista: List<Event>, val context: Context) :
    RecyclerView.Adapter<AdapterEventsParticipar.ViewHolder>() {

    val urlApi = context.getString(R.string.ruta_api)

    class ViewHolder(val vista: View) : RecyclerView.ViewHolder(vista) {
        val imatge = vista.findViewById<ImageView>(R.id.imatgeEventPart_card)
        val nom = vista.findViewById<TextView>(R.id.nomEventPart_card)

        val poblacio = vista.findViewById<TextView>(R.id.poblacioEventPart_card)
        val dataInici = vista.findViewById<TextView>(R.id.dataIniciPart_card)
        val dataFinal = vista.findViewById<TextView>(R.id.dataFinalPart_card)
        val esport = vista.findViewById<TextView>(R.id.esportEventPart_card)

        val botoUbicacio = vista.findViewById<MaterialButton>(R.id.bt_ubicacio_card)
        val botoXat = vista.findViewById<MaterialButton>(R.id.bt_xat_card)
        val botoResultats = vista.findViewById<MaterialButton>(R.id.bt_resultats_card)
        val botoDesapuntarse = vista.findViewById<MaterialButton>(R.id.bt_desapuntarse_card)
    }


    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        val layout = LayoutInflater.from(parent.context)
        return ViewHolder(layout.inflate(R.layout.layout_events_participar, parent, false))
    }

    override fun getItemCount() = llista.size

    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        Glide.with(holder.imatge.context).load(urlApi + llista[position].image).into(holder.imatge)
        holder.nom.setText(llista[position].name)
        holder.poblacio.setText(llista[position].cityName)
        holder.dataInici.setText(formatISOToDate(llista[position].startDate))
        holder.dataFinal.setText(formatISOToDate("Data final: " + llista[position].endDate))
        holder.esport.setText(llista[position].sportName)

        holder.botoUbicacio.setOnClickListener {
            if(ubicacioActual != null) {
                eventParticipar = llista[position]
                val intent = Intent(context, ActivityRuta::class.java)
                context.startActivity(intent)
            } else{
                Toast.makeText(context, "No tens permís d'ubicació", Toast.LENGTH_SHORT).show()
            }
        }

        holder.botoXat.setOnClickListener {

        }

        holder.botoResultats.setOnClickListener {

        }

        holder.botoDesapuntarse.setOnClickListener {
            AlertDialog.Builder(context)
                .setTitle("Missatge")
                .setMessage("Segur que vols desapuntar-te d'aquest event?")
                .setPositiveButton("Acceptar") { dialog, wich ->

                    val api = CrudApi(context)

                    val participantOptions = api.getParticipantOptionByEventAndDni(llista[position].eventId, user!!.dni)

                    Toast.makeText(context, participantOptions!!.size.toString(), Toast.LENGTH_SHORT).show()

                    if(participantOptions != null) {
                        for (p in participantOptions) {
                            api.deleteParticipantOption(p.participantOptionId!!)
                        }
                    }


                    if(api.deleteParticipant(llista[position].eventId, user!!.dni) != null){
                        notifyDataSetChanged()
                        dialog.dismiss()
                    }
                }
                .setNegativeButton("Cancelar") { dialog, wich ->
                    dialog.dismiss()
                }
                .show()
        }
    }


    fun formatISOToDate(isoDate: String): String {
        val inputFormat = SimpleDateFormat("yyyy-MM-dd'T'HH:mm:ss", Locale.getDefault())
        val outputFormat = SimpleDateFormat("dd/MM/yyyy", Locale.getDefault())

        return try {
            val parsedDate = inputFormat.parse(isoDate)
            outputFormat.format(parsedDate ?: Date())
        } catch (e: Exception) {
            ""
        }
    }

}