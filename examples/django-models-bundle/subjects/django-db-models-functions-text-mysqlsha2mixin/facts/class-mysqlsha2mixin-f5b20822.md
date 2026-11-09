# Fact f5b20822

Store id: ea5afe8c-2b92-46cd-8084-ab7a00129646

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
- posted_at: `2026-11-09T22:39:47.0292140+00:00`

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
  "id": "ea5afe8c-2b92-46cd-8084-ab7a00129646",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.0292140+00:00"
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
  "subject_id": "f899b20d-aa74-4673-8c89-f319ce8e1bfb",
  "subject_name": "django/db/models/functions/text::MySQLSHA2Mixin",
  "tags": [
    "entity:class"
  ],
  "text": "class MySQLSHA2Mixin"
}
```
