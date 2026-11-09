# Fact db1235a8

Store id: dd9a4817-d784-4b70-84bd-715156d5edd0

## Text

```text
def as_sql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:32:00.9498580+00:00`

## Data

```json
{
  "end_line": 18,
  "entity_kind": "method",
  "parent": "Cast",
  "start_line": 16,
  "symbol": "Cast.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":16,"selector":"L16-L18","symbol":"Cast.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Cast.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 18,
    "entity_kind": "method",
    "parent": "Cast",
    "start_line": 16,
    "symbol": "Cast.as_sql"
  },
  "id": "dd9a4817-d784-4b70-84bd-715156d5edd0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.9498580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 16,
        "selector": "L16-L18",
        "symbol": "Cast.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "4008a925-4064-4f21-b83f-33f30527eb0c",
  "subject_name": "django/db/models/functions/comparison::Cast.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, **extra_context)"
}
```
