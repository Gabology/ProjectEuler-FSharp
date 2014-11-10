open System
open System.Linq

let p4 () = 
    let isPalindrome n = 
        let text = string n
        let rev = String.Concat(text.Reverse())
        text = rev

    seq { for x in 100..999 do 
           for y in 100..999 do if isPalindrome (x * y) then yield x * y }

p4() 
|> Seq.max
|> printfn "The highest palindrome as a product from two 3-digit factors is: %d"