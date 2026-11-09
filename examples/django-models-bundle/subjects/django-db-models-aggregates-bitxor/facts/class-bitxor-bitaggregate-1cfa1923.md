# Fact 1cfa1923

Store id: e6755f06-6182-42ea-a4f4-3efcfc919f9f

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
- posted_at: `2026-11-09T23:31:53.5386480+00:00`

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
  "id": "e6755f06-6182-42ea-a4f4-3efcfc919f9f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5386480+00:00"
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
  "subject_id": "c5556ffc-d813-4446-ae5f-9f85b192fe2a",
  "subject_name": "django/db/models/aggregates::BitXor",
  "tags": [
    "entity:class"
  ],
  "text": "class BitXor(BitAggregate)"
}
```
