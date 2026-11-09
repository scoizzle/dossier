# Fact c37690d4

Store id: c71354b8-f400-4831-9337-947c128e47f4

## Text

```text
class YearLte(YearLookup, LessThanOrEqual)
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
- posted_at: `2026-11-09T22:39:48.2651820+00:00`

## Data

```json
{
  "end_line": 778,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 776,
  "symbol": "YearLte"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":776,"selector":"L776-L778","symbol":"YearLte"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::YearLte](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 778,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 776,
    "symbol": "YearLte"
  },
  "id": "c71354b8-f400-4831-9337-947c128e47f4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2651820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 776,
        "selector": "L776-L778",
        "symbol": "YearLte"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "b8c9e31b-e38f-43a2-814b-3ab575eaf5a5",
  "subject_name": "django/db/models/lookups::YearLte",
  "tags": [
    "entity:class"
  ],
  "text": "class YearLte(YearLookup, LessThanOrEqual)"
}
```
