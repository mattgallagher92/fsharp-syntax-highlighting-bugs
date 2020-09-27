// FsharpSyntaxHighlightingBugs is white but should be teal.
namespace FsharpSyntaxHighlightingBugs

// Core is white but should be teal.
module Core =
    // f is light blue but should be light yellow.
    let f () = ()

// Dependent is white but should be teal.
module Dependent =
    // g is light blue but should be light yellow.
    let g () =
        // Putting `.f` on a new line breaks syntax highlighting in the file,
        // but compiles.
        //
        // When module and function names are long, and there is a bit more
        // nesting, splitting like this can be useful to keep lines short.
        //
        // Replacing the next two lines with `Core.f` fixes syntax highlighting.
        Core
            .f
