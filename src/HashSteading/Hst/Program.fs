open System


let prompt() =
    Console.Write ":>> " |> ignore
    let input = Console.ReadLine() 
    input

let rec parse items func =
    match items with
        | "exit"::tail -> ()
        | "repo"::tail -> parse tail func
        | "init"::tail -> tail 
                            |> List.head 
                            |> Repo.Create  
                            |> ignore
                          func()
        | "list"::tail -> Repo.PrintList() |> ignore
                          func()
        | "clear"::tail -> System.Console.Clear() |> ignore
                           func()
        | _ ->  printfn "Invalid Command"
                func()

let rec promptMonitor() =
    let input = prompt().ToLower()
    let items = input.Split ' ' |> Array.toList
    parse items promptMonitor
          

[<EntryPoint>]
let main argv = 
    
    promptMonitor()
    
    //let path = @"c:\temp\HashSteading\"

    //let token = path 
    //            |> Repo.GetFileList 
    //            |> Host.Start

    //Console.ReadKey true |> ignore
    
    //token.Cancel()

    0 