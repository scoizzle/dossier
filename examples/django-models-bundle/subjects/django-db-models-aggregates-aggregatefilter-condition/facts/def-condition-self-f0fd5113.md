# Fact f0fd5113

Store id: f86c11eb-b0dc-4c1d-a070-d07876120b05

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
- posted_at: `2026-11-09T22:39:40.0295320+00:00`

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
  "id": "f86c11eb-b0dc-4c1d-a070-d07876120b05",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0295320+00:00"
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
  "subject_id": "dc2be3d1-d8a8-4461-80d3-eb565268c584",
  "subject_name": "django/db/models/aggregates::AggregateFilter.condition",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def condition(self)"
}
```
