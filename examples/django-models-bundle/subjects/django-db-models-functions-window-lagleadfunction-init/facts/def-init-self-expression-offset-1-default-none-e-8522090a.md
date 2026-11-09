# Fact 8522090a

Store id: 224ce630-c6f1-448d-a12f-20fca49e49fb

## Text

```text
def __init__(self, expression, offset=1, default=None, **extra)
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
- posted_at: `2026-11-09T23:44:54.4685980+00:00`

## Data

```json
{
  "end_line": 53,
  "entity_kind": "method",
  "parent": "LagLeadFunction",
  "start_line": 40,
  "symbol": "LagLeadFunction.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":40,"selector":"L40-L53","symbol":"LagLeadFunction.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::LagLeadFunction.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 53,
    "entity_kind": "method",
    "parent": "LagLeadFunction",
    "start_line": 40,
    "symbol": "LagLeadFunction.__init__"
  },
  "id": "224ce630-c6f1-448d-a12f-20fca49e49fb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.4685980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 40,
        "selector": "L40-L53",
        "symbol": "LagLeadFunction.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "82f023f3-d662-4b0f-af33-5f49bfabe673",
  "subject_name": "django/db/models/functions/window::LagLeadFunction.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, offset=1, default=None, **extra)"
}
```
