# Fact caf82d24

Store id: f2db9f2d-b568-439e-a7d6-f1cabe5fb7a6

## Text

```text
def __hash__(self)
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
- posted_at: `2026-11-09T22:39:51.0304720+00:00`

## Data

```json
{
  "end_line": 222,
  "entity_kind": "method",
  "parent": "BaseTable",
  "start_line": 221,
  "symbol": "BaseTable.__hash__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":221,"selector":"L221-L222","symbol":"BaseTable.__hash__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::BaseTable.__hash__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 222,
    "entity_kind": "method",
    "parent": "BaseTable",
    "start_line": 221,
    "symbol": "BaseTable.__hash__"
  },
  "id": "f2db9f2d-b568-439e-a7d6-f1cabe5fb7a6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.0304720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 221,
        "selector": "L221-L222",
        "symbol": "BaseTable.__hash__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "05351dd8-ff06-425a-a9ee-8629243334da",
  "subject_name": "django/db/models/sql/datastructures::BaseTable.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
