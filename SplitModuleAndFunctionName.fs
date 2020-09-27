namespace FsharpSyntaxHighlightingBugs

module Core =
    let f () = ()

module Dependent =
    let g () =
        Core.f
