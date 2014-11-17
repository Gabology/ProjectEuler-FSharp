open System

let squareSeq aSeq =
    let seqLength = aSeq |> Seq.length 
    for x in 0..seqLength do
        aSeq.[x] *= 2
