# Fact 9ec76f2c

Store id: 6b946d75-f589-4662-8b76-a137a4082719

## Text

```text
def iterator(self)
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
- posted_at: `2026-11-09T22:39:49.8105120+00:00`

## Data

```json
{
  "end_line": 2514,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2513,
  "symbol": "RawQuerySet.iterator"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2513,"selector":"L2513-L2514","symbol":"RawQuerySet.iterator"}`

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.iterator](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2514,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2513,
    "symbol": "RawQuerySet.iterator"
  },
  "id": "6b946d75-f589-4662-8b76-a137a4082719",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.8105120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2513,
        "selector": "L2513-L2514",
        "symbol": "RawQuerySet.iterator"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "79dad45a-b5a7-4e61-b801-2b76cb5efa9f",
  "subject_name": "django/db/models/query::RawQuerySet.iterator",
  "tags": [
    "entity:method"
  ],
  "text": "def iterator(self)"
}
```
