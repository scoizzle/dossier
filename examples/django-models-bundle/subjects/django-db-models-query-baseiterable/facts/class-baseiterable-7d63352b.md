# Fact 7d63352b

Store id: 22b1103c-cdc0-4412-8b8c-db1b2b3c208a

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
- posted_at: `2026-11-09T23:44:55.7569950+00:00`

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
  "id": "22b1103c-cdc0-4412-8b8c-db1b2b3c208a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.7569950+00:00"
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
  "subject_id": "5535ae2d-6443-49b4-b289-e8be4566c6b9",
  "subject_name": "django/db/models/query::BaseIterable",
  "tags": [
    "entity:class"
  ],
  "text": "class BaseIterable"
}
```
