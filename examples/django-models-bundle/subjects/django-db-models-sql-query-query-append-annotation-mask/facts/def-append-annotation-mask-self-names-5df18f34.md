# Fact 5df18f34

Store id: 0cff65cb-4383-4cfe-b8a7-6937a6005b11

## Text

```text
def append_annotation_mask(self, names)
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
- posted_at: `2026-11-09T23:44:59.0293530+00:00`

## Data

```json
{
  "end_line": 2570,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2568,
  "symbol": "Query.append_annotation_mask"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2568,"selector":"L2568-L2570","symbol":"Query.append_annotation_mask"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.append_annotation_mask](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2570,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2568,
    "symbol": "Query.append_annotation_mask"
  },
  "id": "0cff65cb-4383-4cfe-b8a7-6937a6005b11",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.0293530+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2568,
        "selector": "L2568-L2570",
        "symbol": "Query.append_annotation_mask"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "ddb379fe-d026-48d7-be4a-3418de13b4f3",
  "subject_name": "django/db/models/sql/query::Query.append_annotation_mask",
  "tags": [
    "entity:method"
  ],
  "text": "def append_annotation_mask(self, names)"
}
```
