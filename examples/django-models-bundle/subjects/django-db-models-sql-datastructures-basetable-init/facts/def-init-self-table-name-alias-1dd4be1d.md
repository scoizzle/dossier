# Fact 1dd4be1d

Store id: 7e2058a8-1943-49f6-a52f-b0e05ee5200e

## Text

```text
def __init__(self, table_name, alias)
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
- posted_at: `2026-11-09T22:39:51.0150460+00:00`

## Data

```json
{
  "end_line": 195,
  "entity_kind": "method",
  "parent": "BaseTable",
  "start_line": 193,
  "symbol": "BaseTable.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":193,"selector":"L193-L195","symbol":"BaseTable.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::BaseTable.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 195,
    "entity_kind": "method",
    "parent": "BaseTable",
    "start_line": 193,
    "symbol": "BaseTable.__init__"
  },
  "id": "7e2058a8-1943-49f6-a52f-b0e05ee5200e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.0150460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 193,
        "selector": "L193-L195",
        "symbol": "BaseTable.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "6c8a1f93-9b31-4f85-bafb-8815fed8c327",
  "subject_name": "django/db/models/sql/datastructures::BaseTable.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, table_name, alias)"
}
```
