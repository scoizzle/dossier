# Fact a80188c8

Store id: 744b8d86-b17a-4a20-bbaf-71d1eed1f4a4

## Text

```text
def set_annotation_mask(self, names)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:51.5243980+00:00`

## Data

```json
{
  "end_line": 2566,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2549,
  "symbol": "Query.set_annotation_mask"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2549,"selector":"L2549-L2566","symbol":"Query.set_annotation_mask"}`

## Items

```json
[
  {
    "text": "Set the mask of annotations that will be returned by the SELECT.",
    "locator": {
      "line": 2550
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.set_annotation_mask](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2566,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2549,
    "symbol": "Query.set_annotation_mask"
  },
  "id": "744b8d86-b17a-4a20-bbaf-71d1eed1f4a4",
  "items": [
    {
      "locator": {
        "line": 2550
      },
      "text": "Set the mask of annotations that will be returned by the SELECT."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.5243980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2549,
        "selector": "L2549-L2566",
        "symbol": "Query.set_annotation_mask"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "5e5a6c8f-92e4-4304-8f54-0b02fe80b538",
  "subject_name": "django/db/models/sql/query::Query.set_annotation_mask",
  "tags": [
    "entity:method"
  ],
  "text": "def set_annotation_mask(self, names)"
}
```
