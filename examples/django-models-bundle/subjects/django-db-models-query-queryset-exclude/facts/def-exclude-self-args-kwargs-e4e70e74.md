# Fact e4e70e74

Store id: 5aca1f56-6f57-4d43-b30b-d0ac7b5d531e

## Text

```text
def exclude(self, *args, **kwargs)
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
- posted_at: `2026-11-09T23:32:04.5409550+00:00`

## Data

```json
{
  "end_line": 1709,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1703,
  "symbol": "QuerySet.exclude"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1703,"selector":"L1703-L1709","symbol":"QuerySet.exclude"}`

## Items

```json
[
  {
    "text": "Return a new QuerySet instance with NOT (args) ANDed to the existing set.",
    "locator": {
      "line": 1704
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.exclude](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1709,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1703,
    "symbol": "QuerySet.exclude"
  },
  "id": "5aca1f56-6f57-4d43-b30b-d0ac7b5d531e",
  "items": [
    {
      "locator": {
        "line": 1704
      },
      "text": "Return a new QuerySet instance with NOT (args) ANDed to the existing set."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.5409550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1703,
        "selector": "L1703-L1709",
        "symbol": "QuerySet.exclude"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "5dd3dcf6-8efa-4cd6-82ca-45a441b14e53",
  "subject_name": "django/db/models/query::QuerySet.exclude",
  "tags": [
    "entity:method"
  ],
  "text": "def exclude(self, *args, **kwargs)"
}
```
