# Fact 75549a72

Store id: 14eabe69-4f92-46a2-b87a-d35e21cd848f

## Text

```text
def in_bulk(self, id_list=None, *, field_name="pk")
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
- posted_at: `2026-11-09T23:32:04.4614800+00:00`

## Data

```json
{
  "end_line": 1350,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1247,
  "symbol": "QuerySet.in_bulk"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1247,"selector":"L1247-L1350","symbol":"QuerySet.in_bulk"}`

## Items

```json
[
  {
    "text": "Return a dictionary mapping each of the given IDs to the object with that ID. If `id_list` isn't provided, evaluate the entire QuerySet.",
    "locator": {
      "line": 1248
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.in_bulk](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1350,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1247,
    "symbol": "QuerySet.in_bulk"
  },
  "id": "14eabe69-4f92-46a2-b87a-d35e21cd848f",
  "items": [
    {
      "locator": {
        "line": 1248
      },
      "text": "Return a dictionary mapping each of the given IDs to the object with that ID. If `id_list` isn't provided, evaluate the entire QuerySet."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.4614800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1247,
        "selector": "L1247-L1350",
        "symbol": "QuerySet.in_bulk"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "29d2cac4-12ef-4381-8af0-ea716104bdbb",
  "subject_name": "django/db/models/query::QuerySet.in_bulk",
  "tags": [
    "entity:method"
  ],
  "text": "def in_bulk(self, id_list=None, *, field_name=\"pk\")"
}
```
