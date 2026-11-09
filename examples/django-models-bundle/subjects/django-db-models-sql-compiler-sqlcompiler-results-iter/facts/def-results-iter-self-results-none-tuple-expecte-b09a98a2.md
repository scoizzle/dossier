# Fact b09a98a2

Store id: c6683881-15f7-4879-a144-f9676c3015c7

## Text

```text
def results_iter( self, results=None, tuple_expected=False, chunked_fetch=False, chunk_size=GET_ITERATOR_CHUNK_SIZE, )
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
- posted_at: `2026-11-09T22:39:50.6766990+00:00`

## Data

```json
{
  "end_line": 1604,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 1583,
  "symbol": "SQLCompiler.results_iter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1583,"selector":"L1583-L1604","symbol":"SQLCompiler.results_iter"}`

## Items

```json
[
  {
    "text": "Return an iterator over the results from executing this query.",
    "locator": {
      "line": 1590
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.results_iter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1604,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 1583,
    "symbol": "SQLCompiler.results_iter"
  },
  "id": "c6683881-15f7-4879-a144-f9676c3015c7",
  "items": [
    {
      "locator": {
        "line": 1590
      },
      "text": "Return an iterator over the results from executing this query."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.6766990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1583,
        "selector": "L1583-L1604",
        "symbol": "SQLCompiler.results_iter"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "f6900ca8-c89f-4edd-98e1-56ad41be09b0",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.results_iter",
  "tags": [
    "entity:method"
  ],
  "text": "def results_iter( self, results=None, tuple_expected=False, chunked_fetch=False, chunk_size=GET_ITERATOR_CHUNK_SIZE, )"
}
```
