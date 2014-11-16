// Project Euler - Problem 7 10001st prime
// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
// What is the 10 001st prime number?

// Okay so we have a couple of options once it comes to prime number generation, let's start off with a simple bruteforce approach.

let primeNumbersBf n =
    let timer = System.Diagnostics.Stopwatch.StartNew()
    let isPrime n = 
          [2..int(sqrt (float n))]
          |> List.forall(fun x -> n % x <> 0)
  
    Seq.initInfinite id 
    |> Seq.filter isPrime 
    |> Seq.take n
    |> Seq.last
    |> printfn "Generated solution in %d ms, solution was: %d" timer.ElapsedMilliseconds

primeNumbersBf 10001

// Okay so bruteforcing approach took around 2,5seconds
