open System


[<EntryPoint>]
let main argv = 
  
   
    let token = Host.Start Repo.GetFileList


    Console.ReadKey true |> ignore
    
    token.Cancel()

    0 