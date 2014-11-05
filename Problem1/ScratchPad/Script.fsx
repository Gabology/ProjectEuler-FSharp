// Learn more about F# at http://fsharp.net. See the 'F# Tutorial' project
// for more guidance on F# programming.

#load "Library1.fs"
open ScratchPad

// Define your library scripting code here


// Project Euler - Problem 3
// The prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143 ?
open System
open System.Diagnostics

let problem3 () = 
    let rec primeFactors n i nums = 
        if i > n/2L then n::nums else 
            match Math.DivRem(n, i) with
            | (quotient, 0L) -> primeFactors quotient 2L (i::nums)
            | _ -> primeFactors n (i + 1L) nums
    primeFactors 140L 2L []

problem3()

let p3 () = 
    let rec primeFactors n i primes = 
        if i > n/2L then n::primes else
            let quotient, remainder = Math.DivRem(n, i)
            if remainder = 0L then primeFactors quotient 2L (i::primes)
            else primeFactors n (i + 1L) primes
    primeFactors 600851475143L 2L []

p3()
