# Fact b17d1e3e

Store id: cc175876-70e4-4f3d-9da0-6e9c8cec0946

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
- posted_at: `2026-11-09T23:31:57.8751000+00:00`

## Data

```json
{
  "end_line": 180,
  "entity_kind": "method",
  "parent": "ContainedBy",
  "start_line": 172,
  "symbol": "ContainedBy.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":172,"selector":"L172-L180","symbol":"ContainedBy.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::ContainedBy.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 180,
    "entity_kind": "method",
    "parent": "ContainedBy",
    "start_line": 172,
    "symbol": "ContainedBy.as_sql"
  },
  "id": "cc175876-70e4-4f3d-9da0-6e9c8cec0946",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.8751000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 172,
        "selector": "L172-L180",
        "symbol": "ContainedBy.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "1e762c58-dccc-4e33-8561-627a6fda1356",
  "subject_name": "django/db/models/fields/json::ContainedBy.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
