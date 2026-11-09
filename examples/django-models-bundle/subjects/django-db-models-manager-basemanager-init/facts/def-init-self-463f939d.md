# Fact 463f939d

Store id: c09d0cd6-74b1-4a71-8003-31f7a7d1e3f3

## Text

```text
def __init__(self)
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
- posted_at: `2026-11-09T22:39:48.4586940+00:00`

## Data

```json
{
  "end_line": 33,
  "entity_kind": "method",
  "parent": "BaseManager",
  "start_line": 27,
  "symbol": "BaseManager.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":27,"selector":"L27-L33","symbol":"BaseManager.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 33,
    "entity_kind": "method",
    "parent": "BaseManager",
    "start_line": 27,
    "symbol": "BaseManager.__init__"
  },
  "id": "c09d0cd6-74b1-4a71-8003-31f7a7d1e3f3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.4586940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 27,
        "selector": "L27-L33",
        "symbol": "BaseManager.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "3794cdfe-ab43-4164-97c1-213c2ea591f4",
  "subject_name": "django/db/models/manager::BaseManager.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self)"
}
```
