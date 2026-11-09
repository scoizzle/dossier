# Fact 16695a99

Store id: 96a5205e-b5bb-4764-aa31-b51b7245c5a7

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
- posted_at: `2026-11-09T23:32:03.6580580+00:00`

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
  "id": "96a5205e-b5bb-4764-aa31-b51b7245c5a7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.6580580+00:00"
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
  "subject_id": "89d6676c-f945-46f6-aab1-f0f1e0ba7f0e",
  "subject_name": "django/db/models/manager::BaseManager.__class_getitem__",
  "tags": [
    "entity:method"
  ],
  "text": "def __class_getitem__(cls, *args, **kwargs)"
}
```
