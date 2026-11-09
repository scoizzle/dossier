# Fact 4c905d2d

Store id: 3da1d0de-72ea-4cd6-8736-6ac0a400495c

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
- posted_at: `2026-11-09T22:39:48.2572590+00:00`

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
  "id": "3da1d0de-72ea-4cd6-8736-6ac0a400495c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2572590+00:00"
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
  "subject_id": "9fec7bda-4ee2-4f7d-9ec8-a659d22807b2",
  "subject_name": "django/db/models/lookups::YearLt",
  "tags": [
    "entity:class"
  ],
  "text": "class YearLt(YearLookup, LessThan)"
}
```
