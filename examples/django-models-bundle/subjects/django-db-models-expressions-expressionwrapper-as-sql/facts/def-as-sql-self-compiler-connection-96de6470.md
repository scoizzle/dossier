# Fact 96de6470

Store id: 78e66f5c-0a10-47fa-8a77-79dba0fd6db3

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:31:55.9369880+00:00`

## Data

```json
{
  "end_line": 1574,
  "entity_kind": "method",
  "parent": "ExpressionWrapper",
  "start_line": 1573,
  "symbol": "ExpressionWrapper.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1573,"selector":"L1573-L1574","symbol":"ExpressionWrapper.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ExpressionWrapper.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1574,
    "entity_kind": "method",
    "parent": "ExpressionWrapper",
    "start_line": 1573,
    "symbol": "ExpressionWrapper.as_sql"
  },
  "id": "78e66f5c-0a10-47fa-8a77-79dba0fd6db3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9369880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1573,
        "selector": "L1573-L1574",
        "symbol": "ExpressionWrapper.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "c1dad547-9128-44c6-8906-6b59d6b85fe9",
  "subject_name": "django/db/models/expressions::ExpressionWrapper.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
