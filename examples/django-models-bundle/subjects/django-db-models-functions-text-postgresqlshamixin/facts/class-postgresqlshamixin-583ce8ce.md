# Fact 583ce8ce

Store id: ef81dda5-9bc9-4594-90fd-e261469e05f8

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
- posted_at: `2026-11-09T23:44:54.0385230+00:00`

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
  "id": "ef81dda5-9bc9-4594-90fd-e261469e05f8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.0385230+00:00"
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
  "subject_id": "b046992c-6e09-4ce5-a343-1c090e43ba29",
  "subject_name": "django/db/models/functions/text::PostgreSQLSHAMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class PostgreSQLSHAMixin"
}
```
