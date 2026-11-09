# Fact 1cfa1923

Store id: 8c807244-f9b4-4012-abc0-47ba14a79a8b

## Text

```text
class BitXor(BitAggregate)
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
- posted_at: `2026-11-09T23:44:48.4006220+00:00`

## Data

```json
{
  "end_line": 292,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 290,
  "symbol": "BitXor"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":290,"selector":"L290-L292","symbol":"BitXor"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::BitXor](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 292,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 290,
    "symbol": "BitXor"
  },
  "id": "8c807244-f9b4-4012-abc0-47ba14a79a8b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.4006220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 290,
        "selector": "L290-L292",
        "symbol": "BitXor"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "d5d4ace2-3798-4464-88ab-8edc637f53e2",
  "subject_name": "django/db/models/aggregates::BitXor",
  "tags": [
    "entity:class"
  ],
  "text": "class BitXor(BitAggregate)"
}
```
