# Fact 1f9fb3bc

Store id: 646dda15-4563-446b-a6d6-f4bbd9dfb361

## Text

```text
def __init__(self, meta, app_label=None)
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
- posted_at: `2026-11-09T23:44:55.4573390+00:00`

## Data

```json
{
  "end_line": 170,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 115,
  "symbol": "Options.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":115,"selector":"L115-L170","symbol":"Options.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 170,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 115,
    "symbol": "Options.__init__"
  },
  "id": "646dda15-4563-446b-a6d6-f4bbd9dfb361",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.4573390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 115,
        "selector": "L115-L170",
        "symbol": "Options.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "47ae0901-5af9-4ed5-b709-d1a6ed5f3c9e",
  "subject_name": "django/db/models/options::Options.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, meta, app_label=None)"
}
```
