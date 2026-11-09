# Fact 1a014633

Store id: ebf73fba-0e4c-44f5-a8c0-63bce03b2dd3

## Text

```text
async def aaggregate(self, *args, **kwargs)
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
- posted_at: `2026-11-09T23:32:04.3728620+00:00`

## Data

```json
{
  "end_line": 680,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 679,
  "symbol": "QuerySet.aaggregate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":679,"selector":"L679-L680","symbol":"QuerySet.aaggregate"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.aaggregate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 680,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 679,
    "symbol": "QuerySet.aaggregate"
  },
  "id": "ebf73fba-0e4c-44f5-a8c0-63bce03b2dd3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.3728620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 679,
        "selector": "L679-L680",
        "symbol": "QuerySet.aaggregate"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "1775ede2-89a5-4294-9684-bdb66aa440a8",
  "subject_name": "django/db/models/query::QuerySet.aaggregate",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aaggregate(self, *args, **kwargs)"
}
```
