# Fact 16695a99

Store id: 64e353a1-8a5d-40f0-84d4-f3c1997594a1

## Text

```text
def __class_getitem__(cls, *args, **kwargs)
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
- posted_at: `2026-11-09T22:39:48.4681560+00:00`

## Data

```json
{
  "end_line": 40,
  "entity_kind": "method",
  "parent": "BaseManager",
  "start_line": 39,
  "symbol": "BaseManager.__class_getitem__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":39,"selector":"L39-L40","symbol":"BaseManager.__class_getitem__"}`

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager.__class_getitem__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 40,
    "entity_kind": "method",
    "parent": "BaseManager",
    "start_line": 39,
    "symbol": "BaseManager.__class_getitem__"
  },
  "id": "64e353a1-8a5d-40f0-84d4-f3c1997594a1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.4681560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 39,
        "selector": "L39-L40",
        "symbol": "BaseManager.__class_getitem__"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "1893658f-6df8-4fa1-977a-2d5a7074ecb1",
  "subject_name": "django/db/models/manager::BaseManager.__class_getitem__",
  "tags": [
    "entity:method"
  ],
  "text": "def __class_getitem__(cls, *args, **kwargs)"
}
```
