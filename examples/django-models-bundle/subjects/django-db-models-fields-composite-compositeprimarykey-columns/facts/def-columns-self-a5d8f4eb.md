# Fact a5d8f4eb

Store id: 0e993ab3-198c-4b67-9264-8447abf5a489

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
- posted_at: `2026-11-09T22:39:42.9991120+00:00`

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
  "id": "0e993ab3-198c-4b67-9264-8447abf5a489",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.9991120+00:00"
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
  "subject_id": "f6093e1e-ea4a-47ac-8733-4f978944bf73",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.columns",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def columns(self)"
}
```
