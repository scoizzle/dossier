# Fact b99ad981

Store id: 167b98b4-2571-44c8-8ca6-ca67640f8e87

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
- posted_at: `2026-11-09T23:32:03.3066630+00:00`

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
  "id": "167b98b4-2571-44c8-8ca6-ca67640f8e87",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.3066630+00:00"
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
  "subject_id": "b02150bb-080e-445d-b530-6d3413f157bb",
  "subject_name": "django/db/models/lookups::IntegerGreaterThanOrEqual",
  "tags": [
    "entity:class",
    "decorator:IntegerField.register_lookup"
  ],
  "text": "class IntegerGreaterThanOrEqual( IntegerFieldOverflow, IntegerFieldFloatRounding, GreaterThanOrEqual )"
}
```
