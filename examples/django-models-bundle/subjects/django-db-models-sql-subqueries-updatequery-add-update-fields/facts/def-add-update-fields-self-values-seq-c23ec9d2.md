# Fact c23ec9d2

Store id: ccf6dbcc-99b6-4ae6-aea6-50af9f53b3fd

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
- posted_at: `2026-11-09T23:32:07.3900760+00:00`

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
  "id": "ccf6dbcc-99b6-4ae6-aea6-50af9f53b3fd",
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
    "posted_at": "2026-11-09T23:32:07.3900760+00:00"
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
  "subject_id": "6a28c7cc-1d4c-4566-9b06-791936024cd2",
  "subject_name": "django/db/models/sql/subqueries::UpdateQuery.add_update_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def add_update_fields(self, values_seq)"
}
```
