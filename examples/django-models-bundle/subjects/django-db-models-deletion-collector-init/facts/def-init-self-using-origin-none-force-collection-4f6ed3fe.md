# Fact 4f6ed3fe

Store id: 9c37f540-d639-4de2-9df0-137d3e05412c

## Text

```text
def __init__(self, using, origin=None, force_collection=False)
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
- posted_at: `2026-11-09T23:31:55.0953780+00:00`

## Data

```json
{
  "end_line": 139,
  "entity_kind": "method",
  "parent": "Collector",
  "start_line": 118,
  "symbol": "Collector.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":118,"selector":"L118-L139","symbol":"Collector.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::Collector.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 139,
    "entity_kind": "method",
    "parent": "Collector",
    "start_line": 118,
    "symbol": "Collector.__init__"
  },
  "id": "9c37f540-d639-4de2-9df0-137d3e05412c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.0953780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 118,
        "selector": "L118-L139",
        "symbol": "Collector.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "bf8fd975-1437-4104-8477-9bd9aecc1cba",
  "subject_name": "django/db/models/deletion::Collector.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, using, origin=None, force_collection=False)"
}
```
