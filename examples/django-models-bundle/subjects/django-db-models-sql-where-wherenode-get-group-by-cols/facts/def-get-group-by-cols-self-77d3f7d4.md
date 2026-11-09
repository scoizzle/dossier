# Fact 77d3f7d4

Store id: b85f72e8-f37e-4ae1-8023-26639aa28dd9

## Text

```text
def get_group_by_cols(self)
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
- posted_at: `2026-11-09T22:39:51.9015350+00:00`

## Data

```json
{
  "end_line": 194,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 190,
  "symbol": "WhereNode.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":190,"selector":"L190-L194","symbol":"WhereNode.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 194,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 190,
    "symbol": "WhereNode.get_group_by_cols"
  },
  "id": "b85f72e8-f37e-4ae1-8023-26639aa28dd9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.9015350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 190,
        "selector": "L190-L194",
        "symbol": "WhereNode.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "39befe6f-c586-4a72-8459-ccdd68e05f1e",
  "subject_name": "django/db/models/sql/where::WhereNode.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
