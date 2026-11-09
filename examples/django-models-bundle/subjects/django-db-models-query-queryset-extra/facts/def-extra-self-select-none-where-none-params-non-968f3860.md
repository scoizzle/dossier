# Fact 968f3860

Store id: d0c51fa7-602f-4f1a-ac28-ab69bef1b54f

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
- posted_at: `2026-11-09T23:32:04.5903820+00:00`

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
  "id": "d0c51fa7-602f-4f1a-ac28-ab69bef1b54f",
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
    "posted_at": "2026-11-09T23:32:04.5903820+00:00"
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
  "subject_id": "dc962209-e09d-4802-adc6-a645ebbecc07",
  "subject_name": "django/db/models/query::QuerySet.extra",
  "tags": [
    "entity:method"
  ],
  "text": "def extra( self, select=None, where=None, params=None, tables=None, order_by=None, select_params=None, )"
}
```
