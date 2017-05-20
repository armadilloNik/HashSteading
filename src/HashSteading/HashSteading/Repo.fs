module Repo
    open System.IO

    let private path = @"c:\temp\HashSteading\"
    
    let private files = (path, "*.*", SearchOption.AllDirectories) |> Directory.EnumerateFiles

    let private listItem f = "<li>" + f + "</li>"
    let private htmlGen input = "<html><body><ul>" + input + "</ul></body></html>"

    let GetFileList = files
                    |> Seq.map listItem 
                    |> String.concat ""
                    |> htmlGen
