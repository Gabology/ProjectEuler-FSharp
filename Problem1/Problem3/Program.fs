// Project Euler - Problem 3
// The prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143 ?
open System
open System.Diagnostics

let p3 () = 
    let rec primeFactors n i primes = 
        if i > n/2L then n::primes else
            let quotient, remainder = Math.DivRem(n, i)
            if remainder = 0L then primeFactors quotient 2L (i::primes)
            else primeFactors n (i + 1L) primes
    primeFactors 600851475143L 2L []

p3()
|> List.head
|> printf "The largest prime factor is: %d"