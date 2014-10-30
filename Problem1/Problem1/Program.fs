// Project Euler - Problem 1
// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
// Find the sum of all the multiples of 3 or 5 below 1000.
#light

open System

let multiples = [for n in 1..1000 do if n % 3 = 0 || n % 5 = 0 then yield n]
let sum = List.sum multiples
printfn "The sum of all multiples are: %d" sum
ignore (Console.ReadKey ())