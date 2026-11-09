# Fact 41b9b52a

Store id: 136ea6f5-5198-4708-81b8-17933d9fac35

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
- posted_at: `2026-11-09T23:44:57.3655030+00:00`

## Data

```json
{
  "end_line": 39,
  "entity_kind": "method",
  "parent": "PositionRef",
  "start_line": 38,
  "symbol": "PositionRef.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":38,"selector":"L38-L39","symbol":"PositionRef.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::PositionRef.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 39,
    "entity_kind": "method",
    "parent": "PositionRef",
    "start_line": 38,
    "symbol": "PositionRef.as_sql"
  },
  "id": "136ea6f5-5198-4708-81b8-17933d9fac35",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.3655030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 38,
        "selector": "L38-L39",
        "symbol": "PositionRef.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "cf3803d1-50bb-4143-b2db-b46259f1b51e",
  "subject_name": "django/db/models/sql/compiler::PositionRef.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
