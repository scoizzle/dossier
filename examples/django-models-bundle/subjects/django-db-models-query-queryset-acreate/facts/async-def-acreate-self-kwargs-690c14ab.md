# Fact 690c14ab

Store id: 63a0a8f9-c8c4-40ba-8205-a090a5cd50ed

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
- posted_at: `2026-11-09T23:44:55.9019960+00:00`

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
  "id": "63a0a8f9-c8c4-40ba-8205-a090a5cd50ed",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.9019960+00:00"
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
  "subject_id": "e6282003-ebce-4ad2-9705-0cb2191ddba6",
  "subject_name": "django/db/models/query::QuerySet.acreate",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def acreate(self, **kwargs)"
}
```
