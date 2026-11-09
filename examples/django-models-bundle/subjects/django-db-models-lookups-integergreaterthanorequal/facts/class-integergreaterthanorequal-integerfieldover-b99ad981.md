# Fact b99ad981

Store id: 4796a693-bd19-4d44-ac14-2d4b87a34c50

## Text

```text
class IntegerGreaterThanOrEqual( IntegerFieldOverflow, IntegerFieldFloatRounding, GreaterThanOrEqual )
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
- posted_at: `2026-11-09T23:44:54.9912630+00:00`

## Data

```json
{
  "end_line": 489,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 485,
  "symbol": "IntegerGreaterThanOrEqual"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":485,"selector":"L485-L489","symbol":"IntegerGreaterThanOrEqual"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IntegerGreaterThanOrEqual](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 489,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 485,
    "symbol": "IntegerGreaterThanOrEqual"
  },
  "id": "4796a693-bd19-4d44-ac14-2d4b87a34c50",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.9912630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 485,
        "selector": "L485-L489",
        "symbol": "IntegerGreaterThanOrEqual"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "1a40f093-b8f9-4194-a35d-b1d8126bae21",
  "subject_name": "django/db/models/lookups::IntegerGreaterThanOrEqual",
  "tags": [
    "entity:class",
    "decorator:IntegerField.register_lookup"
  ],
  "text": "class IntegerGreaterThanOrEqual( IntegerFieldOverflow, IntegerFieldFloatRounding, GreaterThanOrEqual )"
}
```
