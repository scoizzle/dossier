# Fact f0fd5113

Store id: c89d646e-808c-41dd-bccd-36bfe955c671

## Text

```text
def condition(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:53.5300650+00:00`

## Data

```json
{
  "end_line": 56,
  "entity_kind": "method",
  "parent": "AggregateFilter",
  "start_line": 54,
  "symbol": "AggregateFilter.condition"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":54,"selector":"L54-L56","symbol":"AggregateFilter.condition"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::AggregateFilter.condition](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 56,
    "entity_kind": "method",
    "parent": "AggregateFilter",
    "start_line": 54,
    "symbol": "AggregateFilter.condition"
  },
  "id": "c89d646e-808c-41dd-bccd-36bfe955c671",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5300650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 54,
        "selector": "L54-L56",
        "symbol": "AggregateFilter.condition"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "1b75d907-3de5-437b-9341-1ead3b3c86bf",
  "subject_name": "django/db/models/aggregates::AggregateFilter.condition",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def condition(self)"
}
```
