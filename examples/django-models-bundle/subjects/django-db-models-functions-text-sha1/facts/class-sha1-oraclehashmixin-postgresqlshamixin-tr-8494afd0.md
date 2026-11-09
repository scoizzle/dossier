# Fact 8494afd0

Store id: cb9ce2d5-e834-46d7-a2d6-fd67c42ca7fe

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
- posted_at: `2026-11-09T23:44:54.1418240+00:00`

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
  "id": "cb9ce2d5-e834-46d7-a2d6-fd67c42ca7fe",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1418240+00:00"
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
  "subject_id": "0833e699-e143-42dc-b377-79108f0757a5",
  "subject_name": "django/db/models/functions/text::SHA1",
  "tags": [
    "entity:class"
  ],
  "text": "class SHA1(OracleHashMixin, PostgreSQLSHAMixin, Transform)"
}
```
