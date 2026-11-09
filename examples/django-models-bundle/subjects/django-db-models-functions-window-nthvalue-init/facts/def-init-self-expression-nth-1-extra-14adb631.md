# Fact 14adb631

Store id: bfe55a75-f2c8-481e-851c-35dd42901b88

## Text

```text
def __init__(self, expression, nth=1, **extra)
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
- posted_at: `2026-11-09T23:44:54.4938280+00:00`

## Data

```json
{
  "end_line": 87,
  "entity_kind": "method",
  "parent": "NthValue",
  "start_line": 78,
  "symbol": "NthValue.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":78,"selector":"L78-L87","symbol":"NthValue.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::NthValue.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 87,
    "entity_kind": "method",
    "parent": "NthValue",
    "start_line": 78,
    "symbol": "NthValue.__init__"
  },
  "id": "bfe55a75-f2c8-481e-851c-35dd42901b88",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.4938280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 78,
        "selector": "L78-L87",
        "symbol": "NthValue.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "e5daefa3-e6f1-42e6-a2ba-db38b1b65fd1",
  "subject_name": "django/db/models/functions/window::NthValue.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, nth=1, **extra)"
}
```
