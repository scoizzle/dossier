# Fact 690c14ab

Store id: c6b56c83-8d9e-4cb7-b339-09be7b7efdb0

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
- posted_at: `2026-11-09T23:32:04.3922930+00:00`

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
  "id": "c6b56c83-8d9e-4cb7-b339-09be7b7efdb0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.3922930+00:00"
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
  "subject_id": "984e2e29-36b5-4d62-b437-a7a510c7c51c",
  "subject_name": "django/db/models/query::QuerySet.acreate",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def acreate(self, **kwargs)"
}
```
