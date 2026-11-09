# Fact 0890b51b

Store id: e3e9fbf0-f9d1-464f-bf2b-ad0b177aa8f0

## Text

```text
def as_postgresql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:32:03.2478010+00:00`

## Data

```json
{
  "end_line": 369,
  "entity_kind": "method",
  "parent": "PostgresOperatorLookup",
  "start_line": 365,
  "symbol": "PostgresOperatorLookup.as_postgresql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":365,"selector":"L365-L369","symbol":"PostgresOperatorLookup.as_postgresql"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::PostgresOperatorLookup.as_postgresql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 369,
    "entity_kind": "method",
    "parent": "PostgresOperatorLookup",
    "start_line": 365,
    "symbol": "PostgresOperatorLookup.as_postgresql"
  },
  "id": "e3e9fbf0-f9d1-464f-bf2b-ad0b177aa8f0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.2478010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 365,
        "selector": "L365-L369",
        "symbol": "PostgresOperatorLookup.as_postgresql"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "e53fe06d-0659-46ce-9b94-0f2d11c86b72",
  "subject_name": "django/db/models/lookups::PostgresOperatorLookup.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection)"
}
```
