# Fact d74279bd

Store id: 5e2ccc8a-496a-407d-a92e-b714aef7a69c

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:56.7684290+00:00`

## Data

```json
{
  "end_line": 570,
  "entity_kind": "method",
  "parent": "FilteredRelation",
  "start_line": 569,
  "symbol": "FilteredRelation.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":569,"selector":"L569-L570","symbol":"FilteredRelation.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::FilteredRelation.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 570,
    "entity_kind": "method",
    "parent": "FilteredRelation",
    "start_line": 569,
    "symbol": "FilteredRelation.as_sql"
  },
  "id": "5e2ccc8a-496a-407d-a92e-b714aef7a69c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.7684290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 569,
        "selector": "L569-L570",
        "symbol": "FilteredRelation.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "2720507e-d0d1-4574-82a9-611c2441f52f",
  "subject_name": "django/db/models/query_utils::FilteredRelation.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
