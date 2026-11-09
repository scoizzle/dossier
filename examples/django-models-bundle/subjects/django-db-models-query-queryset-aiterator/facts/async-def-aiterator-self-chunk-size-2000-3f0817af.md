# Fact 3f0817af

Store id: 4ba671d4-061d-42fd-91a2-b7c5bcadc04c

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
- posted_at: `2026-11-09T23:32:04.3660900+00:00`

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
  "id": "4ba671d4-061d-42fd-91a2-b7c5bcadc04c",
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
    "posted_at": "2026-11-09T23:32:04.3660900+00:00"
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
  "subject_id": "70d5886e-cbbc-454d-9c30-6b013047e55b",
  "subject_name": "django/db/models/query::QuerySet.aiterator",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aiterator(self, chunk_size=2000)"
}
```
