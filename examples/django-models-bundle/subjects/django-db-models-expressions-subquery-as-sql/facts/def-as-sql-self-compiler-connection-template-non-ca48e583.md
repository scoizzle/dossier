# Fact ca48e583

Store id: e4bec569-a278-4bcd-8257-2063041e576b

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
- posted_at: `2026-11-09T23:31:55.9751870+00:00`

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
  "id": "e4bec569-a278-4bcd-8257-2063041e576b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9751870+00:00"
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
  "subject_id": "aacc6c6c-b65b-4d22-8fab-8dc5ecb50ddf",
  "subject_name": "django/db/models/expressions::Subquery.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, template=None, **extra_context)"
}
```
