# Fact 5ab53e71

Store id: 4b271a0d-78b2-4cf0-a2af-2c4b7bf0a6e5

## Text

```text
class SHA224(MySQLSHA2Mixin, PostgreSQLSHAMixin, Transform)
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
- posted_at: `2026-11-09T23:44:54.1444900+00:00`

## Data

```json
{
  "end_line": 312,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 307,
  "symbol": "SHA224"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":307,"selector":"L307-L312","symbol":"SHA224"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::SHA224](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 312,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 307,
    "symbol": "SHA224"
  },
  "id": "4b271a0d-78b2-4cf0-a2af-2c4b7bf0a6e5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1444900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 307,
        "selector": "L307-L312",
        "symbol": "SHA224"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "cf1e1886-f271-46ea-b151-04a38c7a4744",
  "subject_name": "django/db/models/functions/text::SHA224",
  "tags": [
    "entity:class"
  ],
  "text": "class SHA224(MySQLSHA2Mixin, PostgreSQLSHAMixin, Transform)"
}
```
