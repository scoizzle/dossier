# Fact 3f0817af

Store id: c9e4e8e7-4bf5-4ee5-a73a-fcb2de550eb2

## Text

```text
async def aiterator(self, chunk_size=2000)
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
- posted_at: `2026-11-09T22:39:49.3650320+00:00`

## Data

```json
{
  "end_line": 652,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 618,
  "symbol": "QuerySet.aiterator"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":618,"selector":"L618-L652","symbol":"QuerySet.aiterator"}`

## Items

```json
[
  {
    "text": "An asynchronous iterator over the results from applying this QuerySet to the database.",
    "locator": {
      "line": 619
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.aiterator](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 652,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 618,
    "symbol": "QuerySet.aiterator"
  },
  "id": "c9e4e8e7-4bf5-4ee5-a73a-fcb2de550eb2",
  "items": [
    {
      "locator": {
        "line": 619
      },
      "text": "An asynchronous iterator over the results from applying this QuerySet to the database."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.3650320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 618,
        "selector": "L618-L652",
        "symbol": "QuerySet.aiterator"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "d0ccfe17-e2fc-4663-b853-e14353c1e951",
  "subject_name": "django/db/models/query::QuerySet.aiterator",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aiterator(self, chunk_size=2000)"
}
```
