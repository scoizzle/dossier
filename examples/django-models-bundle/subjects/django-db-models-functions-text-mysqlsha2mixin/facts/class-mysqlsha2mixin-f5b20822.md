# Fact f5b20822

Store id: 78bf4f6a-c4c3-47bd-87e5-a3c9f4ef9cd5

## Text

```text
class MySQLSHA2Mixin
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
- posted_at: `2026-11-09T23:32:02.1074520+00:00`

## Data

```json
{
  "end_line": 15,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 8,
  "symbol": "MySQLSHA2Mixin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":8,"selector":"L8-L15","symbol":"MySQLSHA2Mixin"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::MySQLSHA2Mixin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 15,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 8,
    "symbol": "MySQLSHA2Mixin"
  },
  "id": "78bf4f6a-c4c3-47bd-87e5-a3c9f4ef9cd5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.1074520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 8,
        "selector": "L8-L15",
        "symbol": "MySQLSHA2Mixin"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "33e090fb-ca67-4a74-835f-9c458e602d65",
  "subject_name": "django/db/models/functions/text::MySQLSHA2Mixin",
  "tags": [
    "entity:class"
  ],
  "text": "class MySQLSHA2Mixin"
}
```
