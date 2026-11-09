# Fact d6db0170

Store id: 4e690486-6e53-485b-b078-2ea3d9f4fad1

## Text

```text
def __iter__(self)
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
- posted_at: `2026-11-09T22:39:49.7999630+00:00`

## Data

```json
{
  "end_line": 2501,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2499,
  "symbol": "RawQuerySet.__iter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2499,"selector":"L2499-L2501","symbol":"RawQuerySet.__iter__"}`

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.__iter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2501,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2499,
    "symbol": "RawQuerySet.__iter__"
  },
  "id": "4e690486-6e53-485b-b078-2ea3d9f4fad1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.7999630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2499,
        "selector": "L2499-L2501",
        "symbol": "RawQuerySet.__iter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "72e476a2-664c-40b7-b9cd-2c1b151e8e1e",
  "subject_name": "django/db/models/query::RawQuerySet.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
