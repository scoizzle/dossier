# Fact b7986a1f

Store id: 0ab98662-73e7-4c2c-bab7-913f6b5d3a2c

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
- posted_at: `2026-11-09T22:39:51.9268170+00:00`

## Data

```json
{
  "end_line": 228,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 225,
  "symbol": "WhereNode.relabeled_clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":225,"selector":"L225-L228","symbol":"WhereNode.relabeled_clone"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode.relabeled_clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 228,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 225,
    "symbol": "WhereNode.relabeled_clone"
  },
  "id": "0ab98662-73e7-4c2c-bab7-913f6b5d3a2c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.9268170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 225,
        "selector": "L225-L228",
        "symbol": "WhereNode.relabeled_clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "30ad79de-9a71-4d8a-b987-28663edf5ec3",
  "subject_name": "django/db/models/sql/where::WhereNode.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, change_map)"
}
```
