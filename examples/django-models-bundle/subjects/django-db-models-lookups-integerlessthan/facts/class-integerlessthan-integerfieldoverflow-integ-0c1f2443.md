# Fact 0c1f2443

Store id: b51750a8-8f25-4daf-8b1b-f40b2d2d2137

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
- posted_at: `2026-11-09T23:44:54.9934170+00:00`

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
  "id": "b51750a8-8f25-4daf-8b1b-f40b2d2d2137",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.9934170+00:00"
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
  "subject_id": "0d472b02-6cc9-40d2-a106-863ee86cf821",
  "subject_name": "django/db/models/lookups::IntegerLessThan",
  "tags": [
    "entity:class",
    "decorator:IntegerField.register_lookup"
  ],
  "text": "class IntegerLessThan(IntegerFieldOverflow, IntegerFieldFloatRounding, LessThan)"
}
```
