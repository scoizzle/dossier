# Fact 692f2b2e

Store id: 23521612-7d41-4ab4-8931-715f2bc2095b

## Text

```text
def _insert( self, objs, fields, returning_fields=None, raw=False, using=None, on_conflict=None, update_fields=None, unique_fields=None, )
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
- posted_at: `2026-11-09T23:44:56.1312000+00:00`

## Data

```json
{
  "end_line": 2166,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2141,
  "symbol": "QuerySet._insert"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2141,"selector":"L2141-L2166","symbol":"QuerySet._insert"}`

## Items

```json
[
  {
    "text": "Insert a new record for the given model. This provides an interface to the InsertQuery class and is how Model.save() is implemented.",
    "locator": {
      "line": 2152
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._insert](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2166,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2141,
    "symbol": "QuerySet._insert"
  },
  "id": "23521612-7d41-4ab4-8931-715f2bc2095b",
  "items": [
    {
      "locator": {
        "line": 2152
      },
      "text": "Insert a new record for the given model. This provides an interface to the InsertQuery class and is how Model.save() is implemented."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.1312000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2141,
        "selector": "L2141-L2166",
        "symbol": "QuerySet._insert"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "461c020a-080e-4c68-b498-22e9dae2411a",
  "subject_name": "django/db/models/query::QuerySet._insert",
  "tags": [
    "entity:method"
  ],
  "text": "def _insert( self, objs, fields, returning_fields=None, raw=False, using=None, on_conflict=None, update_fields=None, unique_fields=None, )"
}
```
