# Fact 02c522a3

Store id: 47c5e360-17a6-439e-9f9d-1a80434f6cd5

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
- posted_at: `2026-11-09T22:39:41.6318740+00:00`

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
  "id": "47c5e360-17a6-439e-9f9d-1a80434f6cd5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6318740+00:00"
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
  "subject_id": "6efb491c-970b-4d08-89a0-730f33acf72c",
  "subject_name": "django/db/models/expressions::Col.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
