# Fact df1f40f1

Store id: e3d114fb-b023-443a-a7cf-2750dd515bd8

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
- posted_at: `2026-11-09T22:39:43.0118210+00:00`

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
  "id": "e3d114fb-b023-443a-a7cf-2750dd515bd8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.0118210+00:00"
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
  "subject_id": "99e1d5c3-cb4a-4ca3-a770-1ce36c45d843",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.cached_col",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def cached_col(self)"
}
```
