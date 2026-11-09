# Fact f827c883

Store id: bd6f62cf-9999-4395-9dbf-06a41f8b8ceb

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
- posted_at: `2026-11-09T23:31:55.8697510+00:00`

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
  "id": "bd6f62cf-9999-4395-9dbf-06a41f8b8ceb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8697510+00:00"
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
  "subject_id": "9dd6da34-26c2-4561-b36c-73dc3ce1d133",
  "subject_name": "django/db/models/expressions::JSONNull.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection)"
}
```
