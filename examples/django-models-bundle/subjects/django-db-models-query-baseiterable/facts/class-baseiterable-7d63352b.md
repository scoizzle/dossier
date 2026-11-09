# Fact 7d63352b

Store id: 80a5c748-06d5-42eb-9efb-227aef823682

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
- posted_at: `2026-11-09T22:39:49.1741340+00:00`

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
  "id": "80a5c748-06d5-42eb-9efb-227aef823682",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.1741340+00:00"
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
  "subject_id": "3ae0307b-8a22-4905-9f76-2e3e7f4393f2",
  "subject_name": "django/db/models/query::BaseIterable",
  "tags": [
    "entity:class"
  ],
  "text": "class BaseIterable"
}
```
