# Fact 85495762

Store id: 7c6bb630-3c80-4a2b-92a7-b1910f0b50a1

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
- posted_at: `2026-11-09T23:31:56.0111940+00:00`

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
  "id": "7c6bb630-3c80-4a2b-92a7-b1910f0b50a1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.0111940+00:00"
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
  "subject_id": "30c4c5aa-cee4-4cd4-8552-1dcf54ff5c95",
  "subject_name": "django/db/models/expressions::WindowFrameExclusion.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
