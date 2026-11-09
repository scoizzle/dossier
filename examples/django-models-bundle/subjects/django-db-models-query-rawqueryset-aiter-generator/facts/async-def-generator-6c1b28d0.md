# Fact 6c1b28d0

Store id: 417c85ff-702e-4f08-947e-1ff9c04a43ce

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
- posted_at: `2026-11-09T23:32:04.7493780+00:00`

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
  "id": "417c85ff-702e-4f08-947e-1ff9c04a43ce",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.7493780+00:00"
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
  "subject_id": "7430c5d4-8f13-4d04-b23e-a33c94be8bf8",
  "subject_name": "django/db/models/query::RawQuerySet.__aiter__.generator",
  "tags": [
    "entity:async_function",
    "async"
  ],
  "text": "async def generator()"
}
```
