# Fact f68cef00

Store id: 35b4a98b-77ed-4c57-aa30-b34eb86fd092

## Text

```text
async def aget(self, *args, **kwargs)
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
- posted_at: `2026-11-09T22:39:49.3895980+00:00`

## Data

```json
{
  "end_line": 734,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 733,
  "symbol": "QuerySet.aget"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":733,"selector":"L733-L734","symbol":"QuerySet.aget"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.aget](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 734,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 733,
    "symbol": "QuerySet.aget"
  },
  "id": "35b4a98b-77ed-4c57-aa30-b34eb86fd092",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.3895980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 733,
        "selector": "L733-L734",
        "symbol": "QuerySet.aget"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "8d71995a-206e-468e-8d14-fe27f8cdb541",
  "subject_name": "django/db/models/query::QuerySet.aget",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aget(self, *args, **kwargs)"
}
```
