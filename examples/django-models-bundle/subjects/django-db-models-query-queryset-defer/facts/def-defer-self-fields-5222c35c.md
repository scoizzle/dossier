# Fact 5222c35c

Store id: d64fed52-8906-4511-ad0f-a6cb139a919d

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
- posted_at: `2026-11-09T23:44:56.1026990+00:00`

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
  "id": "d64fed52-8906-4511-ad0f-a6cb139a919d",
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
    "posted_at": "2026-11-09T23:44:56.1026990+00:00"
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
  "subject_id": "102f8208-19f4-4772-a6ac-8e79de75fb2a",
  "subject_name": "django/db/models/query::QuerySet.defer",
  "tags": [
    "entity:method"
  ],
  "text": "def defer(self, *fields)"
}
```
