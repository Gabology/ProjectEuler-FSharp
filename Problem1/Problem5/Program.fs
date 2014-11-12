// Project Euler - Problem 5
// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

// A couple of generalizations can be made first to narrow this problem down a bit..
// All numbers are divisible by 1... So no need to check this
// This number cannot be a prime number since it has to be divisible by 1..20
// By extension this number cannot be an odd number because it has to be divisible evenly by 2 and no odd number is evenly divisible by 2
// Anything divisible by 20 will be divisible by the factors of 20, namely 2, 4, 5, 10

// Can this be solved by brute-forcing? Let's try that first
let timer = System.Diagnostics.Stopwatch.StartNew();

let p5BruteForce =
    let divisors = [20..-1..3]
    let isDivOneToTwenty n = divisors |> List.forall (fun x -> n % x = 0)

    let findNum n =
        let rec loop n = 
            match isDivOneToTwenty n with
            | true -> n
            | false -> loop (n + 2)
        loop n
    findNum 2520

p5BruteForce |> printf "%d\n"
timer.ElapsedMilliseconds |> printf "Elapsed time %dms\n"