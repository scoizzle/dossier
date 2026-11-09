# Fact b361c1ec

Store id: 2f563e5c-8872-4e79-8015-9817d5a46f1d

## Text

```text
class IsNull(BuiltinLookup)
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
- posted_at: `2026-11-09T22:39:48.2016350+00:00`

## Data

```json
{
  "end_line": 688,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 665,
  "symbol": "IsNull"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":665,"selector":"L665-L688","symbol":"IsNull"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IsNull](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 688,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 665,
    "symbol": "IsNull"
  },
  "id": "2f563e5c-8872-4e79-8015-9817d5a46f1d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2016350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 665,
        "selector": "L665-L688",
        "symbol": "IsNull"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "cd1de105-1e0e-420d-85b5-73cde7a6b449",
  "subject_name": "django/db/models/lookups::IsNull",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class IsNull(BuiltinLookup)"
}
```
