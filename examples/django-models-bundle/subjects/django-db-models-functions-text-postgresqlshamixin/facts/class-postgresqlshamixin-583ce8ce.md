# Fact 583ce8ce

Store id: 4cf5c968-fcf9-41cd-b344-fa00e4264d4d

## Text

```text
class PostgreSQLSHAMixin
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
- posted_at: `2026-11-09T22:39:47.0482190+00:00`

## Data

```json
{
  "end_line": 39,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 31,
  "symbol": "PostgreSQLSHAMixin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":31,"selector":"L31-L39","symbol":"PostgreSQLSHAMixin"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::PostgreSQLSHAMixin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 39,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 31,
    "symbol": "PostgreSQLSHAMixin"
  },
  "id": "4cf5c968-fcf9-41cd-b344-fa00e4264d4d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.0482190+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 31,
        "selector": "L31-L39",
        "symbol": "PostgreSQLSHAMixin"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "afb3e859-2231-49ee-b1f9-3c028576508b",
  "subject_name": "django/db/models/functions/text::PostgreSQLSHAMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class PostgreSQLSHAMixin"
}
```
