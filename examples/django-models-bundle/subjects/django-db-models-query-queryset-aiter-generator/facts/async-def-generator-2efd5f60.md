# Fact 2efd5f60

Store id: 24faaab2-6727-4bb6-81cd-1c3ef628ff12

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
- posted_at: `2026-11-09T23:44:55.8575270+00:00`

## Data

```json
{
  "end_line": 482,
  "entity_kind": "async_function",
  "parent": "QuerySet.__aiter__",
  "start_line": 479,
  "symbol": "QuerySet.__aiter__.generator"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":479,"selector":"L479-L482","symbol":"QuerySet.__aiter__.generator"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.__aiter__.generator](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 482,
    "entity_kind": "async_function",
    "parent": "QuerySet.__aiter__",
    "start_line": 479,
    "symbol": "QuerySet.__aiter__.generator"
  },
  "id": "24faaab2-6727-4bb6-81cd-1c3ef628ff12",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8575270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 479,
        "selector": "L479-L482",
        "symbol": "QuerySet.__aiter__.generator"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "6999582b-22fa-440f-9aae-25956644d2f8",
  "subject_name": "django/db/models/query::QuerySet.__aiter__.generator",
  "tags": [
    "entity:async_function",
    "async"
  ],
  "text": "async def generator()"
}
```
