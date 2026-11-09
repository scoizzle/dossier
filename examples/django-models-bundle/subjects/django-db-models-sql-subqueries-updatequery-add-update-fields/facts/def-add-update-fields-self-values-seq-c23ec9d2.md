# Fact c23ec9d2

Store id: c54e867d-b583-41c6-9a6e-66552824e12f

## Text

```text
def add_update_fields(self, values_seq)
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
- posted_at: `2026-11-09T23:44:59.4091960+00:00`

## Data

```json
{
  "end_line": 120,
  "entity_kind": "method",
  "parent": "UpdateQuery",
  "start_line": 106,
  "symbol": "UpdateQuery.add_update_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/subqueries.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":106,"selector":"L106-L120","symbol":"UpdateQuery.add_update_fields"}`

## Items

```json
[
  {
    "text": "Append a sequence of (field, model, value) triples to the internal list that will be used to generate the UPDATE query. Might be more usefully called add_update_targets() to hint at the extra information here.",
    "locator": {
      "line": 107
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/subqueries::UpdateQuery.add_update_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 120,
    "entity_kind": "method",
    "parent": "UpdateQuery",
    "start_line": 106,
    "symbol": "UpdateQuery.add_update_fields"
  },
  "id": "c54e867d-b583-41c6-9a6e-66552824e12f",
  "items": [
    {
      "locator": {
        "line": 107
      },
      "text": "Append a sequence of (field, model, value) triples to the internal list that will be used to generate the UPDATE query. Might be more usefully called add_update_targets() to hint at the extra information here."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.4091960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 106,
        "selector": "L106-L120",
        "symbol": "UpdateQuery.add_update_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/subqueries.py"
    }
  ],
  "status": "live",
  "subject_id": "b9d679e3-f285-4be4-99b3-0eabdc88cced",
  "subject_name": "django/db/models/sql/subqueries::UpdateQuery.add_update_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def add_update_fields(self, values_seq)"
}
```
