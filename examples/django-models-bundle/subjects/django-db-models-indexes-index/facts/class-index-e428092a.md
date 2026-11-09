# Fact e428092a

Store id: 3518b450-77ce-4999-86b4-eb4e445664f9

## Text

```text
class Index
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
- posted_at: `2026-11-09T22:39:47.7490250+00:00`

## Data

```json
{
  "end_line": 304,
  "entity_kind": "class",
  "parent": "indexes",
  "start_line": 14,
  "symbol": "Index"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":14,"selector":"L14-L304","symbol":"Index"}`

## Referenced by

None.

## Subject

[django/db/models/indexes::Index](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 304,
    "entity_kind": "class",
    "parent": "indexes",
    "start_line": 14,
    "symbol": "Index"
  },
  "id": "3518b450-77ce-4999-86b4-eb4e445664f9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.7490250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 14,
        "selector": "L14-L304",
        "symbol": "Index"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "63b81bce-73eb-42b3-8692-7d60d19a98bf",
  "subject_name": "django/db/models/indexes::Index",
  "tags": [
    "entity:class"
  ],
  "text": "class Index"
}
```
