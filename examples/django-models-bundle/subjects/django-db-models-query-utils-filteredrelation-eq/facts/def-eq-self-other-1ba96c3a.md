# Fact 1ba96c3a

Store id: 72cc7506-3e70-416c-9b1a-5a4eb97eb924

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
- posted_at: `2026-11-09T22:39:50.1884180+00:00`

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
  "id": "72cc7506-3e70-416c-9b1a-5a4eb97eb924",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.1884180+00:00"
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
  "subject_id": "b9c79c3a-ab55-4b1e-ab06-32a5d834ec73",
  "subject_name": "django/db/models/query_utils::FilteredRelation.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
