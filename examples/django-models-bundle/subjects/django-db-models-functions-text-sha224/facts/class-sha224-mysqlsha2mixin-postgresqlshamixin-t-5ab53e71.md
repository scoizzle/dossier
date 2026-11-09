# Fact 5ab53e71

Store id: cbbcd482-eb5c-4187-be40-7b87e6da2a03

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
- posted_at: `2026-11-09T22:39:47.1778440+00:00`

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
  "id": "cbbcd482-eb5c-4187-be40-7b87e6da2a03",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1778440+00:00"
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
  "subject_id": "43dbc7cc-2598-468b-8d6e-baf2c4d40b6d",
  "subject_name": "django/db/models/functions/text::SHA224",
  "tags": [
    "entity:class"
  ],
  "text": "class SHA224(MySQLSHA2Mixin, PostgreSQLSHAMixin, Transform)"
}
```
