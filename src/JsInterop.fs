namespace Playground

open Fable.Core
open Fable.Import

module JsInterop =
    let inline loadModule name = 
        Node.require.Invoke(name)

module Option = 
    let def v o = defaultArg o v
    let alt a o = match o with | None -> a | _ -> o
