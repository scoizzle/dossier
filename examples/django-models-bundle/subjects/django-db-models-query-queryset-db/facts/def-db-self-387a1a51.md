# Fact 387a1a51

Store id: b30cfc1d-e6bb-4151-9677-7c631ba830f4

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
- posted_at: `2026-11-09T23:32:04.6141010+00:00`

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
  "id": "b30cfc1d-e6bb-4151-9677-7c631ba830f4",
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
    "posted_at": "2026-11-09T23:32:04.6141010+00:00"
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
  "subject_id": "4d6fe128-4001-4d44-ac39-0252c701f9ba",
  "subject_name": "django/db/models/query::QuerySet.db",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def db(self)"
}
```
