# Fact 39b4d192

Store id: c553ddfc-59d6-4cf7-a382-42a92f7dfc4b

## Text

```text
def __init__(self, *expressions, **extra)
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
- posted_at: `2026-11-09T23:32:01.0044490+00:00`

## Data

```json
{
  "end_line": 158,
  "entity_kind": "method",
  "parent": "Least",
  "start_line": 155,
  "symbol": "Least.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":155,"selector":"L155-L158","symbol":"Least.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Least.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 158,
    "entity_kind": "method",
    "parent": "Least",
    "start_line": 155,
    "symbol": "Least.__init__"
  },
  "id": "c553ddfc-59d6-4cf7-a382-42a92f7dfc4b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.0044490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 155,
        "selector": "L155-L158",
        "symbol": "Least.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "5216265e-1d58-41dc-b378-d06d5c2a476b",
  "subject_name": "django/db/models/functions/comparison::Least.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *expressions, **extra)"
}
```
