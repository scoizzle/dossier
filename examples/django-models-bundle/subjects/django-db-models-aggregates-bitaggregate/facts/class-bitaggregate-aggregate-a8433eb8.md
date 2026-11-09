# Fact a8433eb8

Store id: cc8b0048-6cb6-40dd-bc18-65e94c1f41cf

## Text

```text
class BitAggregate(Aggregate)
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
- posted_at: `2026-11-09T22:39:40.0405470+00:00`

## Data

```json
{
  "end_line": 277,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 247,
  "symbol": "BitAggregate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":247,"selector":"L247-L277","symbol":"BitAggregate"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::BitAggregate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 277,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 247,
    "symbol": "BitAggregate"
  },
  "id": "cc8b0048-6cb6-40dd-bc18-65e94c1f41cf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0405470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 247,
        "selector": "L247-L277",
        "symbol": "BitAggregate"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "b5e3edd8-05d5-4fc9-932a-79b9cd2c3887",
  "subject_name": "django/db/models/aggregates::BitAggregate",
  "tags": [
    "entity:class"
  ],
  "text": "class BitAggregate(Aggregate)"
}
```
