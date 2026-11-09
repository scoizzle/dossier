# Fact 15ecfa40

Store id: 4bcfefa7-88ad-4a32-bed5-fe66d76abcd3

## Text

```text
def get_lookup(self, lookup)
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
- posted_at: `2026-11-09T23:44:59.8158130+00:00`

## Data

```json
{
  "end_line": 314,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 313,
  "symbol": "WhereNode.get_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":313,"selector":"L313-L314","symbol":"WhereNode.get_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode.get_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 314,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 313,
    "symbol": "WhereNode.get_lookup"
  },
  "id": "4bcfefa7-88ad-4a32-bed5-fe66d76abcd3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.8158130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 313,
        "selector": "L313-L314",
        "symbol": "WhereNode.get_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "fc565a2a-2c42-4ab1-94f1-cebcda408c34",
  "subject_name": "django/db/models/sql/where::WhereNode.get_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_lookup(self, lookup)"
}
```
