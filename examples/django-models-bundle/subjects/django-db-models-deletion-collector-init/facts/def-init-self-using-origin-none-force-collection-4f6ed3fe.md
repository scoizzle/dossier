# Fact 4f6ed3fe

Store id: a928d4bb-ad6d-4115-a282-a974dfc583db

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
- posted_at: `2026-11-09T22:39:41.0390980+00:00`

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
  "id": "a928d4bb-ad6d-4115-a282-a974dfc583db",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.0390980+00:00"
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
  "subject_id": "28331360-e081-4652-bfb3-8df7c54eddb0",
  "subject_name": "django/db/models/deletion::Collector.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, using, origin=None, force_collection=False)"
}
```
