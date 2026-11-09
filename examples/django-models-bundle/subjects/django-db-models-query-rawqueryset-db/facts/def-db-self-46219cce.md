# Fact 46219cce

Store id: 4f401c92-4bf7-4a9a-9fd4-c6462a8ed3d2

## Text

```text
def db(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:49.8213570+00:00`

## Data

```json
{
  "end_line": 2525,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2522,
  "symbol": "RawQuerySet.db"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2522,"selector":"L2522-L2525","symbol":"RawQuerySet.db"}`

## Items

```json
[
  {
    "text": "Return the database used if this query is executed now.",
    "locator": {
      "line": 2524
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.db](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2525,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2522,
    "symbol": "RawQuerySet.db"
  },
  "id": "4f401c92-4bf7-4a9a-9fd4-c6462a8ed3d2",
  "items": [
    {
      "locator": {
        "line": 2524
      },
      "text": "Return the database used if this query is executed now."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.8213570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2522,
        "selector": "L2522-L2525",
        "symbol": "RawQuerySet.db"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "1c97b868-c99c-46f0-926e-9d9fce5fbd0d",
  "subject_name": "django/db/models/query::RawQuerySet.db",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def db(self)"
}
```
