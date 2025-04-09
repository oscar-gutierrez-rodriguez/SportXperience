package com.example.sportxperience_android.Api

data class User(
    val `$id`: String?,
    val birthDate: String?,
    val dni: String,
    val firstName: String,
    val gender: Any?,
    val genderId: Int,
    val lastName: String,
    val mail: String,
    val messages: Messages?,
    val participants: Participants?,
    val password: String,
    val username: String
)


data class Gender(
    val `$id`: String,
    val genderId: Int,
    val name: String,
    val users: Users
)

data class Users(
    val `$id`: String,
    val `$values`: List<Any>
)

data class Participants(
    val `$id`: String,
    val `$values`: List<Any>
)

data class Messages(
    val `$id`: String,
    val `$values`: List<Any>
)

data class Event(
    val `$id`: String,
    val description: String,
    val endDate: String,
    val eventId: Int,
    val image: Any,
    val lots: Lots,
    val maxAge: Int,
    val maxParticipantsNumber: Int,
    val messages: Messages,
    val minAge: Int,
    val name: String,
    val participants: Participants,
    val price: Int,
    val recommendedLevel: RecommendedLevel,
    val recommendedLevelId: Int,
    val reward: String,
    val sport: Sport,
    val sportId: Int,
    val startDate: String,
    val ubication: Ubication,
    val ubicationId: Int
)

data class Events(
    val `$id`: String,
    val `$values`: List<ValueXX>
)

data class EventX(
    val `$ref`: String
)

data class Lots(
    val `$id`: String,
    val `$values`: List<Value>
)

data class Products(
    val `$id`: String,
    val `$values`: List<Any>
)

data class RecommendedLevel(
    val `$id`: String,
    val events: Events,
    val name: String,
    val recommendedLevelId: Int
)

data class Results(
    val `$id`: String,
    val `$values`: List<Any>
)

data class Sport(
    val `$id`: String,
    val events: Events,
    val name: String,
    val sportId: Int
)

data class Ubication(
    val `$id`: String,
    val cityName: String,
    val events: Events,
    val latitude: Double,
    val longitude: Double,
    val ubicationId: Int
)

data class Value(
    val `$id`: String,
    val event: EventX,
    val eventId: Int,
    val lotId: Int,
    val products: Products
)

data class ValueX(
    val `$id`: String,
    val event: EventX,
    val eventId: Int,
    val organizer: Boolean,
    val results: Results,
    val userDni: String,
    val userDniNavigation: Any
)

data class ValueXX(
    val `$ref`: String
)