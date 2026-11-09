# Fact 2e99f336

Store id: 279d7b52-dada-4e6b-be4c-ae657c518a26

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
- posted_at: `2026-11-09T23:32:06.4926670+00:00`

## Data

```json
{
  "end_line": 210,
  "entity_kind": "method",
  "parent": "BaseTable",
  "start_line": 207,
  "symbol": "BaseTable.relabeled_clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":207,"selector":"L207-L210","symbol":"BaseTable.relabeled_clone"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::BaseTable.relabeled_clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 210,
    "entity_kind": "method",
    "parent": "BaseTable",
    "start_line": 207,
    "symbol": "BaseTable.relabeled_clone"
  },
  "id": "279d7b52-dada-4e6b-be4c-ae657c518a26",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.4926670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 207,
        "selector": "L207-L210",
        "symbol": "BaseTable.relabeled_clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "930c7b1d-bd68-4800-bdbe-28769bd2e6f3",
  "subject_name": "django/db/models/sql/datastructures::BaseTable.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, change_map)"
}
```
