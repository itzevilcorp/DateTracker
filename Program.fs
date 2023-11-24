type Cuisine = Korean | Turkish
type MovieType = Regular | IMAX | DBOX | RegularSnacks | IMAXSnacks | DBOXSnacks
type Activity =
    | Game | Chill | Movie of MovieType | EatOut of Cuisine | Drive of float * float

let rec budget activity =
    match activity with
    | Game | Chill -> 0.0
    | Movie m ->
        match m with
        | Regular -> 12.0
        | IMAX -> 17.0
        | DBOX | RegularSnacks | IMAXSnacks | DBOXSnacks -> budget (Movie Regular) + 5.0
    | EatOut c ->
        match c with
        | Korean -> 70.0
        | Turkish -> 65.0
    | Drive (km, fuel) -> km * fuel

let movieNight = Movie IMAXSnacks
let dinner = EatOut Korean
let roadTrip = Drive (100.0, 0.1)

printfn "Movie Night Cost: %f CAD" (budget movieNight)
printfn "Dinner Cost: %f CAD" (budget dinner)
printfn "Road Trip Cost: %f CAD" (budget roadTrip)

