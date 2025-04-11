package com.example.sportxperience_android.Adapters

import android.content.Context
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import android.widget.TextView
import android.widget.Toast
import androidx.recyclerview.widget.RecyclerView
import com.bumptech.glide.Glide
import com.example.sportxperience_android.R

class AdapterEvents (val llista:List<Event>, val context: Context): RecyclerView.Adapter<AdapterEvents.ViewHolder>() {
    class ViewHolder (val vista: View): RecyclerView.ViewHolder(vista) {
        //val imatge = vista.findViewById<ImageView>(R.id.imatgeEvent_card)
        val nom = vista.findViewById<TextView>(R.id.nomEvent_card)
        //val poblacio = vista.findViewById<TextView>(R.id.nomEvent_card)
        val data = vista.findViewById<TextView>(R.id.dataEvent_card)
        val esport = vista.findViewById<TextView>(R.id.esportEvent_card)
        val preu = vista.findViewById<TextView>(R.id.preuEvent_card)
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        val layout = LayoutInflater.from(parent.context)
        return ViewHolder(layout.inflate(R.layout.layout_event, parent, false))
    }

    override fun getItemCount() = llista.size

    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        //Glide.with(holder.imatge.context).load(llista[position]).into(holder.imatge)
        holder.nom.setText(llista[position].name)
        holder.data.setText(llista[position].startDate)
        //holder.esport.setText(llista[position].sport.name)

        if(llista[position].price != 0){
            holder.preu.setText(llista[position].price.toString())
        } else{
            holder.preu.setText("Gratuït")
        }

        holder.vista.setOnClickListener{
            Toast.makeText(context, "Participar", Toast.LENGTH_SHORT).show()
        }
    }
}