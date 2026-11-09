# Fact 0c1f2443

Store id: 6cc47537-21ae-4aac-b57e-c9461ee1fa08

## Text

```text
class IntegerLessThan(IntegerFieldOverflow, IntegerFieldFloatRounding, LessThan)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:IntegerField.register_lookup`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:48.1442960+00:00`

## Data

```json
{
  "end_line": 494,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 492,
  "symbol": "IntegerLessThan"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":492,"selector":"L492-L494","symbol":"IntegerLessThan"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IntegerLessThan](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 494,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 492,
    "symbol": "IntegerLessThan"
  },
  "id": "6cc47537-21ae-4aac-b57e-c9461ee1fa08",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1442960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 492,
        "selector": "L492-L494",
        "symbol": "IntegerLessThan"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "3ecbe96d-2dd4-4b50-b084-b25c93dff968",
  "subject_name": "django/db/models/lookups::IntegerLessThan",
  "tags": [
    "entity:class",
    "decorator:IntegerField.register_lookup"
  ],
  "text": "class IntegerLessThan(IntegerFieldOverflow, IntegerFieldFloatRounding, LessThan)"
}
```
