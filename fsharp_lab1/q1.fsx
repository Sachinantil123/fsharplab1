// Define a function that takes two parameters: exponent and value
let power exponent value = 
    value ** float exponent

// Use partial application to create square and cube functions
let square = power 2
let cube = power 3

// Invoke the square and cube functions with a few values and print the results
printfn "Square of 5: %f" (square 5.0)
printfn "Square of 10: %f" (square 10.0)
printfn "Cube of 2: %f" (cube 2.0)
printfn "Cube of 3: %f" (cube 3.0)