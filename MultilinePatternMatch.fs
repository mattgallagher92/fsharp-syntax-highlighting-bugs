namespace FsharpSyntaxHighlightingBugs

type Record =
    { X: string
      Y: int }

module Example =
    let f ({ X = x; Y = y }) =
        x + string y
