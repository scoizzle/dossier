# Fact 675c5733

Store id: a94edbd9-473a-40b0-87e9-e7b515e4a63a

## Text

```text
class RawQuerySet
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
- posted_at: `2026-11-09T23:32:04.7048600+00:00`

## Data

```json
{
  "end_line": 2567,
  "entity_kind": "class",
  "parent": "query",
  "start_line": 2410,
  "symbol": "RawQuerySet"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2410,"selector":"L2410-L2567","symbol":"RawQuerySet"}`

## Items

```json
[
  {
    "text": "Provide an iterator which converts the results of raw SQL queries into annotated model instances.",
    "locator": {
      "line": 2411
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2567,
    "entity_kind": "class",
    "parent": "query",
    "start_line": 2410,
    "symbol": "RawQuerySet"
  },
  "id": "a94edbd9-473a-40b0-87e9-e7b515e4a63a",
  "items": [
    {
      "locator": {
        "line": 2411
      },
      "text": "Provide an iterator which converts the results of raw SQL queries into annotated model instances."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.7048600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2410,
        "selector": "L2410-L2567",
        "symbol": "RawQuerySet"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "d50e49db-87da-4fa4-b3e7-3a5120ac63dc",
  "subject_name": "django/db/models/query::RawQuerySet",
  "tags": [
    "entity:class"
  ],
  "text": "class RawQuerySet"
}
```
