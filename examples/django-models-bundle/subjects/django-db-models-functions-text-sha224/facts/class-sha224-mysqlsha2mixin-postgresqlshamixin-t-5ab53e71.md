# Fact 5ab53e71

Store id: c299a6fb-b93a-434e-8770-9aad0a67bf98

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
- posted_at: `2026-11-09T23:32:02.2803230+00:00`

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
  "id": "c299a6fb-b93a-434e-8770-9aad0a67bf98",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.2803230+00:00"
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
  "subject_id": "f663ac9a-1a4a-4482-a7f0-ffc0cf997051",
  "subject_name": "django/db/models/functions/text::SHA224",
  "tags": [
    "entity:class"
  ],
  "text": "class SHA224(MySQLSHA2Mixin, PostgreSQLSHAMixin, Transform)"
}
```
