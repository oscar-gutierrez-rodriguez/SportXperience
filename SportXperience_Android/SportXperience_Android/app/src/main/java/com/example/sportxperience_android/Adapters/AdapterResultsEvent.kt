package com.example.sportxperience_android.Adapters

import android.content.Context
import android.graphics.Typeface
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import android.widget.TextView
import androidx.cardview.widget.CardView
import androidx.recyclerview.widget.RecyclerView
import com.bumptech.glide.Glide
import com.example.sportxperience_android.Api.Resultat
import com.example.sportxperience_android.Login.user
import com.example.sportxperience_android.R


class AdapterResultsEvent(val llista: List<Resultat>, val context: Context?) :
    RecyclerView.Adapter<AdapterResultsEvent.ViewHolder>() {

    val urlApi = context!!.getString(R.string.ruta_api)

    class ViewHolder(val vista: View) : RecyclerView.ViewHolder(vista) {
        val nom = vista.findViewById<TextView>(R.id.nomResultatParticipant_card)
        val posicio = vista.findViewById<TextView>(R.id.posicioResultatEvent_card)
        val card = vista.findViewById<CardView>(R.id.card_resultats_event)
    }


    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        val layout = LayoutInflater.from(parent.context)
        return ViewHolder(layout.inflate(R.layout.layout_resultat_event, parent, false))
    }

    override fun getItemCount() = llista.size

    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        holder.nom.setText(llista[position].name)
        holder.posicio.setText(llista[position].position.toString())

        when (llista[position].position) {
            1 ->holder.card.setCardBackgroundColor(context!!.resources.getColor(R.color.dorado))
            2 ->holder.card.setCardBackgroundColor(context!!.resources.getColor(R.color.plata))
            3 ->holder.card.setCardBackgroundColor(context!!.resources.getColor(R.color.bronce))
        }

        if (llista[position].userDni.equals(user!!.dni)){
            holder.nom.setTypeface(null, Typeface.BOLD)
        }
    }


}