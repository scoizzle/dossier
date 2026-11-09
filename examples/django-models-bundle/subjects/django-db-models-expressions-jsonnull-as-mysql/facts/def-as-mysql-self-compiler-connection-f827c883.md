# Fact f827c883

Store id: de90784b-4dc7-48cd-8502-3c9e815c5844

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
- posted_at: `2026-11-09T22:39:41.6055570+00:00`

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
  "id": "de90784b-4dc7-48cd-8502-3c9e815c5844",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6055570+00:00"
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
  "subject_id": "5c9662b4-c231-4213-9edc-b400948da263",
  "subject_name": "django/db/models/expressions::JSONNull.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection)"
}
```
