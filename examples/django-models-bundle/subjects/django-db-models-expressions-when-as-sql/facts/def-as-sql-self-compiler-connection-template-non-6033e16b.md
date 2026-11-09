# Fact 6033e16b

Store id: db4d6dc3-d938-4130-a10d-f5f51208babc

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
- posted_at: `2026-11-09T23:44:49.6173720+00:00`

## Data

```json
{
  "end_line": 1702,
  "entity_kind": "method",
  "parent": "When",
  "start_line": 1689,
  "symbol": "When.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1689,"selector":"L1689-L1702","symbol":"When.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::When.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1702,
    "entity_kind": "method",
    "parent": "When",
    "start_line": 1689,
    "symbol": "When.as_sql"
  },
  "id": "db4d6dc3-d938-4130-a10d-f5f51208babc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6173720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1689,
        "selector": "L1689-L1702",
        "symbol": "When.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "9e5edb7b-ff6e-4c7b-be10-13707465641b",
  "subject_name": "django/db/models/expressions::When.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, template=None, **extra_context)"
}
```
