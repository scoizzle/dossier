# Fact 2c171f21

Store id: 236f6f90-3638-4d4e-ad12-9fd3e8507888

## Text

```text
def add_fields(self, field_names, allow_m2m=True)
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
- posted_at: `2026-11-09T23:44:58.9780060+00:00`

## Data

```json
{
  "end_line": 2324,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2267,
  "symbol": "Query.add_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2267,"selector":"L2267-L2324","symbol":"Query.add_fields"}`

## Items

```json
[
  {
    "text": "Add the given (model) fields to the select set. Add the field names in the order specified.",
    "locator": {
      "line": 2268
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.add_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2324,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2267,
    "symbol": "Query.add_fields"
  },
  "id": "236f6f90-3638-4d4e-ad12-9fd3e8507888",
  "items": [
    {
      "locator": {
        "line": 2268
      },
      "text": "Add the given (model) fields to the select set. Add the field names in the order specified."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.9780060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2267,
        "selector": "L2267-L2324",
        "symbol": "Query.add_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "8c7f142d-f757-44a4-843e-3c2eff5adf18",
  "subject_name": "django/db/models/sql/query::Query.add_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def add_fields(self, field_names, allow_m2m=True)"
}
```
