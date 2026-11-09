# Fact 8160378e

Store id: 45a2eaa2-794f-405c-af91-00b61337c023

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
- posted_at: `2026-11-09T23:31:57.9638760+00:00`

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
  "id": "45a2eaa2-794f-405c-af91-00b61337c023",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9638760+00:00"
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
  "subject_id": "958b70d1-673d-4665-9cbd-c1d75f19d22f",
  "subject_name": "django/db/models/fields/json::KeyTransform.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, key_name, *args, **kwargs)"
}
```
