# Fact 728648fa

Store id: b1d2dd3c-be32-4e9f-b623-7596322b35c4

## Text

```text
class Exact(FieldGetDbPrepValueMixin, BuiltinLookup)
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
- posted_at: `2026-11-09T23:32:03.2510420+00:00`

## Data

```json
{
  "end_line": 410,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 372,
  "symbol": "Exact"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":372,"selector":"L372-L410","symbol":"Exact"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Exact](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 410,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 372,
    "symbol": "Exact"
  },
  "id": "b1d2dd3c-be32-4e9f-b623-7596322b35c4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.2510420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 372,
        "selector": "L372-L410",
        "symbol": "Exact"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "07a86a88-c8a3-48fa-a8fe-319d121d41be",
  "subject_name": "django/db/models/lookups::Exact",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class Exact(FieldGetDbPrepValueMixin, BuiltinLookup)"
}
```
