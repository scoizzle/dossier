# Fact 8160378e

Store id: 1fc3c526-3945-40d6-9051-86f50e365aec

## Text

```text
def __init__(self, key_name, *args, **kwargs)
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
- posted_at: `2026-11-09T22:39:43.7052610+00:00`

## Data

```json
{
  "end_line": 502,
  "entity_kind": "method",
  "parent": "KeyTransform",
  "start_line": 500,
  "symbol": "KeyTransform.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":500,"selector":"L500-L502","symbol":"KeyTransform.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransform.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 502,
    "entity_kind": "method",
    "parent": "KeyTransform",
    "start_line": 500,
    "symbol": "KeyTransform.__init__"
  },
  "id": "1fc3c526-3945-40d6-9051-86f50e365aec",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7052610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 500,
        "selector": "L500-L502",
        "symbol": "KeyTransform.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "6aa64c49-3823-41e2-bb13-35dac686b1e3",
  "subject_name": "django/db/models/fields/json::KeyTransform.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, key_name, *args, **kwargs)"
}
```
