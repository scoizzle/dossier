# Fact 795e3be8

Store id: 26612809-f918-4f69-8630-3dfd272f16ca

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
- posted_at: `2026-11-09T23:32:02.2877640+00:00`

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
  "id": "26612809-f918-4f69-8630-3dfd272f16ca",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.2877640+00:00"
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
  "subject_id": "78537c06-53f3-41a7-bc53-df23bf01d8da",
  "subject_name": "django/db/models/functions/text::SHA256",
  "tags": [
    "entity:class"
  ],
  "text": "class SHA256(MySQLSHA2Mixin, OracleHashMixin, PostgreSQLSHAMixin, Transform)"
}
```
