# Fact 8522090a

Store id: e12d5d14-b7e9-44a1-9517-aaaa5ee1d561

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
- posted_at: `2026-11-09T22:39:47.5615560+00:00`

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
  "id": "e12d5d14-b7e9-44a1-9517-aaaa5ee1d561",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.5615560+00:00"
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
  "subject_id": "2a36b110-df83-46c3-8511-60bd92bb64d9",
  "subject_name": "django/db/models/functions/window::LagLeadFunction.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, offset=1, default=None, **extra)"
}
```
