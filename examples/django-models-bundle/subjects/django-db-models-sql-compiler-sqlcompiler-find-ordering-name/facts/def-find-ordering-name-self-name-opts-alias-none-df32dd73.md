# Fact df32dd73

Store id: d7597e11-07e3-4615-83e7-14366708c23c

## Text

```text
def find_ordering_name( self, name, opts, alias=None, default_order="ASC", already_seen=None )
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
- posted_at: `2026-11-09T23:44:57.5295540+00:00`

## Data

```json
{
  "end_line": 1142,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 1079,
  "symbol": "SQLCompiler.find_ordering_name"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1079,"selector":"L1079-L1142","symbol":"SQLCompiler.find_ordering_name"}`

## Items

```json
[
  {
    "text": "Return the table alias (the name might be ambiguous, the alias will not be) and column name for ordering by the given 'name' parameter. The 'name' is of the form 'field1__field2__...__fieldN'.",
    "locator": {
      "line": 1082
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.find_ordering_name](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1142,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 1079,
    "symbol": "SQLCompiler.find_ordering_name"
  },
  "id": "d7597e11-07e3-4615-83e7-14366708c23c",
  "items": [
    {
      "locator": {
        "line": 1082
      },
      "text": "Return the table alias (the name might be ambiguous, the alias will not be) and column name for ordering by the given 'name' parameter. The 'name' is of the form 'field1__field2__...__fieldN'."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.5295540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1079,
        "selector": "L1079-L1142",
        "symbol": "SQLCompiler.find_ordering_name"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "40513733-5188-44c2-a59f-e7f23e211aa6",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.find_ordering_name",
  "tags": [
    "entity:method"
  ],
  "text": "def find_ordering_name( self, name, opts, alias=None, default_order=\"ASC\", already_seen=None )"
}
```
