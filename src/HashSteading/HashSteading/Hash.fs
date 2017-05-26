module Hash

open System.IO
open System.Security.Cryptography

let hash filePath =
    let result = using (File.OpenRead filePath) (SHA256.Create().ComputeHash) 
                |> System.Convert.ToBase64String
    (result, filePath)

