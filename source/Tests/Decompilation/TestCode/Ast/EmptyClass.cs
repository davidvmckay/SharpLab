public class C {
}

/* ast

[
  {
    "type": "node",
    "kind": "CompilationUnit",
    "range": "0-19",
    "children": [
      {
        "type": "node",
        "kind": "ClassDeclaration",
        "range": "0-19",
        "children": [
          {
            "type": "token",
            "kind": "PublicKeyword",
            "range": "0-7",
            "children": [
              {
                "type": "value",
                "value": "public",
                "range": "0-6"
              },
              {
                "type": "trivia",
                "kind": "WhitespaceTrivia",
                "range": "6-7",
                "value": " "
              }
            ]
          },
          {
            "type": "token",
            "kind": "ClassKeyword",
            "property": "Keyword",
            "range": "7-13",
            "children": [
              {
                "type": "value",
                "value": "class",
                "range": "7-12"
              },
              {
                "type": "trivia",
                "kind": "WhitespaceTrivia",
                "range": "12-13",
                "value": " "
              }
            ]
          },
          {
            "type": "token",
            "kind": "IdentifierToken",
            "property": "Identifier",
            "range": "13-15",
            "children": [
              {
                "type": "value",
                "value": "C",
                "range": "13-14"
              },
              {
                "type": "trivia",
                "kind": "WhitespaceTrivia",
                "range": "14-15",
                "value": " "
              }
            ]
          },
          {
            "type": "token",
            "kind": "OpenBraceToken",
            "property": "OpenBraceToken",
            "range": "15-18",
            "children": [
              {
                "type": "value",
                "value": "{",
                "range": "15-16"
              },
              {
                "type": "trivia",
                "kind": "EndOfLineTrivia",
                "range": "16-18",
                "value": "\r\n"
              }
            ]
          },
          {
            "type": "token",
            "kind": "CloseBraceToken",
            "property": "CloseBraceToken",
            "range": "18-19",
            "value": "}"
          }
        ]
      },
      {
        "type": "token",
        "kind": "EndOfFileToken",
        "property": "EndOfFileToken",
        "range": "19-19",
        "value": ""
      }
    ]
  }
]

*/