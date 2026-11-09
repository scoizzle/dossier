# Fact a80188c8

Store id: fbcac01d-41c3-4f31-ba99-34af58cd7f20

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
- posted_at: `2026-11-09T23:32:07.1130830+00:00`

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
  "id": "fbcac01d-41c3-4f31-ba99-34af58cd7f20",
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
    "posted_at": "2026-11-09T23:32:07.1130830+00:00"
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
  "subject_id": "5fefedbc-320b-4cfa-b46c-c92e2829cff6",
  "subject_name": "django/db/models/sql/query::Query.set_annotation_mask",
  "tags": [
    "entity:method"
  ],
  "text": "def set_annotation_mask(self, names)"
}
```
