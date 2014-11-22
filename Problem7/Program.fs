// Project Euler - Problem 7 10001st prime
// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
// What is the 10 001st prime number?

// Okay so we have a couple of options once it comes to prime number generation, let's start off with a simple bruteforce approach.
module Types =
    type Mark = Marked | Unmarked
    type Sieve = Sieve of Mark list

open Types
open System
open System.Collections.Generic

let p7BruteForce() =
    let timer = System.Diagnostics.Stopwatch.StartNew()
    let isPrime n = 
        if n = 0 || n = 1 then false else
            [2..int(sqrt (float n))] 
            |> List.forall(fun x -> n % x <> 0)
  
    //Seq.initInfinite id 
    seq { for x in 3..2..Int32.MaxValue do if isPrime x then yield x }
    |> Seq.append [2]
    |> Seq.nth (10001-1) // Since sequences are 0-indexed the 10001st prime will be at index 10001 - 1
    |> printfn "Generated solution in %d ms, solution was: %d" timer.ElapsedMilliseconds

// Okay so bruteforcing approach took around 1,5seconds
//p7BruteForce()
// 
//let p7SieveMethod =
//    let addComposites i composites = 
//        let factors = composites.[i]
//
//    let rec trackComposites i (compositeNums: Map<int, int list>) primes =
//        if compositeNums.ContainsKey i then 

//p7SieveMethod 
(*
    Let us first describe the original “by hand” sieve algorithm as practiced by Eratosthenes. 
    We start with a table of numbers (e.g., 2, 3, 4, 5, . . . ) and progressively cross off numbers in the table 
    until the only numbers left are primes. Specifically, we begin with the first number, p, in the table, and 
        
        1. Declare p to be prime, and cross off all the multiples of that number in the table, starting from p^2;
        2. Find the next number in the table after p that is not yet crossed off and set p to that number; and then repeat from step 1.
*)