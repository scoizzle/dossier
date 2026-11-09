# Fact 41b9b52a

Store id: 75240e52-3859-49db-9719-8ba2647e505f

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
- posted_at: `2026-11-09T22:39:50.5457450+00:00`

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
  "id": "75240e52-3859-49db-9719-8ba2647e505f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.5457450+00:00"
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
  "subject_id": "1eda70b1-2382-4234-a913-e0d910aac847",
  "subject_name": "django/db/models/sql/compiler::PositionRef.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
