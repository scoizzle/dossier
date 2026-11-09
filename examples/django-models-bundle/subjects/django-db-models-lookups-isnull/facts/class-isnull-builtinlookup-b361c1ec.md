# Fact b361c1ec

Store id: f3c2c5ca-9b06-40ac-a1cd-13fb7ffda6bd

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
- posted_at: `2026-11-09T23:32:03.3898710+00:00`

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
  "id": "f3c2c5ca-9b06-40ac-a1cd-13fb7ffda6bd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.3898710+00:00"
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
  "subject_id": "39137232-a9aa-4690-a0c8-ccb15c89b9b8",
  "subject_name": "django/db/models/lookups::IsNull",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class IsNull(BuiltinLookup)"
}
```
