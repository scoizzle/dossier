# Fact 0ff4f66f

Store id: 44a6a057-a540-4298-83d2-0784c5c20a04

## Text

```text
class StringAggDelimiter(Func)
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
- posted_at: `2026-11-09T23:44:48.4034690+00:00`

## Data

```json
{
  "end_line": 368,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 352,
  "symbol": "StringAggDelimiter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":352,"selector":"L352-L368","symbol":"StringAggDelimiter"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::StringAggDelimiter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 368,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 352,
    "symbol": "StringAggDelimiter"
  },
  "id": "44a6a057-a540-4298-83d2-0784c5c20a04",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.4034690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 352,
        "selector": "L352-L368",
        "symbol": "StringAggDelimiter"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "90f5a6ea-1bb8-4610-ba74-087ed94dd712",
  "subject_name": "django/db/models/aggregates::StringAggDelimiter",
  "tags": [
    "entity:class"
  ],
  "text": "class StringAggDelimiter(Func)"
}
```
