// Project Euler - Problem 5
// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

// A couple of generalizations can be made first to narrow this problem down a bit..
// All numbers are divisible by 1... So no need to check this
// This number cannot be a prime number since it has to be divisible by 1..20
// By extension this number cannot be an odd number because it has to be divisible evenly by 2 and no odd number is evenly divisible by 2
// Anything divisible by 20 will be divisible by the factors of 20, namely 2, 4, 5, 10

// Can this be solved by brute-forcing? Let's try that first
open System

let p5BruteForce =
    let timer = System.Diagnostics.Stopwatch.StartNew();
    let divisors = [20..-1..3]
    let isDivOneToTwenty n = divisors |> List.forall (fun x -> n % x = 0)

    let findNum n =
        let rec loop n = 
            match isDivOneToTwenty n with
            | true -> n
            | false -> loop (n + 2)
        loop n
    String.Format("Brute force method yielded: {0}, in {1}ms", (findNum 2520), timer.ElapsedMilliseconds)

// Brute-forcing yielded okay performance with a completion time of 2.5 - 3.0 seconds
// However using a "factorization" table yields far superior performance, finding the solution in 10ms
let p5TableMethod = 
    let timer = System.Diagnostics.Stopwatch.StartNew();
    let rec lcm nums header i =
        if List.forall((=)1) nums then List.reduce(fun acc elem -> acc * elem) header
        else 
            match List.filter (fun n -> n % i = 0) nums with
             | [] -> lcm nums header (i + 1)
             | factors -> 
                         let dividedNums = 
                             nums
                             |> List.filter (fun x -> not (List.exists ((=)x) factors))
                             |> List.append (List.map (fun y -> y / i) factors)
                         lcm dividedNums (i::header) i
    String.Format("Table method yielded: {0}, in {1}ms", (lcm [1..20] [] 2), timer.ElapsedMilliseconds)

p5BruteForce |> printf "%s\n"
p5TableMethod |> printf "%s\n"