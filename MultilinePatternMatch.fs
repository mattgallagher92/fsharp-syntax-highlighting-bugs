namespace FsharpSyntaxHighlightingBugs

type Record =
    { X: string
      Y: int }

// Example is white but should be teal.
module Example =
    // Putting `Y = y` on a new line breaks syntax highlighting in the file, but
    // compiles.
    //
    // When function names and/or record labels are long, it can be useful to do
    // this to keep lines short.
    //
    // Replacing the next two lines with `let f ({ X = x; Y = y}) =` fixes
    // syntax highlighting.
    //
    // f is light blue but should be light yellow.
    let f ({ X = x
             Y = y }) =
        // This line is all white, but x and y should be light blue and string
        // light yellow.
        x + string y
