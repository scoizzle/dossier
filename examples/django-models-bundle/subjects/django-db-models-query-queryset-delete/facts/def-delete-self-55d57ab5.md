# Fact 55d57ab5

Store id: ccab4793-cefb-4ddd-82e5-ba37d150f8db

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
- posted_at: `2026-11-09T23:44:55.9740760+00:00`

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
  "id": "ccab4793-cefb-4ddd-82e5-ba37d150f8db",
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
    "posted_at": "2026-11-09T23:44:55.9740760+00:00"
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
  "subject_id": "f6529601-29ce-4d17-9ebd-68e9fe074234",
  "subject_name": "django/db/models/query::QuerySet.delete",
  "tags": [
    "entity:method"
  ],
  "text": "def delete(self)"
}
```
