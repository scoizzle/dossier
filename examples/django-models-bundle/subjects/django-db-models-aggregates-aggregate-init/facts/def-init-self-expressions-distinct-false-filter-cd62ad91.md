# Fact cd62ad91

Store id: 3ea00162-5f5b-4ce9-895c-913270c9bb9b

## Text

```text
def __init__( self, *expressions, distinct=False, filter=None, default=None, order_by=None, **extra, )
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
- posted_at: `2026-11-09T23:31:53.5316840+00:00`

## Data

```json
{
  "end_line": 106,
  "entity_kind": "method",
  "parent": "Aggregate",
  "start_line": 84,
  "symbol": "Aggregate.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":84,"selector":"L84-L106","symbol":"Aggregate.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Aggregate.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 106,
    "entity_kind": "method",
    "parent": "Aggregate",
    "start_line": 84,
    "symbol": "Aggregate.__init__"
  },
  "id": "3ea00162-5f5b-4ce9-895c-913270c9bb9b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5316840+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 84,
        "selector": "L84-L106",
        "symbol": "Aggregate.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "dc327e00-7626-4099-a612-fe28692974b7",
  "subject_name": "django/db/models/aggregates::Aggregate.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, *expressions, distinct=False, filter=None, default=None, order_by=None, **extra, )"
}
```
