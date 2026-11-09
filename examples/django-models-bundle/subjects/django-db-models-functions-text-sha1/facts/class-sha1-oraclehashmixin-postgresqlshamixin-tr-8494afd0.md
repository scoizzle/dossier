# Fact 8494afd0

Store id: a3462b5f-05c2-4609-b0e7-c47c6660282e

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
- posted_at: `2026-11-09T23:32:02.2766150+00:00`

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
  "id": "a3462b5f-05c2-4609-b0e7-c47c6660282e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.2766150+00:00"
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
  "subject_id": "468b0a52-24b4-4117-8216-3824f3aa04ec",
  "subject_name": "django/db/models/functions/text::SHA1",
  "tags": [
    "entity:class"
  ],
  "text": "class SHA1(OracleHashMixin, PostgreSQLSHAMixin, Transform)"
}
```
