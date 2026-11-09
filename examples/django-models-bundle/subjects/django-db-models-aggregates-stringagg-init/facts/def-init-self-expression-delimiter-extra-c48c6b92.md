# Fact c48c6b92

Store id: 8b22ca90-f677-4fb2-93ab-8557685b08c4

## Text

```text
def __init__(self, expression, delimiter, **extra)
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
- posted_at: `2026-11-09T22:39:40.0475870+00:00`

## Data

```json
{
  "end_line": 381,
  "entity_kind": "method",
  "parent": "StringAgg",
  "start_line": 379,
  "symbol": "StringAgg.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":379,"selector":"L379-L381","symbol":"StringAgg.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::StringAgg.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 381,
    "entity_kind": "method",
    "parent": "StringAgg",
    "start_line": 379,
    "symbol": "StringAgg.__init__"
  },
  "id": "8b22ca90-f677-4fb2-93ab-8557685b08c4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0475870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 379,
        "selector": "L379-L381",
        "symbol": "StringAgg.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "6bc91374-6827-41f7-a739-454261a6b87c",
  "subject_name": "django/db/models/aggregates::StringAgg.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, delimiter, **extra)"
}
```
