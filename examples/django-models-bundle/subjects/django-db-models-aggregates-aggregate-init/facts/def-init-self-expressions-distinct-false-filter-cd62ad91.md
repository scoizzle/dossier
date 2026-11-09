# Fact cd62ad91

Store id: 4285a7a5-ecfd-4071-8ad9-06b2e7756df5

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
- posted_at: `2026-11-09T23:44:48.3949780+00:00`

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
  "id": "4285a7a5-ecfd-4071-8ad9-06b2e7756df5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.3949780+00:00"
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
  "subject_id": "112d75e6-c167-4cea-a42e-79e04fb49e7a",
  "subject_name": "django/db/models/aggregates::Aggregate.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, *expressions, distinct=False, filter=None, default=None, order_by=None, **extra, )"
}
```
