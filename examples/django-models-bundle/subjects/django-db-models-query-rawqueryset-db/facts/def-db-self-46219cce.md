# Fact 46219cce

Store id: a51bf09b-f831-4c3c-87a6-5b03c3effbc0

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
- posted_at: `2026-11-09T23:44:56.2629190+00:00`

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
  "id": "a51bf09b-f831-4c3c-87a6-5b03c3effbc0",
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
    "posted_at": "2026-11-09T23:44:56.2629190+00:00"
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
  "subject_id": "e5d58d86-684f-4905-8035-83e8354f70a1",
  "subject_name": "django/db/models/query::RawQuerySet.db",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def db(self)"
}
```
