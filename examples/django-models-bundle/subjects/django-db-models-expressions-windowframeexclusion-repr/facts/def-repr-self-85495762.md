# Fact 85495762

Store id: 2a8a0d6c-4016-4f38-a2e4-645ba427deec

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T22:39:41.7706520+00:00`

## Data

```json
{
  "end_line": 2134,
  "entity_kind": "method",
  "parent": "WindowFrameExclusion",
  "start_line": 2133,
  "symbol": "WindowFrameExclusion.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2133,"selector":"L2133-L2134","symbol":"WindowFrameExclusion.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::WindowFrameExclusion.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2134,
    "entity_kind": "method",
    "parent": "WindowFrameExclusion",
    "start_line": 2133,
    "symbol": "WindowFrameExclusion.__repr__"
  },
  "id": "2a8a0d6c-4016-4f38-a2e4-645ba427deec",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7706520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2133,
        "selector": "L2133-L2134",
        "symbol": "WindowFrameExclusion.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "37774233-3c35-480c-9092-643f2d7f6bf7",
  "subject_name": "django/db/models/expressions::WindowFrameExclusion.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
