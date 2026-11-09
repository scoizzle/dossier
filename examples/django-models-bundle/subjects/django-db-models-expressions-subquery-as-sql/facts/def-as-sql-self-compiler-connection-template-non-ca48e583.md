# Fact ca48e583

Store id: 2ddb1650-b6c6-4ce1-936a-e67f94d3e467

## Text

```text
def as_sql(self, compiler, connection, template=None, **extra_context)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.7300490+00:00`

## Data

```json
{
  "end_line": 1881,
  "entity_kind": "method",
  "parent": "Subquery",
  "start_line": 1873,
  "symbol": "Subquery.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1873,"selector":"L1873-L1881","symbol":"Subquery.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Subquery.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1881,
    "entity_kind": "method",
    "parent": "Subquery",
    "start_line": 1873,
    "symbol": "Subquery.as_sql"
  },
  "id": "2ddb1650-b6c6-4ce1-936a-e67f94d3e467",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7300490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1873,
        "selector": "L1873-L1881",
        "symbol": "Subquery.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "33dd0400-270a-41c5-94e4-94688072d5c7",
  "subject_name": "django/db/models/expressions::Subquery.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, template=None, **extra_context)"
}
```
