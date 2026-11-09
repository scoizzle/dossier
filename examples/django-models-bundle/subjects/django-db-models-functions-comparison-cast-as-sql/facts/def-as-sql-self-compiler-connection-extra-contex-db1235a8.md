# Fact db1235a8

Store id: e9d57691-1fe2-4645-b496-a25abb0886c3

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
- posted_at: `2026-11-09T22:39:45.9000060+00:00`

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
  "id": "e9d57691-1fe2-4645-b496-a25abb0886c3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.9000060+00:00"
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
  "subject_id": "82a7e091-5756-45b9-8731-915e3f225ddb",
  "subject_name": "django/db/models/functions/comparison::Cast.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, **extra_context)"
}
```
