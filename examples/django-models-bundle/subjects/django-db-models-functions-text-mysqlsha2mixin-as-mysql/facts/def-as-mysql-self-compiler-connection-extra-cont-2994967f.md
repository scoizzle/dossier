# Fact 2994967f

Store id: 235ea639-f041-456e-9b69-d71cfc0dbc61

## Text

```text
def as_mysql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T22:39:47.0404120+00:00`

## Data

```json
{
  "end_line": 15,
  "entity_kind": "method",
  "parent": "MySQLSHA2Mixin",
  "start_line": 9,
  "symbol": "MySQLSHA2Mixin.as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":9,"selector":"L9-L15","symbol":"MySQLSHA2Mixin.as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::MySQLSHA2Mixin.as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 15,
    "entity_kind": "method",
    "parent": "MySQLSHA2Mixin",
    "start_line": 9,
    "symbol": "MySQLSHA2Mixin.as_mysql"
  },
  "id": "235ea639-f041-456e-9b69-d71cfc0dbc61",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.0404120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 9,
        "selector": "L9-L15",
        "symbol": "MySQLSHA2Mixin.as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "488aee61-1a21-4fb0-a785-fa75f26ebea2",
  "subject_name": "django/db/models/functions/text::MySQLSHA2Mixin.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
