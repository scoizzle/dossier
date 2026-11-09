# Fact 77d3f7d4

Store id: 5ef327e8-eafb-4f5f-8746-4b53ea24daa8

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
- posted_at: `2026-11-09T23:32:07.5911250+00:00`

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
  "id": "5ef327e8-eafb-4f5f-8746-4b53ea24daa8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.5911250+00:00"
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
  "subject_id": "cdbb36e1-17a2-4c46-a8ae-c95fafd96241",
  "subject_name": "django/db/models/sql/where::WhereNode.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
