# Fact f827c883

Store id: f2d1b88b-0c5c-4d50-b3fe-d41c03222f68

## Text

```text
def as_mysql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:49.5362510+00:00`

## Data

```json
{
  "end_line": 1265,
  "entity_kind": "method",
  "parent": "JSONNull",
  "start_line": 1262,
  "symbol": "JSONNull.as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1262,"selector":"L1262-L1265","symbol":"JSONNull.as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::JSONNull.as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1265,
    "entity_kind": "method",
    "parent": "JSONNull",
    "start_line": 1262,
    "symbol": "JSONNull.as_mysql"
  },
  "id": "f2d1b88b-0c5c-4d50-b3fe-d41c03222f68",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5362510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1262,
        "selector": "L1262-L1265",
        "symbol": "JSONNull.as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "4bf2bf17-b132-477f-a90c-d4cff79fca10",
  "subject_name": "django/db/models/expressions::JSONNull.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection)"
}
```
