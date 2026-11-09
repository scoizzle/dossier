# Fact ce2a70a7

Store id: d30f539a-f583-4884-a701-a217c6107b84

## Text

```text
class GreaterThan(FieldGetDbPrepValueMixin, BuiltinLookup)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:Field.register_lookup`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.2655340+00:00`

## Data

```json
{
  "end_line": 427,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 425,
  "symbol": "GreaterThan"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":425,"selector":"L425-L427","symbol":"GreaterThan"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::GreaterThan](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 427,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 425,
    "symbol": "GreaterThan"
  },
  "id": "d30f539a-f583-4884-a701-a217c6107b84",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.2655340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 425,
        "selector": "L425-L427",
        "symbol": "GreaterThan"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "d0f6990b-ec66-478b-ab71-a75afeafb677",
  "subject_name": "django/db/models/lookups::GreaterThan",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class GreaterThan(FieldGetDbPrepValueMixin, BuiltinLookup)"
}
```
