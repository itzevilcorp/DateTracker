type Cuisine = Korean | Turkish
type MovieType = Regular | IMAX | DBOX | RegularSnacks | IMAXSnacks | DBOXSnacks
type Activity =
    | Game | Chill | Movie of MovieType | EatOut of Cuisine | Drive of float * float