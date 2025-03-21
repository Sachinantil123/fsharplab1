// Create a sequence of the first 700 positive integers
let numbers = seq { 1 .. 700 }

// Convert the sequence into a list
let numberList = numbers |> Seq.toList

// Filter out elements that are multiples of both 7 and 5
let filteredNumbers = numberList |> List.filter (fun x -> x % 7 = 0 && x % 5 = 0)

// Sum all= the filtered numbers using List.fold
let sumOfFilteredNumbers = filteredNumbers |> List.fold (+) 0

// Print the result
printfn "Sum of numbers that are multiples of both 7 and 5: %d" sumOfFilteredNumbers