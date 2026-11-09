# Fact 41415746

Store id: 22472a28-a635-4a50-a4cb-faedef47cf69

## Text

```text
def raw(self, raw_query, params=(), translations=None, using=None)
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
- posted_at: `2026-11-09T22:39:49.5682030+00:00`

## Data

```json
{
  "end_line": 1544,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1532,
  "symbol": "QuerySet.raw"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1532,"selector":"L1532-L1544","symbol":"QuerySet.raw"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.raw](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1544,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1532,
    "symbol": "QuerySet.raw"
  },
  "id": "22472a28-a635-4a50-a4cb-faedef47cf69",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.5682030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1532,
        "selector": "L1532-L1544",
        "symbol": "QuerySet.raw"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "8c9a4752-7615-4122-8145-9f83689a721f",
  "subject_name": "django/db/models/query::QuerySet.raw",
  "tags": [
    "entity:method"
  ],
  "text": "def raw(self, raw_query, params=(), translations=None, using=None)"
}
```
