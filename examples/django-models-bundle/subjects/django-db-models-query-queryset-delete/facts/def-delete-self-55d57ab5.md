# Fact 55d57ab5

Store id: b1eb8654-766b-4eb6-b5f2-075c03c2a498

## Text

```text
def delete(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:49.5148140+00:00`

## Data

```json
{
  "end_line": 1386,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1358,
  "symbol": "QuerySet.delete"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1358,"selector":"L1358-L1386","symbol":"QuerySet.delete"}`

## Items

```json
[
  {
    "text": "Delete the records in the current QuerySet.",
    "locator": {
      "line": 1359
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.delete](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1386,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1358,
    "symbol": "QuerySet.delete"
  },
  "id": "b1eb8654-766b-4eb6-b5f2-075c03c2a498",
  "items": [
    {
      "locator": {
        "line": 1359
      },
      "text": "Delete the records in the current QuerySet."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.5148140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1358,
        "selector": "L1358-L1386",
        "symbol": "QuerySet.delete"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "d6e877e1-5904-48a0-a824-9422de6ecb2e",
  "subject_name": "django/db/models/query::QuerySet.delete",
  "tags": [
    "entity:method"
  ],
  "text": "def delete(self)"
}
```
