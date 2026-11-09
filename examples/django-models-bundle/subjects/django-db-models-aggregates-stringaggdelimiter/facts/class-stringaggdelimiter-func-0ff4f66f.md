# Fact 0ff4f66f

Store id: 38f88635-a040-4d54-8020-4f67a90520f5

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
- posted_at: `2026-11-09T22:39:40.0462870+00:00`

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
  "id": "38f88635-a040-4d54-8020-4f67a90520f5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0462870+00:00"
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
  "subject_id": "d2ebb02c-5d18-44f0-88d5-d757448062b1",
  "subject_name": "django/db/models/aggregates::StringAggDelimiter",
  "tags": [
    "entity:class"
  ],
  "text": "class StringAggDelimiter(Func)"
}
```
