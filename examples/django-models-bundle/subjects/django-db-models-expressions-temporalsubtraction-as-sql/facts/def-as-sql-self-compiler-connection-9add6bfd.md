# Fact 9add6bfd

Store id: cc4ce98f-b444-4134-a5d0-9859b9b778ed

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
- posted_at: `2026-11-09T23:31:55.8284160+00:00`

## Data

```json
{
  "end_line": 878,
  "entity_kind": "method",
  "parent": "TemporalSubtraction",
  "start_line": 872,
  "symbol": "TemporalSubtraction.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":872,"selector":"L872-L878","symbol":"TemporalSubtraction.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::TemporalSubtraction.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 878,
    "entity_kind": "method",
    "parent": "TemporalSubtraction",
    "start_line": 872,
    "symbol": "TemporalSubtraction.as_sql"
  },
  "id": "cc4ce98f-b444-4134-a5d0-9859b9b778ed",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8284160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 872,
        "selector": "L872-L878",
        "symbol": "TemporalSubtraction.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "332e788e-10f9-468a-a162-913b7e28c1ca",
  "subject_name": "django/db/models/expressions::TemporalSubtraction.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
