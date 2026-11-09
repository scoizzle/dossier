# Fact ca48e583

Store id: 706af13c-977e-468a-8e0b-a01a6b861ce5

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
- posted_at: `2026-11-09T23:44:49.6442260+00:00`

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
  "id": "706af13c-977e-468a-8e0b-a01a6b861ce5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6442260+00:00"
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
  "subject_id": "c6641353-9fa9-46cb-b00c-6689afe79294",
  "subject_name": "django/db/models/expressions::Subquery.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, template=None, **extra_context)"
}
```
