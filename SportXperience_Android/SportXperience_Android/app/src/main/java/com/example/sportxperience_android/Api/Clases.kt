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
    val longitude: Float,
    val participant : Boolean,
    val organizer : Boolean,
    val placesValides : Int
) : Parcelable


data class Lot(
    val event: Any,
    val eventId: Int,
    val lotId: Int,
    val products: List<Any>
)

data class Participant(
    val event: Any?,
    val eventId: Int,
    val organizer: Boolean,
    val results: List<Any>?,
    val userDni: String,
    val userDniNavigation: Any?
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

data class Comment(
    val comment: String,
    val dniOrganizer: String,
    val messageId: Int,
    val publicMessage: Boolean,
    val publishedDate: String,
    val userDni: String
)

data class CommentPost(
    val comment: String,
    val event: Any?,
    val eventId: Int,
    val messageId: Int?,
    val publicMessage: Boolean,
    val publishedDate: String,
    val userDni: String,
    val userDniNavigation: Any?
)

data class ParticipantOption(
    val eventId: Int,
    val option: Any?,
    val optionId: Int,
    val participant: Any?,
    val participantOptionId: Int?,
    val userDni: String
)

data class RecommendedLevel(
    val events: List<Any>,
    val name: String,
    val recommendedLevelId: Int
)

data class Resultat(
    val eventId: Int,
    val name: String,
    val position: Int,
    val resultId: Int,
    val userDni: String,
    val image: String
)

data class ResultatNoDTO(
    val eventId: Int,
    val participant: Any,
    val position: Int,
    val resultId: Int,
    val userDni: String
)










data class Ruta(
    val bbox: List<Double>,
    val features: List<Feature>,
    val metadata: Metadata,
    val type: String
)

data class Engine(
    val build_date: String,
    val graph_date: String,
    val version: String
)

data class Feature(
    val bbox: List<Double>,
    val geometry: Geometry,
    val properties: Properties,
    val type: String
)

data class Geometry(
    val coordinates: List<List<Double>>,
    val type: String
)

data class Metadata(
    val attribution: String,
    val engine: Engine,
    val query: Query,
    val service: String,
    val timestamp: Long
)

data class Properties(
    val segments: List<Segment>,
    val summary: Summary,
    val way_points: List<Int>
)

data class Query(
    val coordinates: List<List<Double>>,
    val format: String,
    val profile: String,
    val profileName: String
)

data class Segment(
    val distance: Double,
    val duration: Double,
    val steps: List<Step>
)

data class Step(
    val distance: Double,
    val duration: Double,
    val instruction: String,
    val name: String,
    val type: Int,
    val way_points: List<Int>
)

data class Summary(
    val distance: Double,
    val duration: Double
)

