# Fact 3249011a

Store id: 4cebde62-573d-445f-b093-cdbfa150a58d

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
- posted_at: `2026-11-09T23:44:56.0444190+00:00`

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
  "id": "4cebde62-573d-445f-b093-cdbfa150a58d",
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
    "posted_at": "2026-11-09T23:44:56.0444190+00:00"
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
  "subject_id": "fb9c7073-a746-43f4-b92a-c96858e8177c",
  "subject_name": "django/db/models/query::QuerySet.complex_filter",
  "tags": [
    "entity:method"
  ],
  "text": "def complex_filter(self, filter_obj)"
}
```
