# Fact 795e3be8

Store id: 0a3976dd-61fb-46eb-a338-9fe5c6a02c04

## Text

```text
class SHA256(MySQLSHA2Mixin, OracleHashMixin, PostgreSQLSHAMixin, Transform)
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
- posted_at: `2026-11-09T23:44:54.1489040+00:00`

## Data

```json
{
  "end_line": 317,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 315,
  "symbol": "SHA256"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":315,"selector":"L315-L317","symbol":"SHA256"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::SHA256](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 317,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 315,
    "symbol": "SHA256"
  },
  "id": "0a3976dd-61fb-46eb-a338-9fe5c6a02c04",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1489040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 315,
        "selector": "L315-L317",
        "symbol": "SHA256"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "8d89015b-4d6a-47b0-8fc7-64805390b873",
  "subject_name": "django/db/models/functions/text::SHA256",
  "tags": [
    "entity:class"
  ],
  "text": "class SHA256(MySQLSHA2Mixin, OracleHashMixin, PostgreSQLSHAMixin, Transform)"
}
```
