# Fact 9ec76f2c

Store id: 9f107bb7-7cf4-4737-b7a3-c295857f5265

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
- posted_at: `2026-11-09T23:44:56.2530220+00:00`

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
  "id": "9f107bb7-7cf4-4737-b7a3-c295857f5265",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.2530220+00:00"
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
  "subject_id": "a18c7ac1-970f-4025-b982-44d9b7bdc36b",
  "subject_name": "django/db/models/query::RawQuerySet.iterator",
  "tags": [
    "entity:method"
  ],
  "text": "def iterator(self)"
}
```
