// Define a function to calculate the product of all elements in a list using tail recursion
let productOfList list =
    let rec loop acc remainingList =
        match remainingList with
        | [] -> acc // Base case: if the list is empty, return the accumulated product
        | head :: tail -> loop (acc * head) tail // Multiply the accumulator by the head and recurse with the tail
    loop 1 list // Initialize the accumulator to 1

// Test the function with a few examples
let testList1 = [1; 2; 3; 4; 5]
let testList2 = [10; 20; 30]
let testList3 = []

printfn "Product of testList1: %d" (productOfList testList1)
printfn "Product of testList2: %d" (productOfList testList2)
printfn "Product of testList3: %d" (productOfList testList3)