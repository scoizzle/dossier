# Fact 1f9fb3bc

Store id: fe6e927f-2de4-4034-938a-3766c057f2d4

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
- posted_at: `2026-11-09T23:32:03.8904080+00:00`

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
  "id": "fe6e927f-2de4-4034-938a-3766c057f2d4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.8904080+00:00"
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
  "subject_id": "b73d5369-6158-4b0d-b8a9-80af7f6a610d",
  "subject_name": "django/db/models/options::Options.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, meta, app_label=None)"
}
```
