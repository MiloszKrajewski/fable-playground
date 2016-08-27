namespace Playground

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Playground.JsInterop

module Main =
    let Helpers = loadModule "Helpers"

    let mul2 = 
        Helpers ? give2() :?> int 
        |> Module.multiply

    let main () = 
        let message = 
            [ for i = 0 to 6 do yield i ] |> Seq.sum |> mul2 
            |> sprintf "Hello from Fable (2 * (0+1+2+3+4) = %d)"
        let element = Browser.document.getElementById "main"
        element.innerText <- message
