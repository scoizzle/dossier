# Fact 2994967f

Store id: 51156351-7a23-49c8-8836-ed677c61237a

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
- posted_at: `2026-11-09T23:32:02.1218870+00:00`

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
  "id": "51156351-7a23-49c8-8836-ed677c61237a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.1218870+00:00"
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
  "subject_id": "53fe7188-2762-42ae-8a77-954158b304b1",
  "subject_name": "django/db/models/functions/text::MySQLSHA2Mixin.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
