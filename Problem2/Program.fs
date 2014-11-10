// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System

let rec fib n = match n with
                | 0 | 1 -> 1
                | _ -> fib (n - 1) + fib (n - 2)

let rec nOfFibTermsUpUntil x y = if fib (y + 1) < x then nOfFibTermsUpUntil x (y + 1) else y
                     
[for n in 0..nOfFibTermsUpUntil 4000000 0 -> fib n]
|> List.filter (fun x -> x % 2 = 0)
|> List.sum
|> printf "The sum of Fibonacci terms up until 4,000,000 is: %d"
Console.ReadKey () |> ignore