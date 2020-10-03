// Learn more about F# at http://fsharp.org

open System

let inline charToInt c = int c - int '0'

// 1-1 isbn
let isbnCheck isbn =
  let mutable sum = 0
  let mutable i = 1
  for x in (Seq.toList isbn |> List.map charToInt) do
    sum <- sum + x * i
    i <- i + 1
  sum

let pow left right =
  int64 ((double left) ** (double right))

let ( *** ) left right = pow left right

// problem 3-7
let fermatTheorem a b pList =
  for p in pList do
    printfn "a:%f b:%f p:%f => result mod p = %f" a b p ((double ((double (a + b)) ** p) - (a ** p) - (b ** p)) % (double p))

[<EntryPoint>]
let main argv =
  let isbn = "0691113211"
  printfn "isbn %s => %d" isbn (isbnCheck isbn)
  fermatTheorem (double 2) (double 3) ([2; 3; 5; 7; 11; 13] |> List.map double)
  0 // return an integer exit code
