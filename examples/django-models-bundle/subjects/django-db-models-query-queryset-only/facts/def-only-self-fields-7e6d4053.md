# Fact 7e6d4053

Store id: 965c46c6-f665-4ba1-adb5-efb92b7e5ca3

## Text

```text
def only(self, *fields)
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
- posted_at: `2026-11-09T23:32:04.5990510+00:00`

## Data

```json
{
  "end_line": 2017,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1998,
  "symbol": "QuerySet.only"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1998,"selector":"L1998-L2017","symbol":"QuerySet.only"}`

## Items

```json
[
  {
    "text": "Essentially, the opposite of defer(). Only the fields passed into this method and that are not already specified as deferred are loaded immediately when the queryset is evaluated.",
    "locator": {
      "line": 1999
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.only](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2017,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1998,
    "symbol": "QuerySet.only"
  },
  "id": "965c46c6-f665-4ba1-adb5-efb92b7e5ca3",
  "items": [
    {
      "locator": {
        "line": 1999
      },
      "text": "Essentially, the opposite of defer(). Only the fields passed into this method and that are not already specified as deferred are loaded immediately when the queryset is evaluated."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.5990510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1998,
        "selector": "L1998-L2017",
        "symbol": "QuerySet.only"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "3901a0d5-3301-4f90-a881-08b717fe6486",
  "subject_name": "django/db/models/query::QuerySet.only",
  "tags": [
    "entity:method"
  ],
  "text": "def only(self, *fields)"
}
```
