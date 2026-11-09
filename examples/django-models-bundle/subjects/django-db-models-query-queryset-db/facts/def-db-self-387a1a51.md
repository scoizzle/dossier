# Fact 387a1a51

Store id: becd3947-f56f-4bf9-ba94-8374422a0071

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
- posted_at: `2026-11-09T22:39:49.6904810+00:00`

## Data

```json
{
  "end_line": 2135,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2130,
  "symbol": "QuerySet.db"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2130,"selector":"L2130-L2135","symbol":"QuerySet.db"}`

## Items

```json
[
  {
    "text": "Return the database used if this query is executed now.",
    "locator": {
      "line": 2132
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.db](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2135,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2130,
    "symbol": "QuerySet.db"
  },
  "id": "becd3947-f56f-4bf9-ba94-8374422a0071",
  "items": [
    {
      "locator": {
        "line": 2132
      },
      "text": "Return the database used if this query is executed now."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.6904810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2130,
        "selector": "L2130-L2135",
        "symbol": "QuerySet.db"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "65f4116f-7004-43a0-89a8-908d98fef70c",
  "subject_name": "django/db/models/query::QuerySet.db",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def db(self)"
}
```
