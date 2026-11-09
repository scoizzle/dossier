# Fact 5df18f34

Store id: 8d17cd53-c0ca-4ebf-a17e-82d0cd328cc1

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
- posted_at: `2026-11-09T22:39:51.5283600+00:00`

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
  "id": "8d17cd53-c0ca-4ebf-a17e-82d0cd328cc1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.5283600+00:00"
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
  "subject_id": "adcc9f3f-5e2a-4eb0-a2b5-c592df16fb6b",
  "subject_name": "django/db/models/sql/query::Query.append_annotation_mask",
  "tags": [
    "entity:method"
  ],
  "text": "def append_annotation_mask(self, names)"
}
```
