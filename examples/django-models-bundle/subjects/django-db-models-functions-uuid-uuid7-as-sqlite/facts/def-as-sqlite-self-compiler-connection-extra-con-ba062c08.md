# Fact ba062c08

Store id: df2e227c-10c7-4760-8f4e-5d63c1383284

## Text

```text
def as_sqlite(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:44:54.3424030+00:00`

## Data

```json
{
  "end_line": 85,
  "entity_kind": "method",
  "parent": "UUID7",
  "start_line": 80,
  "symbol": "UUID7.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/uuid.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":80,"selector":"L80-L85","symbol":"UUID7.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/functions/uuid::UUID7.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 85,
    "entity_kind": "method",
    "parent": "UUID7",
    "start_line": 80,
    "symbol": "UUID7.as_sqlite"
  },
  "id": "df2e227c-10c7-4760-8f4e-5d63c1383284",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.3424030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 80,
        "selector": "L80-L85",
        "symbol": "UUID7.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/uuid.py"
    }
  ],
  "status": "live",
  "subject_id": "1f4b52bd-f3a3-4ed8-9bda-927583eaf228",
  "subject_name": "django/db/models/functions/uuid::UUID7.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
