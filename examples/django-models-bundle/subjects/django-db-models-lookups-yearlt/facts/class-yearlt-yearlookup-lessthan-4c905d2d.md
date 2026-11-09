# Fact 4c905d2d

Store id: c940ded6-e841-450f-97d9-9669dba9c98e

## Text

```text
class YearLt(YearLookup, LessThan)
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
- posted_at: `2026-11-09T23:44:55.0869400+00:00`

## Data

```json
{
  "end_line": 773,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 771,
  "symbol": "YearLt"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":771,"selector":"L771-L773","symbol":"YearLt"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::YearLt](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 773,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 771,
    "symbol": "YearLt"
  },
  "id": "c940ded6-e841-450f-97d9-9669dba9c98e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0869400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 771,
        "selector": "L771-L773",
        "symbol": "YearLt"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "6cfa8b78-9b63-43d4-8d12-aef62334b345",
  "subject_name": "django/db/models/lookups::YearLt",
  "tags": [
    "entity:class"
  ],
  "text": "class YearLt(YearLookup, LessThan)"
}
```
