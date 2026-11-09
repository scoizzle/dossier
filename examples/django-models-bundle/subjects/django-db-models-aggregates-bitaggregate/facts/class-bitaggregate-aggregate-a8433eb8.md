# Fact a8433eb8

Store id: d8a68f0c-159e-4581-b06f-3005ef4b0302

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
- posted_at: `2026-11-09T23:31:53.5365280+00:00`

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
  "id": "d8a68f0c-159e-4581-b06f-3005ef4b0302",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5365280+00:00"
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
  "subject_id": "4e528ec1-f9c7-48ce-98bf-e417f016620c",
  "subject_name": "django/db/models/aggregates::BitAggregate",
  "tags": [
    "entity:class"
  ],
  "text": "class BitAggregate(Aggregate)"
}
```
