# Fact 9add6bfd

Store id: 7a12984d-057a-47e0-9e02-b462bfd3c165

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
- posted_at: `2026-11-09T22:39:41.5554780+00:00`

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
  "id": "7a12984d-057a-47e0-9e02-b462bfd3c165",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5554780+00:00"
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
  "subject_id": "db743b5d-5234-4c95-9537-39528666f627",
  "subject_name": "django/db/models/expressions::TemporalSubtraction.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
