package com.example.sportxperience_android.Adapters

import android.content.Context
import android.content.Intent
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import android.widget.TextView
import android.widget.Toast
import androidx.core.content.ContextCompat
import androidx.recyclerview.widget.RecyclerView
import com.bumptech.glide.Glide
import com.example.sportxperience_android.Api.Event
import com.example.sportxperience_android.ParticiparEvent
import com.example.sportxperience_android.R
import java.text.SimpleDateFormat
import java.util.Date
import java.util.Locale

class AdapterEvents(val llista: List<Event>, val context: Context) :
    RecyclerView.Adapter<AdapterEvents.ViewHolder>() {

    val urlApi = context.getString(R.string.ruta_api)

    class ViewHolder(val vista: View) : RecyclerView.ViewHolder(vista) {
        val imatge = vista.findViewById<ImageView>(R.id.imatgeEvent_card)
        val nom = vista.findViewById<TextView>(R.id.nomEvent_card)

        val poblacio = vista.findViewById<TextView>(R.id.ciutatEvent_card)
        val data = vista.findViewById<TextView>(R.id.dataEvent_card)
        val esport = vista.findViewById<TextView>(R.id.esportEvent_card)
        val preu = vista.findViewById<TextView>(R.id.preuEvent_card)
        val placesLliures = vista.findViewById<TextView>(R.id.placesRestants_card)
    }


    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        val layout = LayoutInflater.from(parent.context)
        return ViewHolder(layout.inflate(R.layout.layout_event, parent, false))
    }

    override fun getItemCount() = llista.size

    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        Glide.with(holder.imatge.context).load(urlApi + llista[position].image).into(holder.imatge)
        holder.nom.setText(llista[position].name)
        holder.poblacio.setText(llista[position].cityName)
        holder.data.setText(formatISOToDate(llista[position].startDate) + " - " + formatISOToDate(llista[position].endDate))
        holder.esport.setText(llista[position].sportName)

        if (llista[position].price.toDouble() != 0.0) {
            holder.preu.text = "%.2f€".format(llista[position].price)

        } else {
            holder.preu.setText("Gratuït")
        }

        if(llista[position].maxParticipantsNumber == 0){
            holder.placesLliures.setTextColor(ContextCompat.getColor(context, android.R.color.black))
            holder.placesLliures.setText("Sense límit")
        } else {

            if(llista[position].placesValides <= 5){
                holder.placesLliures.setTextColor(ContextCompat.getColor(context, android.R.color.holo_red_light))
            } else if (llista[position].placesValides <= 20){
                holder.placesLliures.setTextColor(ContextCompat.getColor(context, android.R.color.holo_orange_light))
            } else{
                holder.placesLliures.setTextColor(ContextCompat.getColor(context, android.R.color.holo_green_light))
            }

            holder.placesLliures.setText("Places lliures: " + llista[position].placesValides)
        }

        holder.vista.setOnClickListener {
            val intent = Intent(context, ParticiparEvent::class.java)
            intent.putExtra("event", llista[position])
            context.startActivity(intent)
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