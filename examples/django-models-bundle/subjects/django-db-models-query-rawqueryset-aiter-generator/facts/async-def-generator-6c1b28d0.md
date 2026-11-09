# Fact 6c1b28d0

Store id: 15a06b5a-4b5f-4b5e-8be1-c2d95d8b2d6e

## Text

```text
async def generator()
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:async_function`, `async`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:56.2494100+00:00`

## Data

```json
{
  "end_line": 2509,
  "entity_kind": "async_function",
  "parent": "RawQuerySet.__aiter__",
  "start_line": 2506,
  "symbol": "RawQuerySet.__aiter__.generator"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2506,"selector":"L2506-L2509","symbol":"RawQuerySet.__aiter__.generator"}`

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.__aiter__.generator](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2509,
    "entity_kind": "async_function",
    "parent": "RawQuerySet.__aiter__",
    "start_line": 2506,
    "symbol": "RawQuerySet.__aiter__.generator"
  },
  "id": "15a06b5a-4b5f-4b5e-8be1-c2d95d8b2d6e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.2494100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2506,
        "selector": "L2506-L2509",
        "symbol": "RawQuerySet.__aiter__.generator"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "4c7c34ec-294e-4c0c-a5ca-b00e1369bc05",
  "subject_name": "django/db/models/query::RawQuerySet.__aiter__.generator",
  "tags": [
    "entity:async_function",
    "async"
  ],
  "text": "async def generator()"
}
```
