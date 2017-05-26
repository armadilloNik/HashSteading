open System

[<EntryPoint>]
let main argv = 
  
    let path = @"c:\temp\HashSteading\"

    let token = path 
                |> Repo.GetFileList 
                |> Host.Start

    Console.ReadKey true |> ignore
    
    token.Cancel()

    0 