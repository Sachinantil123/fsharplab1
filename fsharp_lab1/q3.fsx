// Define a function to calculate the product of all odd numbers from a given number to 1 using tail recursion
let productOfOdds n =
    let rec loop acc current =
        if current < 1 then acc // Base case: if the current number is less than 1, return the accumulated product
        else loop (acc * current) (current - 2) // Multiply the accumulator by the current number and decrement by 2
    loop 1 n // Initialize the accumulator to 1 and start with the given number

// Test the function with a few examples
let result1 = productOfOdds 11
let result2 = productOfOdds 7
let result3 = productOfOdds 1

printfn "Product of odd numbers from 11 to 1: %d" result1
printfn "Product of odd numbers from 7 to 1: %d" result2
printfn "Product of odd numbers from 1 to 1: %d" result3