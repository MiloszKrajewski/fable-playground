namespace Playground

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Playground.JsInterop

module Main =
    loadModule "core-js" |> ignore
    let Helpers = loadModule "Helpers"

    let mul2 = 
        Helpers ? give2() :?> int 
        |> Module.multiply

    let private range n = seq {
        let mutable i = 0
        while i < n do 
            yield i
            i <- i + 1
    }

    let main () = 
        let message = (range 5) |> Seq.sum |> mul2 |> sprintf "Hello from Fable (2 * (0+1+2+3+4) = %d)"
        let element = Browser.document.getElementById "main"
        element.innerText <- message
