# Fact 836f281e

Store id: 87492c29-bf92-4fb7-b254-ca2635c315c4

## Text

```text
def relabeled_clone(self, change_map)
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
- posted_at: `2026-11-09T22:39:50.1946110+00:00`

## Data

```json
{
  "end_line": 556,
  "entity_kind": "method",
  "parent": "FilteredRelation",
  "start_line": 552,
  "symbol": "FilteredRelation.relabeled_clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":552,"selector":"L552-L556","symbol":"FilteredRelation.relabeled_clone"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::FilteredRelation.relabeled_clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 556,
    "entity_kind": "method",
    "parent": "FilteredRelation",
    "start_line": 552,
    "symbol": "FilteredRelation.relabeled_clone"
  },
  "id": "87492c29-bf92-4fb7-b254-ca2635c315c4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.1946110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 552,
        "selector": "L552-L556",
        "symbol": "FilteredRelation.relabeled_clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "60f37d9e-81ee-4f7f-807f-bb6a604146bb",
  "subject_name": "django/db/models/query_utils::FilteredRelation.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, change_map)"
}
```
