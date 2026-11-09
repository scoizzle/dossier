# Fact 7d63352b

Store id: 66ba7eae-d3fb-4df5-b7a7-62a94d3bb8b1

## Text

```text
class BaseIterable
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
- posted_at: `2026-11-09T23:32:04.2187180+00:00`

## Data

```json
{
  "end_line": 118,
  "entity_kind": "class",
  "parent": "query",
  "start_line": 85,
  "symbol": "BaseIterable"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":85,"selector":"L85-L118","symbol":"BaseIterable"}`

## Referenced by

None.

## Subject

[django/db/models/query::BaseIterable](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 118,
    "entity_kind": "class",
    "parent": "query",
    "start_line": 85,
    "symbol": "BaseIterable"
  },
  "id": "66ba7eae-d3fb-4df5-b7a7-62a94d3bb8b1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.2187180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 85,
        "selector": "L85-L118",
        "symbol": "BaseIterable"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "01baee77-525d-4eb7-a5d5-e9cfb667078a",
  "subject_name": "django/db/models/query::BaseIterable",
  "tags": [
    "entity:class"
  ],
  "text": "class BaseIterable"
}
```
