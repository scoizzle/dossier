# Fact 9dde95a9

Store id: d16cd2f0-5fd0-4071-b680-6afee6305fdc

## Text

```text
async def aget_or_create(self, defaults=None, **kwargs)
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
- posted_at: `2026-11-09T23:44:55.9275400+00:00`

## Data

```json
{
  "end_line": 1091,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1087,
  "symbol": "QuerySet.aget_or_create"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1087,"selector":"L1087-L1091","symbol":"QuerySet.aget_or_create"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.aget_or_create](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1091,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1087,
    "symbol": "QuerySet.aget_or_create"
  },
  "id": "d16cd2f0-5fd0-4071-b680-6afee6305fdc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.9275400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1087,
        "selector": "L1087-L1091",
        "symbol": "QuerySet.aget_or_create"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "98b1cd79-e509-4bf4-b10e-c168706aeb9b",
  "subject_name": "django/db/models/query::QuerySet.aget_or_create",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aget_or_create(self, defaults=None, **kwargs)"
}
```
