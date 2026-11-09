# Fact b7986a1f

Store id: 7518fcaa-e4ac-4972-8778-c229438a935f

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
- posted_at: `2026-11-09T23:44:59.7385280+00:00`

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
  "id": "7518fcaa-e4ac-4972-8778-c229438a935f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.7385280+00:00"
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
  "subject_id": "5e830a83-d4b1-417c-ab1c-f833b14e3261",
  "subject_name": "django/db/models/sql/where::WhereNode.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, change_map)"
}
```
