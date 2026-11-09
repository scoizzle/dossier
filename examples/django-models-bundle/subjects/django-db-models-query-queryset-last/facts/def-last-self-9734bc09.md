# Fact 9734bc09

Store id: f7550622-671f-4009-ab44-68e1d77b38ab

## Text

```text
def last(self)
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
- posted_at: `2026-11-09T22:39:49.4892820+00:00`

## Data

```json
{
  "end_line": 1242,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1234,
  "symbol": "QuerySet.last"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1234,"selector":"L1234-L1242","symbol":"QuerySet.last"}`

## Items

```json
[
  {
    "text": "Return the last object of a query or None if no match is found.",
    "locator": {
      "line": 1235
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.last](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1242,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1234,
    "symbol": "QuerySet.last"
  },
  "id": "f7550622-671f-4009-ab44-68e1d77b38ab",
  "items": [
    {
      "locator": {
        "line": 1235
      },
      "text": "Return the last object of a query or None if no match is found."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.4892820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1234,
        "selector": "L1234-L1242",
        "symbol": "QuerySet.last"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "f4be1fd8-25dd-4722-a2f4-5fee6cef8d93",
  "subject_name": "django/db/models/query::QuerySet.last",
  "tags": [
    "entity:method"
  ],
  "text": "def last(self)"
}
```
