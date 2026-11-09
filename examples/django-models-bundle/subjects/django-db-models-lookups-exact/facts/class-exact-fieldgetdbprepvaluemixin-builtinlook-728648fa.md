# Fact 728648fa

Store id: 8fac501c-b671-4960-95c2-3c78602f2af0

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
- posted_at: `2026-11-09T23:44:54.9518060+00:00`

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
  "id": "8fac501c-b671-4960-95c2-3c78602f2af0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.9518060+00:00"
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
  "subject_id": "32683582-eff6-47cc-a6cf-a40c76366db5",
  "subject_name": "django/db/models/lookups::Exact",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class Exact(FieldGetDbPrepValueMixin, BuiltinLookup)"
}
```
