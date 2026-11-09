# Fact fc10dd3a

Store id: c2d8825d-67b6-415f-9759-93819e1c344a

## Text

```text
class YearGte(YearLookup, GreaterThanOrEqual)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:55.0807220+00:00`

## Data

```json
{
  "end_line": 768,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 766,
  "symbol": "YearGte"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":766,"selector":"L766-L768","symbol":"YearGte"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::YearGte](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 768,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 766,
    "symbol": "YearGte"
  },
  "id": "c2d8825d-67b6-415f-9759-93819e1c344a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0807220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 766,
        "selector": "L766-L768",
        "symbol": "YearGte"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "5916596f-8f1b-4cfd-a6cf-99e7e0acbc48",
  "subject_name": "django/db/models/lookups::YearGte",
  "tags": [
    "entity:class"
  ],
  "text": "class YearGte(YearLookup, GreaterThanOrEqual)"
}
```
