# Fact bdd1f2e8

Store id: 8b26a31d-80d6-47ce-8f17-84455f0fc0eb

## Text

```text
def get_from_clause(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:05.7923290+00:00`

## Data

```json
{
  "end_line": 1191,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 1159,
  "symbol": "SQLCompiler.get_from_clause"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1159,"selector":"L1159-L1191","symbol":"SQLCompiler.get_from_clause"}`

## Items

```json
[
  {
    "text": "Return a list of strings that are joined together to go after the \"FROM\" part of the query, as well as a list any extra parameters that need to be included. Subclasses, can override this to create a from-clause via a \"select\".",
    "locator": {
      "line": 1160
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_from_clause](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1191,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 1159,
    "symbol": "SQLCompiler.get_from_clause"
  },
  "id": "8b26a31d-80d6-47ce-8f17-84455f0fc0eb",
  "items": [
    {
      "locator": {
        "line": 1160
      },
      "text": "Return a list of strings that are joined together to go after the \"FROM\" part of the query, as well as a list any extra parameters that need to be included. Subclasses, can override this to create a from-clause via a \"select\"."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.7923290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1159,
        "selector": "L1159-L1191",
        "symbol": "SQLCompiler.get_from_clause"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "71c4ac1e-e78e-4b1c-8629-e3fff5536d50",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_from_clause",
  "tags": [
    "entity:method"
  ],
  "text": "def get_from_clause(self)"
}
```
