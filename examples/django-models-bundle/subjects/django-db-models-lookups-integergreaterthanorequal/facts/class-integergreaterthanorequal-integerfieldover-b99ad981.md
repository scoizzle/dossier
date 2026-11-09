# Fact b99ad981

Store id: ba1abda5-2927-405e-bf30-e1ea4e05cc5d

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
- posted_at: `2026-11-09T22:39:48.1419690+00:00`

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
  "id": "ba1abda5-2927-405e-bf30-e1ea4e05cc5d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1419690+00:00"
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
  "subject_id": "6a0c0147-cdfc-4ddd-b6b5-8e7420431c8a",
  "subject_name": "django/db/models/lookups::IntegerGreaterThanOrEqual",
  "tags": [
    "entity:class",
    "decorator:IntegerField.register_lookup"
  ],
  "text": "class IntegerGreaterThanOrEqual( IntegerFieldOverflow, IntegerFieldFloatRounding, GreaterThanOrEqual )"
}
```
