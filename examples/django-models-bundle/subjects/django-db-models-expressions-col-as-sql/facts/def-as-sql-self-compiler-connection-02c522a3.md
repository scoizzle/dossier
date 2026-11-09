# Fact 02c522a3

Store id: 897191ab-9d52-4a58-9b8b-e03f82d75084

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
- posted_at: `2026-11-09T23:44:49.5543070+00:00`

## Data

```json
{
  "end_line": 1370,
  "entity_kind": "method",
  "parent": "Col",
  "start_line": 1366,
  "symbol": "Col.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1366,"selector":"L1366-L1370","symbol":"Col.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Col.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1370,
    "entity_kind": "method",
    "parent": "Col",
    "start_line": 1366,
    "symbol": "Col.as_sql"
  },
  "id": "897191ab-9d52-4a58-9b8b-e03f82d75084",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5543070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1366,
        "selector": "L1366-L1370",
        "symbol": "Col.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "9a70af54-275e-4d44-9a16-4bd30eae4c93",
  "subject_name": "django/db/models/expressions::Col.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
