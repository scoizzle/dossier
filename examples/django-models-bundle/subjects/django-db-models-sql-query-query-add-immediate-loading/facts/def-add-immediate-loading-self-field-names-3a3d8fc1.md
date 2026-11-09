# Fact 3a3d8fc1

Store id: b27f2b89-d673-424d-9831-a52dec416827

## Text

```text
def add_immediate_loading(self, field_names)
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
- posted_at: `2026-11-09T23:44:59.0214700+00:00`

## Data

```json
{
  "end_line": 2547,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2525,
  "symbol": "Query.add_immediate_loading"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2525,"selector":"L2525-L2547","symbol":"Query.add_immediate_loading"}`

## Items

```json
[
  {
    "text": "Add the given list of model field names to the set of fields to retrieve when the SQL is executed (\"immediate loading\" fields). The field names replace any existing immediate loading field names. If there are field names already specified for deferred loading, remove those names from the new field_names before storing the new names for immediate loading. (That is, immediate loading overrides any existing immediate values, but respects existing deferrals.)",
    "locator": {
      "line": 2526
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.add_immediate_loading](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2547,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2525,
    "symbol": "Query.add_immediate_loading"
  },
  "id": "b27f2b89-d673-424d-9831-a52dec416827",
  "items": [
    {
      "locator": {
        "line": 2526
      },
      "text": "Add the given list of model field names to the set of fields to retrieve when the SQL is executed (\"immediate loading\" fields). The field names replace any existing immediate loading field names. If there are field names already specified for deferred loading, remove those names from the new field_names before storing the new names for immediate loading. (That is, immediate loading overrides any existing immediate values, but respects existing deferrals.)"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.0214700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2525,
        "selector": "L2525-L2547",
        "symbol": "Query.add_immediate_loading"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "e388d65c-2e55-49b2-bcd2-78f60f17c2f5",
  "subject_name": "django/db/models/sql/query::Query.add_immediate_loading",
  "tags": [
    "entity:method"
  ],
  "text": "def add_immediate_loading(self, field_names)"
}
```
