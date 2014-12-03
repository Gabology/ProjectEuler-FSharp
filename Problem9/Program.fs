// Project Euler - Problem 9
// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
//                              a^2 + b^2 = c^2
// For example, 3^2 + 4^2 = 9 + 16 = 2^5 = 52.
// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
// Find the product abc.

// Well here's what we know
// a < b < c < 1000
// But to uphold the form of a pythagorean triplet this can be clarified further
// a^2 + b^2 = c^2

let problem9() = 
    let generateTriple m n =
        let (^) x y = int (float x ** float y)
        let a = (n^2) - (m^2)
        let b = 2*n*m
        let c = (n^2) + (m^2)
        (a,b,c)
    (1, 2)
    |> Seq.unfold (fun (m,n) -> 
                        let next = if (m + 1) < n then (m + 1, n) else (1, n + 1)
                        Some(generateTriple m n, next))
    |> Seq.find (fun (a,b,c) -> a + b + c = 1000)

