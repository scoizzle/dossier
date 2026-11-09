# Fact 63e74cb0

Store id: 14f06c53-d841-4bd1-9025-bd09813ef07f

## Text

```text
def annotation_select(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:07.1362770+00:00`

## Data

```json
{
  "end_line": 2680,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2662,
  "symbol": "Query.annotation_select"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2662,"selector":"L2662-L2680","symbol":"Query.annotation_select"}`

## Items

```json
[
  {
    "text": "Return the dictionary of aggregate columns that are not masked and should be used in the SELECT clause. Cache this result for performance.",
    "locator": {
      "line": 2664
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.annotation_select](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2680,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2662,
    "symbol": "Query.annotation_select"
  },
  "id": "14f06c53-d841-4bd1-9025-bd09813ef07f",
  "items": [
    {
      "locator": {
        "line": 2664
      },
      "text": "Return the dictionary of aggregate columns that are not masked and should be used in the SELECT clause. Cache this result for performance."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.1362770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2662,
        "selector": "L2662-L2680",
        "symbol": "Query.annotation_select"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "28f2d905-9fff-44b0-b97b-0f6d1748f7cc",
  "subject_name": "django/db/models/sql/query::Query.annotation_select",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def annotation_select(self)"
}
```
