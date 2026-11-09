# Fact e98f01cb

Store id: 94e1492e-7b25-43fe-8205-3fd03da69371

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
- posted_at: `2026-11-09T22:39:50.9909360+00:00`

## Data

```json
{
  "end_line": 150,
  "entity_kind": "method",
  "parent": "Join",
  "start_line": 135,
  "symbol": "Join.relabeled_clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":135,"selector":"L135-L150","symbol":"Join.relabeled_clone"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::Join.relabeled_clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 150,
    "entity_kind": "method",
    "parent": "Join",
    "start_line": 135,
    "symbol": "Join.relabeled_clone"
  },
  "id": "94e1492e-7b25-43fe-8205-3fd03da69371",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.9909360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 135,
        "selector": "L135-L150",
        "symbol": "Join.relabeled_clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "79e7de6e-f1e8-4a7c-bc48-cd3e4a4f5abd",
  "subject_name": "django/db/models/sql/datastructures::Join.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, change_map)"
}
```
