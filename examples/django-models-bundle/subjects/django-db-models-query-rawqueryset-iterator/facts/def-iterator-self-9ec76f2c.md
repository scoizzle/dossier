# Fact 9ec76f2c

Store id: 5d6288e6-74c1-4186-882b-cb21906b3bd3

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
- posted_at: `2026-11-09T23:32:04.7535160+00:00`

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
  "id": "5d6288e6-74c1-4186-882b-cb21906b3bd3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.7535160+00:00"
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
  "subject_id": "331ac834-daf5-4f34-bbde-20f5fc84796b",
  "subject_name": "django/db/models/query::RawQuerySet.iterator",
  "tags": [
    "entity:method"
  ],
  "text": "def iterator(self)"
}
```
