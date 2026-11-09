# Fact 14adb631

Store id: db72c98e-226a-49e5-b37f-01ba6d9386c0

## Text

```text
def __init__(self, expression, nth=1, **extra)
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
- posted_at: `2026-11-09T22:39:47.5890420+00:00`

## Data

```json
{
  "end_line": 87,
  "entity_kind": "method",
  "parent": "NthValue",
  "start_line": 78,
  "symbol": "NthValue.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":78,"selector":"L78-L87","symbol":"NthValue.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::NthValue.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 87,
    "entity_kind": "method",
    "parent": "NthValue",
    "start_line": 78,
    "symbol": "NthValue.__init__"
  },
  "id": "db72c98e-226a-49e5-b37f-01ba6d9386c0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.5890420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 78,
        "selector": "L78-L87",
        "symbol": "NthValue.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "b7f1e1db-32ac-4879-be47-3bf0f92af09c",
  "subject_name": "django/db/models/functions/window::NthValue.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, nth=1, **extra)"
}
```
