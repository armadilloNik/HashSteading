open System


let prompt() =
    Console.Write ":>> " |> ignore
    let input = Console.ReadLine() 
    input

let rec promptMonitor() =
    let input = prompt().ToLower()
    let items = input.Split ' ' |> Array.toList
    match items with
        | "exit"::tail -> ()
        | "repo"::tail -> Console.WriteLine "repo!"
                          promptMonitor()
        | _ -> promptMonitor()
          

[<EntryPoint>]
let main argv = 
    
    promptMonitor()
    

    Console.WriteLine "done!" |> ignore
    Console.ReadKey true |> ignore

    //let path = @"c:\temp\HashSteading\"

    //let token = path 
    //            |> Repo.GetFileList 
    //            |> Host.Start

    //Console.ReadKey true |> ignore
    
    //token.Cancel()

    0 