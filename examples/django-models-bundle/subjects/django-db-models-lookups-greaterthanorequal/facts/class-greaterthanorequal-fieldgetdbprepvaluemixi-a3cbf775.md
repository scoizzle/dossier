# Fact a3cbf775

Store id: ecda6e0d-b2d4-445a-9517-7d39927c543f

## Text

```text
class GreaterThanOrEqual(FieldGetDbPrepValueMixin, BuiltinLookup)
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
- posted_at: `2026-11-09T22:39:48.1171300+00:00`

## Data

```json
{
  "end_line": 432,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 430,
  "symbol": "GreaterThanOrEqual"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":430,"selector":"L430-L432","symbol":"GreaterThanOrEqual"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::GreaterThanOrEqual](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 432,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 430,
    "symbol": "GreaterThanOrEqual"
  },
  "id": "ecda6e0d-b2d4-445a-9517-7d39927c543f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1171300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 430,
        "selector": "L430-L432",
        "symbol": "GreaterThanOrEqual"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "479ddd6b-a073-450b-be99-e584d4b86893",
  "subject_name": "django/db/models/lookups::GreaterThanOrEqual",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class GreaterThanOrEqual(FieldGetDbPrepValueMixin, BuiltinLookup)"
}
```
