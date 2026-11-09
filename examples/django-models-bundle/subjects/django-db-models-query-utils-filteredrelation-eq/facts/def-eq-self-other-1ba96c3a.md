# Fact 1ba96c3a

Store id: 7a1e013d-7e45-4c3c-8349-14a66c5f0f8c

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T23:44:56.7469430+00:00`

## Data

```json
{
  "end_line": 543,
  "entity_kind": "method",
  "parent": "FilteredRelation",
  "start_line": 536,
  "symbol": "FilteredRelation.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":536,"selector":"L536-L543","symbol":"FilteredRelation.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::FilteredRelation.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 543,
    "entity_kind": "method",
    "parent": "FilteredRelation",
    "start_line": 536,
    "symbol": "FilteredRelation.__eq__"
  },
  "id": "7a1e013d-7e45-4c3c-8349-14a66c5f0f8c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.7469430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 536,
        "selector": "L536-L543",
        "symbol": "FilteredRelation.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "44f8b1e3-a6f9-410f-8dc7-69394c014402",
  "subject_name": "django/db/models/query_utils::FilteredRelation.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
