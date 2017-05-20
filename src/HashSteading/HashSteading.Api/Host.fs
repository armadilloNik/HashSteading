module Host 

    open System
    open System.Threading
    open Suave
    
    let Start content =
        let cts = new CancellationTokenSource()
        let conf = { defaultConfig with cancellationToken = cts.Token }
        let listening, server = startWebServerAsync conf (Successful.OK content)
        
        Async.Start(server, cts.Token)
        cts
