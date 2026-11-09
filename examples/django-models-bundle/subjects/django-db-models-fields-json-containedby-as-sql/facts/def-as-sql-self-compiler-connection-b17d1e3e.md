# Fact b17d1e3e

Store id: 4a1a1d2b-5564-4935-a496-c1793a0f57cf

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
- posted_at: `2026-11-09T23:44:50.9580630+00:00`

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
  "id": "4a1a1d2b-5564-4935-a496-c1793a0f57cf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9580630+00:00"
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
  "subject_id": "6085835b-62f3-4e68-88db-d45780ae3dfb",
  "subject_name": "django/db/models/fields/json::ContainedBy.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
