package com.example.sportxperience_android.Adapters

import android.content.Context
import android.util.Log
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import android.widget.TextView
import android.widget.Toast
import androidx.recyclerview.widget.RecyclerView
import com.bumptech.glide.Glide
import com.example.sportxperience_android.Api.Resultat
import com.example.sportxperience_android.R

class AdapterResults(val llista: List<Resultat>, val context: Context?) :
    RecyclerView.Adapter<AdapterResults.ViewHolder>() {

    val urlApi = context!!.getString(R.string.ruta_api)

    class ViewHolder(val vista: View) : RecyclerView.ViewHolder(vista) {
        val imatge = vista.findViewById<ImageView>(R.id.imatgeResultat_card)
        val medalla = vista.findViewById<ImageView>(R.id.medallaResultat_card)
        val nom = vista.findViewById<TextView>(R.id.nomResultat_card)
        val posicio = vista.findViewById<TextView>(R.id.posicioResultat_card)
        val missatge = vista.findViewById<TextView>(R.id.missatge_resultat_card)
    }


    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        val layout = LayoutInflater.from(parent.context)
        return ViewHolder(layout.inflate(R.layout.layout_resultats_usuari, parent, false))
    }

    override fun getItemCount() = llista.size

    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        Glide.with(holder.imatge.context).load(urlApi.toString() + llista[position].image).into(holder.imatge)
        holder.nom.setText(llista[position].name)
        holder.posicio.setText(llista[position].position.toString())


        when(llista[position].position){
            1 -> {
                holder.medalla.setImageResource(R.drawable.medallaoro)
                holder.missatge.setText("Enhorabona!")
                holder.posicio.setTextColor(context!!.resources.getColor(R.color.dorado))
            }
            2 -> {
                holder.medalla.setImageResource(R.drawable.medallaplata)
                holder.missatge.setText("Enhorabona!")
                holder.posicio.setTextColor(context!!.resources.getColor(R.color.plata))
            }
            3 -> {
                holder.medalla.setImageResource(R.drawable.medallabronce)
                holder.missatge.setText("Enhorabona!")
                holder.posicio.setTextColor(context!!.resources.getColor(R.color.bronce))
            }
            else -> {
                holder.medalla.setImageResource(R.drawable.coronalaurel)
                holder.missatge.setText("Segueix intentant-ho!")
            }
        }

        holder.vista.setOnClickListener {
            /*val intent = Intent(context, ParticiparEvent::class.java)
            context.startActivity(intent)*/
        }
    }


}