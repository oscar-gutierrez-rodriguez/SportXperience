package com.example.sportxperience_android.Api

import android.os.Parcelable
import kotlinx.parcelize.Parcelize

data class User(
    val birthDate: String,
    val dni: String,
    val firstName: String,
    val gender: Any?,
    val genderId: Int,
    val lastName: String,
    val mail: String,
    val messages: List<Any>?,
    val participants: List<Any>?,
    val password: String,
    val username: String
)


data class Gender(
    val genderId: Int,
    val name: String,
    val users: List<Any>
)

@Parcelize
data class Event(
    val cityName: String,
    val description: String,
    val endDate: String,
    val eventId: Int,
    val image: String?,
    val maxAge: Int,
    val maxParticipantsNumber: Int,
    val minAge: Int,
    val name: String,
    val price: Float,
    val recommendedLevelId: Int,
    val recommendedLevelName: String,
    val reward: String?,
    val sportId: Int,
    val sportName: String,
    val startDate: String,
    val ubicationId: Int,
    val latitude: Float,
    val longitude: Float
) : Parcelable


data class Lot(
    val event: Any,
    val eventId: Int,
    val lotId: Int,
    val products: List<Any>
)

data class Participant(
    val event: Any,
    val eventId: Int,
    val organizer: Boolean,
    val results: List<Any>,
    val userDni: String,
    val userDniNavigation: Any
)

data class Product(
    val lot: Any,
    val lotId: Int,
    val name: String,
    val options: List<Any>,
    val productId: Int
)

data class Option(
    val name: String,
    val optionId: Int,
    val product: Any,
    val productId: Int
)