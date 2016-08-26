namespace Playground

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import

module Main =
    Node.require.Invoke("core-js") |> ignore
    let Helpers = Node.require.Invoke("Helpers")

    let mul2 = 
        Helpers ? give2() :?> int 
        |> Module.multiply

    let main () = 
        let message = mul2 7 |> sprintf "Hello from Fable (2 * 7 = %d)"
        let element = Browser.document.getElementById "main"
        element.innerText <- message
