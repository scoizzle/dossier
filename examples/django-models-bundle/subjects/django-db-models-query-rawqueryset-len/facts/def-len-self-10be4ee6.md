# Fact 10be4ee6

Store id: 1f9d2970-5610-48db-9e5d-aa2464b0f005

## Text

```text
def __len__(self)
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
- posted_at: `2026-11-09T22:39:49.7927990+00:00`

## Data

```json
{
  "end_line": 2493,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2491,
  "symbol": "RawQuerySet.__len__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2491,"selector":"L2491-L2493","symbol":"RawQuerySet.__len__"}`

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.__len__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2493,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2491,
    "symbol": "RawQuerySet.__len__"
  },
  "id": "1f9d2970-5610-48db-9e5d-aa2464b0f005",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.7927990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2491,
        "selector": "L2491-L2493",
        "symbol": "RawQuerySet.__len__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "644bf113-d772-4586-b3ce-8ba303605f2a",
  "subject_name": "django/db/models/query::RawQuerySet.__len__",
  "tags": [
    "entity:method"
  ],
  "text": "def __len__(self)"
}
```
