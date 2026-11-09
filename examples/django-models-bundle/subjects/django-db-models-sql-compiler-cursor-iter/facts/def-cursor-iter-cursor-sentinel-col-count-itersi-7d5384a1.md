# Fact 7d5384a1

Store id: 725339ef-91cd-4f5c-9d99-04cc551ba17e

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
- posted_at: `2026-11-09T23:32:06.1123740+00:00`

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
  "id": "725339ef-91cd-4f5c-9d99-04cc551ba17e",
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
    "posted_at": "2026-11-09T23:32:06.1123740+00:00"
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
  "subject_id": "1fd19681-3402-44b7-b123-c8ec1090187c",
  "subject_name": "django/db/models/sql/compiler::cursor_iter",
  "tags": [
    "entity:function"
  ],
  "text": "def cursor_iter(cursor, sentinel, col_count, itersize)"
}
```
