# Fact 2f8ee5a4

Store id: 26f767f2-9ec8-4143-82a9-df5ed1ff5481

## Text

```text
async def aexists(self)
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
- posted_at: `2026-11-09T23:32:04.4963760+00:00`

## Data

```json
{
  "end_line": 1487,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1486,
  "symbol": "QuerySet.aexists"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1486,"selector":"L1486-L1487","symbol":"QuerySet.aexists"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.aexists](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1487,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1486,
    "symbol": "QuerySet.aexists"
  },
  "id": "26f767f2-9ec8-4143-82a9-df5ed1ff5481",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.4963760+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1486,
        "selector": "L1486-L1487",
        "symbol": "QuerySet.aexists"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "35433c0d-e678-42c5-8db4-b5051e2eb884",
  "subject_name": "django/db/models/query::QuerySet.aexists",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aexists(self)"
}
```
