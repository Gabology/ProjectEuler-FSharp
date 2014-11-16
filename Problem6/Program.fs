// Project Euler - Problem 6
// The sum of the squares of the first ten natural numbers is,
//                  1^2 + 2^2 + ... + 10^2 = 385
// The square of the sum of the first ten natural numbers is,
//              (1 + 2 + ... + 10)^2 = 55^2 = 3025
// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
open System

let sumOfSquares n = [for x in 1..n -> x * x] |> List.sum
let squareOfSum n = List.sum [1.0..float n] ** 2.0 |> int
let squareSumDifference n = (squareOfSum n) - (sumOfSquares n)
let problem6() = squareSumDifference 100

problem6() |> printfn "The difference between the sum of the squares of 100 and the square of the sum is: %d"