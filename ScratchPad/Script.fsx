open System

let list1 = [4;8;16;32;64]
let list2 = [1;2;3;4;5;6;7;8;9;10]

list1
|> List.map((/) 2)

let evenList aList =
    match List.filter(fun x -> x % 2 = 0) aList with
    | [] -> []
    | evens -> evens