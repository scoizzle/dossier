# Fact 690c14ab

Store id: 7c46e331-e7da-465b-b579-46d97bbc36b2

## Text

```text
async def acreate(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:49.3994460+00:00`

## Data

```json
{
  "end_line": 759,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 758,
  "symbol": "QuerySet.acreate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":758,"selector":"L758-L759","symbol":"QuerySet.acreate"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.acreate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 759,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 758,
    "symbol": "QuerySet.acreate"
  },
  "id": "7c46e331-e7da-465b-b579-46d97bbc36b2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.3994460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 758,
        "selector": "L758-L759",
        "symbol": "QuerySet.acreate"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "d1ca936b-d8b5-454a-8772-1be464ea36e9",
  "subject_name": "django/db/models/query::QuerySet.acreate",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def acreate(self, **kwargs)"
}
```
