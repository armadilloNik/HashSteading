open System


[<EntryPoint>]
let main argv = 
  
    let token = Host.Start
    Console.ReadKey true |> ignore
    
    token.Cancel()

    0 