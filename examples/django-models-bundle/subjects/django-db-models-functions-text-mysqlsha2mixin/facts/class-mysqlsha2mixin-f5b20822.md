# Fact f5b20822

Store id: 6825942a-2fdf-45ea-866a-60129dc3f3e2

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
- posted_at: `2026-11-09T23:44:54.0189760+00:00`

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
  "id": "6825942a-2fdf-45ea-866a-60129dc3f3e2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.0189760+00:00"
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
  "subject_id": "4669df76-ade3-432e-9ff8-c1e89dc517c9",
  "subject_name": "django/db/models/functions/text::MySQLSHA2Mixin",
  "tags": [
    "entity:class"
  ],
  "text": "class MySQLSHA2Mixin"
}
```
