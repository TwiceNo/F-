[<EntryPoint>]

let main argv = 
   
    let max2 a b =
        if a > b then a
        else b

    System.Console.WriteLine("Max2")
    System.Console.Write("Max = ")
    System.Console.WriteLine(max2 78 8)

//------------------------------------

    let max3 x y z =
        if x > y then 
            if x > z then x
            else z
        else 
            if y > z then y
            else z

    System.Console.WriteLine("\nMax3")
    System.Console.Write("Max = ")
    System.Console.WriteLine(max3 78 16 121)

//--------------------------------------
   
    let rec fact_down f = 
        match f with
        | 0 -> 1
        | _ -> f * fact_down (f - 1)

    System.Console.WriteLine("\nFactorial")
    System.Console.Write("Factorial = ")
    System.Console.WriteLine(fact_down 5)

    //let fact_up a = 
    //    let rec fact_up n, x =
    //        match n with
    //        | a -> x * n
    //        | _ -> fact_up n + 1, x * n
    //    x

//-----------------------------------------

    let rec fib n = 
        match n with
        | 1 -> 1
        | 2 -> 1
        | _ -> fib (n - 1) + fib (n - 2)

    System.Console.WriteLine("\nFibonacci")
    System.Console.Write("Fibonacci = ")
    System.Console.WriteLine(fib 8)

//------------------------------------------

    let rec prime p i =
        if i <= p / 2 then
            match (p % i) with
            | 0 -> false
            | _ -> prime p (i + 1)
        else true

    System.Console.WriteLine("\nPrime")
    System.Console.WriteLine(prime 13)

//------------------------------------------

    let rec count i l = 
        if i = 1 then l
        else 
            if (i % 2 = 0) then count (i / 2) (l + 1)
            else count (3 * i + 1) (l + 1)


    let chain = 
        let mutable max_len = 0
        let mutable curr_len = 0
        let mutable num = 0
        for i in 2 .. 100 do
            curr_len <- count i 0
            if (curr_len > max_len) then 
                max_len <- curr_len
                num <- i
        num

    System.Console.WriteLine("\nMax chain: ")
    System.Console.WriteLine(chain)

//-------------------------------------------

    let rec sum n =
        match n with
        | 0 -> 0
        | _ -> (n % 10) + sum (n / 10)

    System.Console.WriteLine("\nSum: ")
    System.Console.WriteLine(sum 11123)

//------------------------------------------

    let rec max_divider x i = 
        if (x % i = 0) && (prime i 2) then i
        else max_divider x (i - 1)
                

    System.Console.WriteLine("\nMax divider: ")
    System.Console.WriteLine(max_divider 10 10)

//---------------------------------------------

    let rec nod a b i =
        if (a % i = 0) && (b % i = 0) then i
        else nod a b (i - 1)

    System.Console.WriteLine("\nNOD: ")
    System.Console.WriteLine(nod 118 21 21)

//---------------------------------------------

    System.Console.ReadKey()

    0