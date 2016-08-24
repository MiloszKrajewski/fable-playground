namespace Playground

open Fable.Core
open Fable.Import

module Main =
    Node.require.Invoke("core-js") |> ignore

    let mul2 = Module.multiply 2

    let main () = 
        mul2 7 |> printfn "2 * 7 = %d"

    main ()
