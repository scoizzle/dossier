# Fact 5c1f3dba

Store id: 8a8b7f8c-5a65-44db-9aa8-e6ba0d1790da

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
- posted_at: `2026-11-09T23:31:56.0101790+00:00`

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
  "id": "8a8b7f8c-5a65-44db-9aa8-e6ba0d1790da",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.0101790+00:00"
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
  "subject_id": "7be0d075-7268-4b93-9fda-fe6d29000ca5",
  "subject_name": "django/db/models/expressions::WindowFrameExclusion",
  "tags": [
    "entity:class"
  ],
  "text": "class WindowFrameExclusion(Enum)"
}
```
