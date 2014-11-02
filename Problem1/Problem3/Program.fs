let problem2 =
    let fibSeq = (1,1) |> Seq.unfold (fun (a, b) -> Some(a+b, (b, a+b)) )
    fibSeq
    |> Seq.takeWhile (fun x -> x <= 4000000)
    |> Seq.sumBy (fun x -> if x%2 = 0 then x else 0)