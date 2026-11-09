# Fact c70aa966

Store id: 7873cc80-4337-468e-9f84-8e8c06e47fd5

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
- posted_at: `2026-11-09T23:44:49.5250490+00:00`

## Data

```json
{
  "end_line": 1191,
  "entity_kind": "method",
  "parent": "Value",
  "start_line": 1171,
  "symbol": "Value.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1171,"selector":"L1171-L1191","symbol":"Value.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Value.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1191,
    "entity_kind": "method",
    "parent": "Value",
    "start_line": 1171,
    "symbol": "Value.as_sql"
  },
  "id": "7873cc80-4337-468e-9f84-8e8c06e47fd5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5250490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1171,
        "selector": "L1171-L1191",
        "symbol": "Value.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "8c2b185f-a73d-4543-b273-21dc4a93ef21",
  "subject_name": "django/db/models/expressions::Value.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
