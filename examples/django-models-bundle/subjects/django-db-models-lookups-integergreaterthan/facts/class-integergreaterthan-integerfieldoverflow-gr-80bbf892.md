# Fact 80bbf892

Store id: 9268f214-5067-42de-911a-e171d01a118e

## Text

```text
class IntegerGreaterThan(IntegerFieldOverflow, GreaterThan)
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
- posted_at: `2026-11-09T23:44:54.9889320+00:00`

## Data

```json
{
  "end_line": 482,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 480,
  "symbol": "IntegerGreaterThan"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":480,"selector":"L480-L482","symbol":"IntegerGreaterThan"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IntegerGreaterThan](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 482,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 480,
    "symbol": "IntegerGreaterThan"
  },
  "id": "9268f214-5067-42de-911a-e171d01a118e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.9889320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 480,
        "selector": "L480-L482",
        "symbol": "IntegerGreaterThan"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "516b053b-28ab-41f6-8223-feb556529b57",
  "subject_name": "django/db/models/lookups::IntegerGreaterThan",
  "tags": [
    "entity:class",
    "decorator:IntegerField.register_lookup"
  ],
  "text": "class IntegerGreaterThan(IntegerFieldOverflow, GreaterThan)"
}
```
