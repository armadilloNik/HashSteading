module Repo
    open System.IO

    let mutable private _repos = []

    let private files path = (path, "*.*", SearchOption.AllDirectories) |> Directory.EnumerateFiles

    let private hashItem (hsh, file) = hsh + " [" + file + "] "
    let private listItem f = "<li>" + f + "</li>"
    let private htmlGen input = "<html><body><ul>" + input + "</ul></body></html>"

    let GetFileList path = path
                        |> files
                        |> Seq.map Hash.hash
                        |> Seq.map hashItem
                        |> Seq.map listItem 
                        |> String.concat ""
                        |> htmlGen
    
    let Create name = printfn "Creating Repo: %s" name
                      _repos <- (name::_repos)

    let PrintList() = _repos 
                    |> List.iter (System.Console.WriteLine)
                    