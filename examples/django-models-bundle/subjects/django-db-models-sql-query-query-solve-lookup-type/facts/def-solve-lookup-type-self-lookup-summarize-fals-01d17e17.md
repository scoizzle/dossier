# Fact 01d17e17

Store id: 1004a426-a82d-47be-bee7-f5680f8345c1

## Text

```text
def solve_lookup_type(self, lookup, summarize=False)
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
- posted_at: `2026-11-09T23:32:06.9126690+00:00`

## Data

```json
{
  "end_line": 1364,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1343,
  "symbol": "Query.solve_lookup_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1343,"selector":"L1343-L1364","symbol":"Query.solve_lookup_type"}`

## Items

```json
[
  {
    "text": "Solve the lookup type from the lookup (e.g.: 'foobar__id__icontains').",
    "locator": {
      "line": 1344
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.solve_lookup_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1364,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1343,
    "symbol": "Query.solve_lookup_type"
  },
  "id": "1004a426-a82d-47be-bee7-f5680f8345c1",
  "items": [
    {
      "locator": {
        "line": 1344
      },
      "text": "Solve the lookup type from the lookup (e.g.: 'foobar__id__icontains')."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.9126690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1343,
        "selector": "L1343-L1364",
        "symbol": "Query.solve_lookup_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "fbead622-6546-4e90-8dfa-8f7d7d07c0e6",
  "subject_name": "django/db/models/sql/query::Query.solve_lookup_type",
  "tags": [
    "entity:method"
  ],
  "text": "def solve_lookup_type(self, lookup, summarize=False)"
}
```
