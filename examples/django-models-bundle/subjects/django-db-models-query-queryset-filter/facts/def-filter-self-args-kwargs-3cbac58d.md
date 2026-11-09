# Fact 3cbac58d

Store id: d9fcdaad-2f1a-4a86-9f2b-6cf4a9b96910

## Text

```text
def filter(self, *args, **kwargs)
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
- posted_at: `2026-11-09T23:32:04.5369730+00:00`

## Data

```json
{
  "end_line": 1701,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1695,
  "symbol": "QuerySet.filter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1695,"selector":"L1695-L1701","symbol":"QuerySet.filter"}`

## Items

```json
[
  {
    "text": "Return a new QuerySet instance with the args ANDed to the existing set.",
    "locator": {
      "line": 1696
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.filter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1701,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1695,
    "symbol": "QuerySet.filter"
  },
  "id": "d9fcdaad-2f1a-4a86-9f2b-6cf4a9b96910",
  "items": [
    {
      "locator": {
        "line": 1696
      },
      "text": "Return a new QuerySet instance with the args ANDed to the existing set."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.5369730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1695,
        "selector": "L1695-L1701",
        "symbol": "QuerySet.filter"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "8b11ab23-8178-47c3-b246-c39f45cf661c",
  "subject_name": "django/db/models/query::QuerySet.filter",
  "tags": [
    "entity:method"
  ],
  "text": "def filter(self, *args, **kwargs)"
}
```
