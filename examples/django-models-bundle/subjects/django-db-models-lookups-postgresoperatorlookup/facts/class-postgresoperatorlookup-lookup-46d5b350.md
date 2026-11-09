# Fact 46d5b350

Store id: 485c5ee3-efc3-414e-9b70-435545e829ff

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
- posted_at: `2026-11-09T22:39:48.0935070+00:00`

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
  "id": "485c5ee3-efc3-414e-9b70-435545e829ff",
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
    "posted_at": "2026-11-09T22:39:48.0935070+00:00"
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
  "subject_id": "f83f01fb-8908-4746-875e-caa2b54a6150",
  "subject_name": "django/db/models/lookups::PostgresOperatorLookup",
  "tags": [
    "entity:class"
  ],
  "text": "class PostgresOperatorLookup(Lookup)"
}
```
