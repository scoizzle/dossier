# Fact de8f6f91

Store id: 83e56d43-9beb-4e6e-9842-446c4ce154cb

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:31:55.9224530+00:00`

## Data

```json
{
  "end_line": 1482,
  "entity_kind": "method",
  "parent": "Ref",
  "start_line": 1481,
  "symbol": "Ref.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1481,"selector":"L1481-L1482","symbol":"Ref.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Ref.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1482,
    "entity_kind": "method",
    "parent": "Ref",
    "start_line": 1481,
    "symbol": "Ref.as_sql"
  },
  "id": "83e56d43-9beb-4e6e-9842-446c4ce154cb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9224530+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1481,
        "selector": "L1481-L1482",
        "symbol": "Ref.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "d5cdfb2b-25f6-4c97-8bc2-812a6c1ae1d0",
  "subject_name": "django/db/models/expressions::Ref.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
