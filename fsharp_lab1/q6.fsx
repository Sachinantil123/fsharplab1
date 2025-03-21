// Define the list of strings
let names = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]

// Filter names that contain the letter "I" (case-insensitive)
let filteredNames = names |> List.filter (fun name -> name.ToLower().Contains("i"))

// Concatenate the filtered names using List.fold
let concatenatedNames = filteredNames |> List.fold (fun acc name -> acc + name) ""

// Print the result
printfn "Concatenated names containing the letter 'I': %s" concatenatedNames