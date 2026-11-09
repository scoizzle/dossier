# Fact 8bfef233

Store id: b412d4f7-98ea-439c-8669-e52d4be39d08

## Text

```text
class LessThanOrEqual(FieldGetDbPrepValueMixin, BuiltinLookup)
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
- posted_at: `2026-11-09T22:39:48.1220980+00:00`

## Data

```json
{
  "end_line": 442,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 440,
  "symbol": "LessThanOrEqual"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":440,"selector":"L440-L442","symbol":"LessThanOrEqual"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::LessThanOrEqual](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 442,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 440,
    "symbol": "LessThanOrEqual"
  },
  "id": "b412d4f7-98ea-439c-8669-e52d4be39d08",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1220980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 440,
        "selector": "L440-L442",
        "symbol": "LessThanOrEqual"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "71049ce8-b78e-49dd-b899-daf902c59810",
  "subject_name": "django/db/models/lookups::LessThanOrEqual",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class LessThanOrEqual(FieldGetDbPrepValueMixin, BuiltinLookup)"
}
```
