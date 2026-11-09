# Fact 81575beb

Store id: c2fef09a-771f-418f-b169-915a2fe4efbb

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
- posted_at: `2026-11-09T23:31:53.5304750+00:00`

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
  "id": "c2fef09a-771f-418f-b169-915a2fe4efbb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5304750+00:00"
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
  "subject_id": "12b545e6-faf4-4b1f-890e-7db5010a49b6",
  "subject_name": "django/db/models/aggregates::AggregateFilter.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
