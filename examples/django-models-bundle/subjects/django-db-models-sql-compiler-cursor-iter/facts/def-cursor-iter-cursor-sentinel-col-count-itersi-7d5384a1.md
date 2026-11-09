# Fact 7d5384a1

Store id: d37ee8db-ffe5-44ee-b543-e19fd169db83

## Text

```text
def cursor_iter(cursor, sentinel, col_count, itersize)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:50.7489740+00:00`

## Data

```json
{
  "end_line": 2285,
  "entity_kind": "function",
  "parent": "compiler",
  "start_line": 2276,
  "symbol": "cursor_iter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2276,"selector":"L2276-L2285","symbol":"cursor_iter"}`

## Items

```json
[
  {
    "text": "Yield blocks of rows from a cursor and ensure the cursor is closed when done.",
    "locator": {
      "line": 2277
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::cursor_iter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2285,
    "entity_kind": "function",
    "parent": "compiler",
    "start_line": 2276,
    "symbol": "cursor_iter"
  },
  "id": "d37ee8db-ffe5-44ee-b543-e19fd169db83",
  "items": [
    {
      "locator": {
        "line": 2277
      },
      "text": "Yield blocks of rows from a cursor and ensure the cursor is closed when done."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.7489740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2276,
        "selector": "L2276-L2285",
        "symbol": "cursor_iter"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "f224fb81-4641-4f5d-9270-75cbb02fc636",
  "subject_name": "django/db/models/sql/compiler::cursor_iter",
  "tags": [
    "entity:function"
  ],
  "text": "def cursor_iter(cursor, sentinel, col_count, itersize)"
}
```
