# Fact de8f6f91

Store id: f6fe30ac-1c69-45cf-b0fc-924168d695a7

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
- posted_at: `2026-11-09T22:39:41.6562250+00:00`

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
  "id": "f6fe30ac-1c69-45cf-b0fc-924168d695a7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6562250+00:00"
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
  "subject_id": "9d2c768a-ad64-4882-b11b-4cd75ac83a2e",
  "subject_name": "django/db/models/expressions::Ref.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
