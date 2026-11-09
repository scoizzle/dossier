# Fact 8494afd0

Store id: ec8560d4-394a-487a-94ea-7aeeb8442bee

## Text

```text
class SHA1(OracleHashMixin, PostgreSQLSHAMixin, Transform)
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
- posted_at: `2026-11-09T22:39:47.1742410+00:00`

## Data

```json
{
  "end_line": 304,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 302,
  "symbol": "SHA1"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":302,"selector":"L302-L304","symbol":"SHA1"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::SHA1](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 304,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 302,
    "symbol": "SHA1"
  },
  "id": "ec8560d4-394a-487a-94ea-7aeeb8442bee",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1742410+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 302,
        "selector": "L302-L304",
        "symbol": "SHA1"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "14aa1d4b-500e-45f8-84fb-0aadf0746410",
  "subject_name": "django/db/models/functions/text::SHA1",
  "tags": [
    "entity:class"
  ],
  "text": "class SHA1(OracleHashMixin, PostgreSQLSHAMixin, Transform)"
}
```
