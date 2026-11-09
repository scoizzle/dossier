# Fact d205a0f5

Store id: fcfdfb03-509d-4cb1-a451-6184606b3bc8

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
- posted_at: `2026-11-09T22:39:47.1918640+00:00`

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
  "id": "fcfdfb03-509d-4cb1-a451-6184606b3bc8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1918640+00:00"
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
  "subject_id": "bf580975-3af8-40de-ab7c-08d029839700",
  "subject_name": "django/db/models/functions/text::SHA512",
  "tags": [
    "entity:class"
  ],
  "text": "class SHA512(MySQLSHA2Mixin, OracleHashMixin, PostgreSQLSHAMixin, Transform)"
}
```
