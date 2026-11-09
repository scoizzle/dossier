# Fact 81575beb

Store id: 6a9fa57b-dfee-4bb2-bc61-f37bfa98690f

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
- posted_at: `2026-11-09T23:44:48.3936760+00:00`

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
  "id": "6a9fa57b-dfee-4bb2-bc61-f37bfa98690f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.3936760+00:00"
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
  "subject_id": "0bbf23e0-5098-46dc-a6ed-cbb86dda5e91",
  "subject_name": "django/db/models/aggregates::AggregateFilter.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
