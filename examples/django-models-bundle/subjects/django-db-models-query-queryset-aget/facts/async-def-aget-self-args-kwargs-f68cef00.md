# Fact f68cef00

Store id: 611b7049-654b-4b43-9507-38ee7879de62

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
- posted_at: `2026-11-09T23:44:55.8968540+00:00`

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
  "id": "611b7049-654b-4b43-9507-38ee7879de62",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8968540+00:00"
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
  "subject_id": "15bc9ff1-d4ae-4267-806f-5feb7ec272fd",
  "subject_name": "django/db/models/query::QuerySet.aget",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aget(self, *args, **kwargs)"
}
```
