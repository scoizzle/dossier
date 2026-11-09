# Fact 968f3860

Store id: 44464b94-cf19-4469-af26-76451e53c126

## Text

```text
def extra( self, select=None, where=None, params=None, tables=None, order_by=None, select_params=None, )
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
- posted_at: `2026-11-09T22:39:49.6649080+00:00`

## Data

```json
{
  "end_line": 1971,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1956,
  "symbol": "QuerySet.extra"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1956,"selector":"L1956-L1971","symbol":"QuerySet.extra"}`

## Items

```json
[
  {
    "text": "Add extra SQL fragments to the query.",
    "locator": {
      "line": 1965
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.extra](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1971,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1956,
    "symbol": "QuerySet.extra"
  },
  "id": "44464b94-cf19-4469-af26-76451e53c126",
  "items": [
    {
      "locator": {
        "line": 1965
      },
      "text": "Add extra SQL fragments to the query."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.6649080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1956,
        "selector": "L1956-L1971",
        "symbol": "QuerySet.extra"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "56965b2b-5510-447e-a66e-db0295d7bf8a",
  "subject_name": "django/db/models/query::QuerySet.extra",
  "tags": [
    "entity:method"
  ],
  "text": "def extra( self, select=None, where=None, params=None, tables=None, order_by=None, select_params=None, )"
}
```
