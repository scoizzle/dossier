# Fact 6166c9db

Store id: cad0c04d-0adf-43b6-b555-e01be846fc3e

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
- posted_at: `2026-11-09T22:39:41.6091280+00:00`

## Data

```json
{
  "end_line": 1281,
  "entity_kind": "method",
  "parent": "RawSQL",
  "start_line": 1280,
  "symbol": "RawSQL.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1280,"selector":"L1280-L1281","symbol":"RawSQL.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::RawSQL.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1281,
    "entity_kind": "method",
    "parent": "RawSQL",
    "start_line": 1280,
    "symbol": "RawSQL.as_sql"
  },
  "id": "cad0c04d-0adf-43b6-b555-e01be846fc3e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6091280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1280,
        "selector": "L1280-L1281",
        "symbol": "RawSQL.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "68cab7de-5310-4126-bed3-82f18ad96e3a",
  "subject_name": "django/db/models/expressions::RawSQL.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
