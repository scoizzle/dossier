# Fact d70bfca3

Store id: c6c9d0c0-0fb3-45a9-9055-c378278b19ea

## Text

```text
def update(self, **kwargs)
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
- posted_at: `2026-11-09T23:44:55.9821160+00:00`

## Data

```json
{
  "end_line": 1448,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1408,
  "symbol": "QuerySet.update"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1408,"selector":"L1408-L1448","symbol":"QuerySet.update"}`

## Items

```json
[
  {
    "text": "Update all elements in the current QuerySet, setting all the given fields to the appropriate values.",
    "locator": {
      "line": 1409
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.update](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1448,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1408,
    "symbol": "QuerySet.update"
  },
  "id": "c6c9d0c0-0fb3-45a9-9055-c378278b19ea",
  "items": [
    {
      "locator": {
        "line": 1409
      },
      "text": "Update all elements in the current QuerySet, setting all the given fields to the appropriate values."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.9821160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1408,
        "selector": "L1408-L1448",
        "symbol": "QuerySet.update"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "75f8fdad-86ec-4449-9775-2d0be0d8fbf6",
  "subject_name": "django/db/models/query::QuerySet.update",
  "tags": [
    "entity:method"
  ],
  "text": "def update(self, **kwargs)"
}
```
