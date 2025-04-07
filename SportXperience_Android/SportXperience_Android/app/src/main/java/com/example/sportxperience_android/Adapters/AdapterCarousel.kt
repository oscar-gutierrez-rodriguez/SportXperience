package com.example.sportxperience_android.Adapters

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import androidx.recyclerview.widget.RecyclerView
import com.bumptech.glide.Glide
import com.example.sportxperience_android.R

class AdapterCarousel (val llista:List<String>): RecyclerView.Adapter<AdapterCarousel.ViewHolder>() {
    class ViewHolder (val vista: View): RecyclerView.ViewHolder(vista) {
        val imatge = vista.findViewById<ImageView>(R.id.infoImatge)
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        val layout = LayoutInflater.from(parent.context)
        return ViewHolder(layout.inflate(R.layout.layout_carousel, parent, false))
    }

    override fun getItemCount() = llista.size

    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        Glide.with(holder.imatge.context).load(llista[position]).into(holder.imatge)
    }
}