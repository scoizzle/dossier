# Fact a6ed6c5c

Store id: e811daf0-cd82-48bf-9a91-181bbd085c76

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
- posted_at: `2026-11-09T22:39:41.6130860+00:00`

## Data

```json
{
  "end_line": 1308,
  "entity_kind": "method",
  "parent": "Star",
  "start_line": 1307,
  "symbol": "Star.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1307,"selector":"L1307-L1308","symbol":"Star.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Star.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1308,
    "entity_kind": "method",
    "parent": "Star",
    "start_line": 1307,
    "symbol": "Star.as_sql"
  },
  "id": "e811daf0-cd82-48bf-9a91-181bbd085c76",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6130860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1307,
        "selector": "L1307-L1308",
        "symbol": "Star.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "4661f409-1118-44eb-8d20-1c4ff15325b1",
  "subject_name": "django/db/models/expressions::Star.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
