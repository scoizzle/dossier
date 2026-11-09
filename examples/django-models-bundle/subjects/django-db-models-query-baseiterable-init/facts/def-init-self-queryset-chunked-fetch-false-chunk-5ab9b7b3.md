# Fact 5ab9b7b3

Store id: 3cfa51a6-965d-4789-8d78-b92f58e3ceff

## Text

```text
def __init__( self, queryset, chunked_fetch=False, chunk_size=GET_ITERATOR_CHUNK_SIZE )
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
- posted_at: `2026-11-09T23:44:55.7599990+00:00`

## Data

```json
{
  "end_line": 91,
  "entity_kind": "method",
  "parent": "BaseIterable",
  "start_line": 86,
  "symbol": "BaseIterable.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":86,"selector":"L86-L91","symbol":"BaseIterable.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/query::BaseIterable.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 91,
    "entity_kind": "method",
    "parent": "BaseIterable",
    "start_line": 86,
    "symbol": "BaseIterable.__init__"
  },
  "id": "3cfa51a6-965d-4789-8d78-b92f58e3ceff",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.7599990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 86,
        "selector": "L86-L91",
        "symbol": "BaseIterable.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "3fae0619-d816-4944-9018-02373cf1066f",
  "subject_name": "django/db/models/query::BaseIterable.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, queryset, chunked_fetch=False, chunk_size=GET_ITERATOR_CHUNK_SIZE )"
}
```
