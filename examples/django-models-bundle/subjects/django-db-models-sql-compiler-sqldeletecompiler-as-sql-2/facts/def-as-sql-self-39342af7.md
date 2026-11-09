# Fact 39342af7

Store id: bde0b270-34be-4371-bf99-0625be31d198

## Text

```text
def as_sql(self)
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
- posted_at: `2026-11-09T22:39:50.7250860+00:00`

## Data

```json
{
  "end_line": 2048,
  "entity_kind": "method",
  "parent": "SQLDeleteCompiler",
  "start_line": 2026,
  "symbol": "SQLDeleteCompiler.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2026,"selector":"L2026-L2048","symbol":"SQLDeleteCompiler.as_sql"}`

## Items

```json
[
  {
    "text": "Create the SQL for this query. Return the SQL string and list of parameters.",
    "locator": {
      "line": 2027
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLDeleteCompiler.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2048,
    "entity_kind": "method",
    "parent": "SQLDeleteCompiler",
    "start_line": 2026,
    "symbol": "SQLDeleteCompiler.as_sql"
  },
  "id": "bde0b270-34be-4371-bf99-0625be31d198",
  "items": [
    {
      "locator": {
        "line": 2027
      },
      "text": "Create the SQL for this query. Return the SQL string and list of parameters."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.7250860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2026,
        "selector": "L2026-L2048",
        "symbol": "SQLDeleteCompiler.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "f8ff851f-1498-48b5-a583-6f881afe97e4",
  "subject_name": "django/db/models/sql/compiler::SQLDeleteCompiler.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self)"
}
```
