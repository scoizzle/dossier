# Fact 3249011a

Store id: a6d3e379-08ee-4e94-8fc1-07847a6d0fbe

## Text

```text
def complex_filter(self, filter_obj)
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
- posted_at: `2026-11-09T23:32:04.5504750+00:00`

## Data

```json
{
  "end_line": 1746,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1731,
  "symbol": "QuerySet.complex_filter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1731,"selector":"L1731-L1746","symbol":"QuerySet.complex_filter"}`

## Items

```json
[
  {
    "text": "Return a new QuerySet instance with filter_obj added to the filters.",
    "locator": {
      "line": 1732
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.complex_filter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1746,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1731,
    "symbol": "QuerySet.complex_filter"
  },
  "id": "a6d3e379-08ee-4e94-8fc1-07847a6d0fbe",
  "items": [
    {
      "locator": {
        "line": 1732
      },
      "text": "Return a new QuerySet instance with filter_obj added to the filters."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.5504750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1731,
        "selector": "L1731-L1746",
        "symbol": "QuerySet.complex_filter"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "b57c8c00-fd20-4fcb-81e8-586f1a62e38f",
  "subject_name": "django/db/models/query::QuerySet.complex_filter",
  "tags": [
    "entity:method"
  ],
  "text": "def complex_filter(self, filter_obj)"
}
```
