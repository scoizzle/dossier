# Fact 986dc08d

Store id: 3c208033-f82a-4921-aaac-f287ed863901

## Text

```text
def field_as_sql(self, field, get_placeholder_sql, val)
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
- posted_at: `2026-11-09T23:32:05.9454900+00:00`

## Data

```json
{
  "end_line": 1736,
  "entity_kind": "method",
  "parent": "SQLInsertCompiler",
  "start_line": 1705,
  "symbol": "SQLInsertCompiler.field_as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1705,"selector":"L1705-L1736","symbol":"SQLInsertCompiler.field_as_sql"}`

## Items

```json
[
  {
    "text": "Take a field and a value intended to be saved on that field, and return placeholder SQL and accompanying params. Check for raw values, fields with get_placeholder_sql(), and compilable defined in that order.",
    "locator": {
      "line": 1706
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLInsertCompiler.field_as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1736,
    "entity_kind": "method",
    "parent": "SQLInsertCompiler",
    "start_line": 1705,
    "symbol": "SQLInsertCompiler.field_as_sql"
  },
  "id": "3c208033-f82a-4921-aaac-f287ed863901",
  "items": [
    {
      "locator": {
        "line": 1706
      },
      "text": "Take a field and a value intended to be saved on that field, and return placeholder SQL and accompanying params. Check for raw values, fields with get_placeholder_sql(), and compilable defined in that order."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.9454900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1705,
        "selector": "L1705-L1736",
        "symbol": "SQLInsertCompiler.field_as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "d226e75a-5c58-482a-9119-ef0c9077e4f2",
  "subject_name": "django/db/models/sql/compiler::SQLInsertCompiler.field_as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def field_as_sql(self, field, get_placeholder_sql, val)"
}
```
