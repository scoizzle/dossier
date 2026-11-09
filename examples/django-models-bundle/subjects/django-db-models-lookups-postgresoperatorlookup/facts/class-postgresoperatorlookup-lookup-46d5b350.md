# Fact 46d5b350

Store id: 6311b24f-e0c1-486a-81a2-e8e1b84fee5c

## Text

```text
class PostgresOperatorLookup(Lookup)
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
- posted_at: `2026-11-09T23:32:03.2444540+00:00`

## Data

```json
{
  "end_line": 369,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 360,
  "symbol": "PostgresOperatorLookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":360,"selector":"L360-L369","symbol":"PostgresOperatorLookup"}`

## Items

```json
[
  {
    "text": "Lookup defined by operators on PostgreSQL.",
    "locator": {
      "line": 361
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/lookups::PostgresOperatorLookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 369,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 360,
    "symbol": "PostgresOperatorLookup"
  },
  "id": "6311b24f-e0c1-486a-81a2-e8e1b84fee5c",
  "items": [
    {
      "locator": {
        "line": 361
      },
      "text": "Lookup defined by operators on PostgreSQL."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.2444540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 360,
        "selector": "L360-L369",
        "symbol": "PostgresOperatorLookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "95ee4512-90d1-42d3-b960-8dd2bdf473af",
  "subject_name": "django/db/models/lookups::PostgresOperatorLookup",
  "tags": [
    "entity:class"
  ],
  "text": "class PostgresOperatorLookup(Lookup)"
}
```
