# Fact 2ae6cf34

Store id: ae6b5818-190d-4894-b7fa-781c14f09c13

## Text

```text
class StringAgg(Aggregate)
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
- posted_at: `2026-11-09T23:44:48.4045630+00:00`

## Data

```json
{
  "end_line": 449,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 371,
  "symbol": "StringAgg"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":371,"selector":"L371-L449","symbol":"StringAgg"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::StringAgg](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 449,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 371,
    "symbol": "StringAgg"
  },
  "id": "ae6b5818-190d-4894-b7fa-781c14f09c13",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.4045630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 371,
        "selector": "L371-L449",
        "symbol": "StringAgg"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "0c0c09fc-5775-49f0-8a66-5eda3afa4173",
  "subject_name": "django/db/models/aggregates::StringAgg",
  "tags": [
    "entity:class"
  ],
  "text": "class StringAgg(Aggregate)"
}
```
