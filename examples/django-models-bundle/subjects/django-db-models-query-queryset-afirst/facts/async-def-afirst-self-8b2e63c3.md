# Fact 8b2e63c3

Store id: 4bbc0c83-4553-4db0-96a4-3485b295981d

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
- posted_at: `2026-11-09T22:39:49.4852800+00:00`

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
  "id": "4bbc0c83-4553-4db0-96a4-3485b295981d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.4852800+00:00"
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
  "subject_id": "6a358f0f-7da4-4845-a040-bfa2ce42d795",
  "subject_name": "django/db/models/query::QuerySet.afirst",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def afirst(self)"
}
```
