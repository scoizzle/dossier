# Fact b7986a1f

Store id: e510837d-735d-4df6-af96-5d43496b0205

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
- posted_at: `2026-11-09T23:32:07.6257430+00:00`

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
  "id": "e510837d-735d-4df6-af96-5d43496b0205",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.6257430+00:00"
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
  "subject_id": "afdeccc8-6f04-4e25-988c-31922b4afa99",
  "subject_name": "django/db/models/sql/where::WhereNode.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, change_map)"
}
```
