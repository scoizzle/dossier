# Fact dd8ba5a7

Store id: 836187b9-e2e2-499d-93c7-7b23e703af56

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
- posted_at: `2026-11-09T23:32:05.2039700+00:00`

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
  "id": "836187b9-e2e2-499d-93c7-7b23e703af56",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.2039700+00:00"
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
  "subject_id": "2af77f13-5822-4e20-a204-0c5ad014ebf6",
  "subject_name": "django/db/models/query_utils::FilteredRelation.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, relation_name, *, condition=Q())"
}
```
