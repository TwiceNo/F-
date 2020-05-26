<<<<<<< HEAD
﻿let rec pow x p r =
    match p with
    | 1 -> r
    | _ -> pow x (p - 1) r * x


let get_sum sum curr = (pow (curr % 10) 5 (curr % 10)) + sum 


let rec Fits sum num curr = 
    if curr = 0 then
        if sum = num then 1
        else 0
    else 
        if sum < num then
            Fits (get_sum sum curr) num ((curr - curr % 10) / 10)
        else 0
       

let rec Sum x sum = 
    if x < 1000000 then
        match Fits 0 x x with
        | 0 -> Sum (x + 1) sum
        | 1 -> Sum (x + 1) (sum + x)
    else sum


[<EntryPoint>]

let main argv = 

   
=======
﻿
[<EntryPoint>]

let main argv = 

    let rec pow x p r =
        match p with
        | 1 -> r
        | _ -> pow x (p - 1) r * x


    let get_sum sum curr = (pow (curr % 10) 5 (curr % 10)) + sum 


    let rec Fits sum num curr = 
        if curr = 0 then
            if sum = num then 1
            else 0
        else 
            if sum < num then
                Fits (get_sum sum curr) num ((curr - curr % 10) / 10)
            else 0
        

    let rec Sum x sum = 
        if x < 1000000 then
            match Fits 0 x x with
            | 0 -> Sum (x + 1) sum
            | 1 -> Sum (x + 1) (sum + x)
        else sum

>>>>>>> master

    System.Console.Write("Sum = ")
    System.Console.WriteLine(Sum 2 0)
    System.Console.WriteLine("\nPress any key")
    System.Console.ReadKey() |> ignore

    0