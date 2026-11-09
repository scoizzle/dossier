# Fact f0fd5113

Store id: 14c2aac5-c6f5-40ae-93b3-15d68006a4d8

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
- posted_at: `2026-11-09T23:44:48.3931290+00:00`

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
  "id": "14c2aac5-c6f5-40ae-93b3-15d68006a4d8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.3931290+00:00"
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
  "subject_id": "6c8dc9c1-0e26-412f-aefd-cb722a4f3507",
  "subject_name": "django/db/models/aggregates::AggregateFilter.condition",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def condition(self)"
}
```
