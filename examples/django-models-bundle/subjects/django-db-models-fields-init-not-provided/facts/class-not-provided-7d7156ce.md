# Fact 7d7156ce

Store id: d74380da-9dbc-4ebe-b7cd-57a6b2261883

## Text

```text
class NOT_PROVIDED
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
- posted_at: `2026-11-09T23:44:49.9479610+00:00`

## Data

```json
{
  "end_line": 85,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 84,
  "symbol": "NOT_PROVIDED"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":84,"selector":"L84-L85","symbol":"NOT_PROVIDED"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::NOT_PROVIDED](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 85,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 84,
    "symbol": "NOT_PROVIDED"
  },
  "id": "d74380da-9dbc-4ebe-b7cd-57a6b2261883",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9479610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 84,
        "selector": "L84-L85",
        "symbol": "NOT_PROVIDED"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "868d8e29-db35-4122-a473-9ea117175e37",
  "subject_name": "django/db/models/fields/__init__::NOT_PROVIDED",
  "tags": [
    "entity:class"
  ],
  "text": "class NOT_PROVIDED"
}
```
