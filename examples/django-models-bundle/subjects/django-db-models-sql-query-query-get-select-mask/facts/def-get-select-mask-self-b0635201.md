# Fact b0635201

Store id: 1fcc77b8-cf09-4595-8c5a-b9fa100e9ae0

## Text

```text
def get_select_mask(self)
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
- posted_at: `2026-11-09T23:32:06.8269800+00:00`

## Data

```json
{
  "end_line": 897,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 877,
  "symbol": "Query.get_select_mask"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":877,"selector":"L877-L897","symbol":"Query.get_select_mask"}`

## Items

```json
[
  {
    "text": "Convert the self.deferred_loading data structure to an alternate data structure, describing the field that *will* be loaded. This is used to compute the columns to select from the database and also by the QuerySet class to work out which fields are being initialized on each model. Models that have all their fields included aren't mentioned in the result, only those that have field restrictions in place.",
    "locator": {
      "line": 878
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.get_select_mask](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 897,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 877,
    "symbol": "Query.get_select_mask"
  },
  "id": "1fcc77b8-cf09-4595-8c5a-b9fa100e9ae0",
  "items": [
    {
      "locator": {
        "line": 878
      },
      "text": "Convert the self.deferred_loading data structure to an alternate data structure, describing the field that *will* be loaded. This is used to compute the columns to select from the database and also by the QuerySet class to work out which fields are being initialized on each model. Models that have all their fields included aren't mentioned in the result, only those that have field restrictions in place."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.8269800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 877,
        "selector": "L877-L897",
        "symbol": "Query.get_select_mask"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "18d2f411-f9c0-462c-a810-a963a03e20c4",
  "subject_name": "django/db/models/sql/query::Query.get_select_mask",
  "tags": [
    "entity:method"
  ],
  "text": "def get_select_mask(self)"
}
```
