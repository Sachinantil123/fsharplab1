// Define a list of strings with extra spaces
let names = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]

// Use the map function to trim spaces from each string
let trimmedNames = names |> List.map (fun name -> name.Trim())

// Print the trimmed names
printfn "Trimmed Names: %A" trimmedNames
