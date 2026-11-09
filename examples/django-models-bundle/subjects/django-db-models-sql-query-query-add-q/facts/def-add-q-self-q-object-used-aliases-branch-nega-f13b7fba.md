# Fact f13b7fba

Store id: 4aa4f6fa-bdc2-4988-8db6-97698e2e7bb4

## Text

```text
def _add_q( self, q_object, used_aliases, branch_negated=False, current_negated=False, allow_joins=True, split_subq=True, check_filterable=True, summarize=False, update_join_types=True, )
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
- posted_at: `2026-11-09T23:32:06.9542720+00:00`

## Data

```json
{
  "end_line": 1730,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1691,
  "symbol": "Query._add_q"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1691,"selector":"L1691-L1730","symbol":"Query._add_q"}`

## Items

```json
[
  {
    "text": "Add a Q-object to the current filter.",
    "locator": {
      "line": 1703
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query._add_q](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1730,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1691,
    "symbol": "Query._add_q"
  },
  "id": "4aa4f6fa-bdc2-4988-8db6-97698e2e7bb4",
  "items": [
    {
      "locator": {
        "line": 1703
      },
      "text": "Add a Q-object to the current filter."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.9542720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1691,
        "selector": "L1691-L1730",
        "symbol": "Query._add_q"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "5bbe7928-1cdf-4be6-ac28-6879e78b3c1e",
  "subject_name": "django/db/models/sql/query::Query._add_q",
  "tags": [
    "entity:method"
  ],
  "text": "def _add_q( self, q_object, used_aliases, branch_negated=False, current_negated=False, allow_joins=True, split_subq=True, check_filterable=True, summarize=False, update_join_types=True, )"
}
```
