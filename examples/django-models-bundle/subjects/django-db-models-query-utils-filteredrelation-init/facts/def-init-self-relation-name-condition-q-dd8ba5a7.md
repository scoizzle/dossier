# Fact dd8ba5a7

Store id: 3304c4a5-5bbf-41f6-b27b-08ed37da9230

## Text

```text
def __init__(self, relation_name, *, condition=Q())
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
- posted_at: `2026-11-09T22:39:50.1857080+00:00`

## Data

```json
{
  "end_line": 534,
  "entity_kind": "method",
  "parent": "FilteredRelation",
  "start_line": 523,
  "symbol": "FilteredRelation.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":523,"selector":"L523-L534","symbol":"FilteredRelation.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::FilteredRelation.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 534,
    "entity_kind": "method",
    "parent": "FilteredRelation",
    "start_line": 523,
    "symbol": "FilteredRelation.__init__"
  },
  "id": "3304c4a5-5bbf-41f6-b27b-08ed37da9230",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.1857080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 523,
        "selector": "L523-L534",
        "symbol": "FilteredRelation.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "3a4db227-334f-499a-a25f-81b653f18106",
  "subject_name": "django/db/models/query_utils::FilteredRelation.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, relation_name, *, condition=Q())"
}
```
