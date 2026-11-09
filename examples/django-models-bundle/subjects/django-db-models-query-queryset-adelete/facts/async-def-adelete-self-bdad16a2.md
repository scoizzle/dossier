# Fact bdad16a2

Store id: f6b7754f-c1f6-4dfd-ba50-146fd3850c98

## Text

```text
async def adelete(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `async`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:49.5181930+00:00`

## Data

```json
{
  "end_line": 1392,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1391,
  "symbol": "QuerySet.adelete"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1391,"selector":"L1391-L1392","symbol":"QuerySet.adelete"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.adelete](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1392,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1391,
    "symbol": "QuerySet.adelete"
  },
  "id": "f6b7754f-c1f6-4dfd-ba50-146fd3850c98",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.5181930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1391,
        "selector": "L1391-L1392",
        "symbol": "QuerySet.adelete"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "d08b6426-da89-4361-9ed5-6f1a1df1c8b7",
  "subject_name": "django/db/models/query::QuerySet.adelete",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def adelete(self)"
}
```
