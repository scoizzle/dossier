# Fact e75428d1

Store id: 3d83c635-86db-4a8b-a4d3-ff950d0a55f2

## Text

```text
class ValuesListIterable(BaseIterable)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:49.2300660+00:00`

## Data

```json
{
  "end_line": 301,
  "entity_kind": "class",
  "parent": "query",
  "start_line": 287,
  "symbol": "ValuesListIterable"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":287,"selector":"L287-L301","symbol":"ValuesListIterable"}`

## Items

```json
[
  {
    "text": "Iterable returned by QuerySet.values_list(flat=False) that yields a tuple for each row.",
    "locator": {
      "line": 288
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::ValuesListIterable](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 301,
    "entity_kind": "class",
    "parent": "query",
    "start_line": 287,
    "symbol": "ValuesListIterable"
  },
  "id": "3d83c635-86db-4a8b-a4d3-ff950d0a55f2",
  "items": [
    {
      "locator": {
        "line": 288
      },
      "text": "Iterable returned by QuerySet.values_list(flat=False) that yields a tuple for each row."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.2300660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 287,
        "selector": "L287-L301",
        "symbol": "ValuesListIterable"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "5113e715-a8d6-4df3-8a6a-8d80906c6183",
  "subject_name": "django/db/models/query::ValuesListIterable",
  "tags": [
    "entity:class"
  ],
  "text": "class ValuesListIterable(BaseIterable)"
}
```
