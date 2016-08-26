namespace Playground

open Fable.Core
open Fable.Import

module JsInterop =
    let inline loadModule name = Node.require.Invoke(name)
