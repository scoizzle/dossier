# Fact 96de6470

Store id: f128d66b-9dff-4f82-bc8c-c992931bf633

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
- posted_at: `2026-11-09T23:44:49.5981960+00:00`

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
  "id": "f128d66b-9dff-4f82-bc8c-c992931bf633",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5981960+00:00"
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
  "subject_id": "17733f62-b80b-4555-bbe2-45fef78e4d24",
  "subject_name": "django/db/models/expressions::ExpressionWrapper.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
