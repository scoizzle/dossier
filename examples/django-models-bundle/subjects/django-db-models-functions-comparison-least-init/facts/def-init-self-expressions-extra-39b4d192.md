# Fact 39b4d192

Store id: ebbb2de1-a86d-4990-a2b7-d514fe3b92fc

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
- posted_at: `2026-11-09T23:44:53.1809990+00:00`

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
  "id": "ebbb2de1-a86d-4990-a2b7-d514fe3b92fc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.1809990+00:00"
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
  "subject_id": "586c7f7e-6dc2-4668-9c60-59d657f5226d",
  "subject_name": "django/db/models/functions/comparison::Least.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *expressions, **extra)"
}
```
