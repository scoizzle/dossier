# Fact 3067761f

Store id: cad2fba2-4f37-4644-9c40-a4e8db8e1b41

## Text

```text
class YearGt(YearLookup, GreaterThan)
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
- posted_at: `2026-11-09T23:44:55.0750640+00:00`

## Data

```json
{
  "end_line": 763,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 761,
  "symbol": "YearGt"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":761,"selector":"L761-L763","symbol":"YearGt"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::YearGt](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 763,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 761,
    "symbol": "YearGt"
  },
  "id": "cad2fba2-4f37-4644-9c40-a4e8db8e1b41",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0750640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 761,
        "selector": "L761-L763",
        "symbol": "YearGt"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "84633d12-9212-4f58-bb5d-d8b8301944ac",
  "subject_name": "django/db/models/lookups::YearGt",
  "tags": [
    "entity:class"
  ],
  "text": "class YearGt(YearLookup, GreaterThan)"
}
```
