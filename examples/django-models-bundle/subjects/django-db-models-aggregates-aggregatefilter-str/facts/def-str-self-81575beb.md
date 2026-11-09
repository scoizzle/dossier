# Fact 81575beb

Store id: bbd76823-b30a-458e-bd2d-139a89ad9aa4

## Text

```text
def __str__(self)
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
- posted_at: `2026-11-09T22:39:40.0301720+00:00`

## Data

```json
{
  "end_line": 59,
  "entity_kind": "method",
  "parent": "AggregateFilter",
  "start_line": 58,
  "symbol": "AggregateFilter.__str__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":58,"selector":"L58-L59","symbol":"AggregateFilter.__str__"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::AggregateFilter.__str__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 59,
    "entity_kind": "method",
    "parent": "AggregateFilter",
    "start_line": 58,
    "symbol": "AggregateFilter.__str__"
  },
  "id": "bbd76823-b30a-458e-bd2d-139a89ad9aa4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0301720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 58,
        "selector": "L58-L59",
        "symbol": "AggregateFilter.__str__"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "9c030af7-dae2-4529-a322-512cc7ff21c2",
  "subject_name": "django/db/models/aggregates::AggregateFilter.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
