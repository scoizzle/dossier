# Fact 5222c35c

Store id: 59aea8d4-9d7a-429e-b012-7b8ca724e247

## Text

```text
def defer(self, *fields)
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
- posted_at: `2026-11-09T22:39:49.6709450+00:00`

## Data

```json
{
  "end_line": 1996,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1981,
  "symbol": "QuerySet.defer"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1981,"selector":"L1981-L1996","symbol":"QuerySet.defer"}`

## Items

```json
[
  {
    "text": "Defer the loading of data for certain fields until they are accessed. Add the set of deferred fields to any existing set of deferred fields. The only exception to this is if None is passed in as the only parameter, in which case remove all deferrals.",
    "locator": {
      "line": 1982
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.defer](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1996,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1981,
    "symbol": "QuerySet.defer"
  },
  "id": "59aea8d4-9d7a-429e-b012-7b8ca724e247",
  "items": [
    {
      "locator": {
        "line": 1982
      },
      "text": "Defer the loading of data for certain fields until they are accessed. Add the set of deferred fields to any existing set of deferred fields. The only exception to this is if None is passed in as the only parameter, in which case remove all deferrals."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.6709450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1981,
        "selector": "L1981-L1996",
        "symbol": "QuerySet.defer"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "1714f035-6d34-4d2d-88d2-129d56ab9558",
  "subject_name": "django/db/models/query::QuerySet.defer",
  "tags": [
    "entity:method"
  ],
  "text": "def defer(self, *fields)"
}
```
