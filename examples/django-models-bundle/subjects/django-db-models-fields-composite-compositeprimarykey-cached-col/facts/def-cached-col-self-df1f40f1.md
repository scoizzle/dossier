# Fact df1f40f1

Store id: c00006f0-c0e1-4fb7-aaf3-3dfa7f4c2f85

## Text

```text
def cached_col(self)
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
- posted_at: `2026-11-09T23:44:50.4915420+00:00`

## Data

```json
{
  "end_line": 108,
  "entity_kind": "method",
  "parent": "CompositePrimaryKey",
  "start_line": 106,
  "symbol": "CompositePrimaryKey.cached_col"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":106,"selector":"L106-L108","symbol":"CompositePrimaryKey.cached_col"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey.cached_col](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 108,
    "entity_kind": "method",
    "parent": "CompositePrimaryKey",
    "start_line": 106,
    "symbol": "CompositePrimaryKey.cached_col"
  },
  "id": "c00006f0-c0e1-4fb7-aaf3-3dfa7f4c2f85",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.4915420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 106,
        "selector": "L106-L108",
        "symbol": "CompositePrimaryKey.cached_col"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "672655d5-e4b8-4a1a-b723-e03c84b2d772",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.cached_col",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def cached_col(self)"
}
```
