# Fact a6ef653e

Store id: df88a8d0-9d48-449c-b903-9f6ff6ab41fb

## Text

```text
class SHA384(MySQLSHA2Mixin, OracleHashMixin, PostgreSQLSHAMixin, Transform)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:54.1512190+00:00`

## Data

```json
{
  "end_line": 322,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 320,
  "symbol": "SHA384"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":320,"selector":"L320-L322","symbol":"SHA384"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::SHA384](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 322,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 320,
    "symbol": "SHA384"
  },
  "id": "df88a8d0-9d48-449c-b903-9f6ff6ab41fb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1512190+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 320,
        "selector": "L320-L322",
        "symbol": "SHA384"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "ce9ca25b-8407-4ccb-9ca7-9a411554a1a0",
  "subject_name": "django/db/models/functions/text::SHA384",
  "tags": [
    "entity:class"
  ],
  "text": "class SHA384(MySQLSHA2Mixin, OracleHashMixin, PostgreSQLSHAMixin, Transform)"
}
```
