# Fact 3249011a

Store id: f5374815-ad49-4b61-a68d-d131403e27bf

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
- posted_at: `2026-11-09T22:39:49.6182140+00:00`

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
  "id": "f5374815-ad49-4b61-a68d-d131403e27bf",
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
    "posted_at": "2026-11-09T22:39:49.6182140+00:00"
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
  "subject_id": "29df4a28-5732-4717-b3f4-414bb49d5771",
  "subject_name": "django/db/models/query::QuerySet.complex_filter",
  "tags": [
    "entity:method"
  ],
  "text": "def complex_filter(self, filter_obj)"
}
```
