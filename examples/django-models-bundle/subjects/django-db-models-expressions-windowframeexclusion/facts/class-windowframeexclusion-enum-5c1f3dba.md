# Fact 5c1f3dba

Store id: 9e86dbf9-d5a1-4f3d-9b38-fb26b457254d

## Text

```text
class WindowFrameExclusion(Enum)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.6781590+00:00`

## Data

```json
{
  "end_line": 2134,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 2127,
  "symbol": "WindowFrameExclusion"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2127,"selector":"L2127-L2134","symbol":"WindowFrameExclusion"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::WindowFrameExclusion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2134,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 2127,
    "symbol": "WindowFrameExclusion"
  },
  "id": "9e86dbf9-d5a1-4f3d-9b38-fb26b457254d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6781590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2127,
        "selector": "L2127-L2134",
        "symbol": "WindowFrameExclusion"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "1f6ffd9d-d0f5-42e6-ab7a-da5606e3fc6b",
  "subject_name": "django/db/models/expressions::WindowFrameExclusion",
  "tags": [
    "entity:class"
  ],
  "text": "class WindowFrameExclusion(Enum)"
}
```
