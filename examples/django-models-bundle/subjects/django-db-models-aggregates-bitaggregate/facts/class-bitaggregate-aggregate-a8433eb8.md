# Fact a8433eb8

Store id: 77729411-5a2f-4579-85ec-073cec8f76f0

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
- posted_at: `2026-11-09T23:44:48.3986310+00:00`

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
  "id": "77729411-5a2f-4579-85ec-073cec8f76f0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.3986310+00:00"
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
  "subject_id": "f2fb7542-5941-4b9b-b9ae-f699a8cbbef3",
  "subject_name": "django/db/models/aggregates::BitAggregate",
  "tags": [
    "entity:class"
  ],
  "text": "class BitAggregate(Aggregate)"
}
```
