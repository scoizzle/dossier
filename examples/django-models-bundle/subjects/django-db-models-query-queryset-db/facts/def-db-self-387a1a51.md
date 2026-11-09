# Fact 387a1a51

Store id: 87562fad-72f7-46eb-94a3-f08d196678ab

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
- posted_at: `2026-11-09T23:44:56.1270750+00:00`

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
  "id": "87562fad-72f7-46eb-94a3-f08d196678ab",
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
    "posted_at": "2026-11-09T23:44:56.1270750+00:00"
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
  "subject_id": "04991518-982b-4171-88d4-cb11924f2403",
  "subject_name": "django/db/models/query::QuerySet.db",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def db(self)"
}
```
