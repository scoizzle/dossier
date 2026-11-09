# Fact 893449d3

Store id: 66f0bc01-5171-4063-b331-e53f5d3f4578

## Text

```text
def add_deferred_loading(self, field_names)
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
- posted_at: `2026-11-09T23:44:59.0161530+00:00`

## Data

```json
{
  "end_line": 2523,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2500,
  "symbol": "Query.add_deferred_loading"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2500,"selector":"L2500-L2523","symbol":"Query.add_deferred_loading"}`

## Items

```json
[
  {
    "text": "Add the given list of model field names to the set of fields to exclude from loading from the database when automatic column selection is done. Add the new field names to any existing field names that are deferred (or removed from any existing field names that are marked as the only ones for immediate loading).",
    "locator": {
      "line": 2501
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.add_deferred_loading](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2523,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2500,
    "symbol": "Query.add_deferred_loading"
  },
  "id": "66f0bc01-5171-4063-b331-e53f5d3f4578",
  "items": [
    {
      "locator": {
        "line": 2501
      },
      "text": "Add the given list of model field names to the set of fields to exclude from loading from the database when automatic column selection is done. Add the new field names to any existing field names that are deferred (or removed from any existing field names that are marked as the only ones for immediate loading)."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.0161530+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2500,
        "selector": "L2500-L2523",
        "symbol": "Query.add_deferred_loading"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "4389c9e4-9be6-4cc3-85d7-e0e04699bdfb",
  "subject_name": "django/db/models/sql/query::Query.add_deferred_loading",
  "tags": [
    "entity:method"
  ],
  "text": "def add_deferred_loading(self, field_names)"
}
```
