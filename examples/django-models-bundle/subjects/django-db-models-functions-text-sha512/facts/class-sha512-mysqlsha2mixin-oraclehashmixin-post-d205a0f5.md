# Fact d205a0f5

Store id: 9f81d8fa-ed25-4678-a642-683cab903f17

## Text

```text
class SHA512(MySQLSHA2Mixin, OracleHashMixin, PostgreSQLSHAMixin, Transform)
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
- posted_at: `2026-11-09T23:32:02.2960180+00:00`

## Data

```json
{
  "end_line": 327,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 325,
  "symbol": "SHA512"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":325,"selector":"L325-L327","symbol":"SHA512"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::SHA512](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 327,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 325,
    "symbol": "SHA512"
  },
  "id": "9f81d8fa-ed25-4678-a642-683cab903f17",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.2960180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 325,
        "selector": "L325-L327",
        "symbol": "SHA512"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "b2dc304d-97b9-46ca-b9ba-361ad0fb1df6",
  "subject_name": "django/db/models/functions/text::SHA512",
  "tags": [
    "entity:class"
  ],
  "text": "class SHA512(MySQLSHA2Mixin, OracleHashMixin, PostgreSQLSHAMixin, Transform)"
}
```
