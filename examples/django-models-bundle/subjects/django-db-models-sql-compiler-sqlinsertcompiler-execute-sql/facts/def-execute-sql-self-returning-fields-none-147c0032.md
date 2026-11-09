# Fact 147c0032

Store id: bf83aa87-a58d-42cf-b213-532339dd0ee2

## Text

```text
def execute_sql(self, returning_fields=None)
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
- posted_at: `2026-11-09T22:39:50.7056090+00:00`

## Data

```json
{
  "end_line": 1988,
  "entity_kind": "method",
  "parent": "SQLInsertCompiler",
  "start_line": 1943,
  "symbol": "SQLInsertCompiler.execute_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1943,"selector":"L1943-L1988","symbol":"SQLInsertCompiler.execute_sql"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLInsertCompiler.execute_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1988,
    "entity_kind": "method",
    "parent": "SQLInsertCompiler",
    "start_line": 1943,
    "symbol": "SQLInsertCompiler.execute_sql"
  },
  "id": "bf83aa87-a58d-42cf-b213-532339dd0ee2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.7056090+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1943,
        "selector": "L1943-L1988",
        "symbol": "SQLInsertCompiler.execute_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "4b3e6b25-8494-4bf6-8f1d-9a98f1c70026",
  "subject_name": "django/db/models/sql/compiler::SQLInsertCompiler.execute_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def execute_sql(self, returning_fields=None)"
}
```
