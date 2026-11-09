# Fact 8b2e63c3

Store id: 7b5859c9-9330-40e3-9678-7354a022c2bc

## Text

```text
async def afirst(self)
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
- posted_at: `2026-11-09T23:32:04.4527140+00:00`

## Data

```json
{
  "end_line": 1232,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1231,
  "symbol": "QuerySet.afirst"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1231,"selector":"L1231-L1232","symbol":"QuerySet.afirst"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.afirst](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1232,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1231,
    "symbol": "QuerySet.afirst"
  },
  "id": "7b5859c9-9330-40e3-9678-7354a022c2bc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.4527140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1231,
        "selector": "L1231-L1232",
        "symbol": "QuerySet.afirst"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "ad828f93-7164-45bf-8ac0-ac143b0514fa",
  "subject_name": "django/db/models/query::QuerySet.afirst",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def afirst(self)"
}
```
