namespace Playground

open Fable.Core
open Fable.Import

module Main =
    Node.require.Invoke("core-js") |> ignore

    let mul2 = Module.multiply 2

    let main () = 
        printfn "Main.main ()"
        let message = mul2 7 |> sprintf "2 * 7 = %d"
        let element = Browser.document.getElementById "main"
        element.innerText <- message

    main ()
