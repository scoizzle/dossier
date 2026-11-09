# Fact 1cfa1923

Store id: 33dfbce9-7177-455b-97f1-0e05ae5f150b

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
- posted_at: `2026-11-09T22:39:40.0432040+00:00`

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
  "id": "33dfbce9-7177-455b-97f1-0e05ae5f150b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0432040+00:00"
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
  "subject_id": "ed80d922-3016-4135-a50d-8159dfb4b6dd",
  "subject_name": "django/db/models/aggregates::BitXor",
  "tags": [
    "entity:class"
  ],
  "text": "class BitXor(BitAggregate)"
}
```
