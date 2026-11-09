# Fact a5d8f4eb

Store id: 1860c119-b063-4dff-99e7-446def7d59a6

## Text

```text
def columns(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.4834610+00:00`

## Data

```json
{
  "end_line": 90,
  "entity_kind": "method",
  "parent": "CompositePrimaryKey",
  "start_line": 88,
  "symbol": "CompositePrimaryKey.columns"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":88,"selector":"L88-L90","symbol":"CompositePrimaryKey.columns"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey.columns](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 90,
    "entity_kind": "method",
    "parent": "CompositePrimaryKey",
    "start_line": 88,
    "symbol": "CompositePrimaryKey.columns"
  },
  "id": "1860c119-b063-4dff-99e7-446def7d59a6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.4834610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 88,
        "selector": "L88-L90",
        "symbol": "CompositePrimaryKey.columns"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "951fbfa2-970d-475f-be8f-c51b4d84a80d",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.columns",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def columns(self)"
}
```
