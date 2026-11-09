# Fact d9f0ce90

Store id: 0d2852e8-b091-4124-98c1-eb8d45648ce9

## Text

```text
def as_postgresql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:32:02.1339150+00:00`

## Data

```json
{
  "end_line": 39,
  "entity_kind": "method",
  "parent": "PostgreSQLSHAMixin",
  "start_line": 32,
  "symbol": "PostgreSQLSHAMixin.as_postgresql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":32,"selector":"L32-L39","symbol":"PostgreSQLSHAMixin.as_postgresql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::PostgreSQLSHAMixin.as_postgresql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 39,
    "entity_kind": "method",
    "parent": "PostgreSQLSHAMixin",
    "start_line": 32,
    "symbol": "PostgreSQLSHAMixin.as_postgresql"
  },
  "id": "0d2852e8-b091-4124-98c1-eb8d45648ce9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.1339150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 32,
        "selector": "L32-L39",
        "symbol": "PostgreSQLSHAMixin.as_postgresql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "0916d41a-1ea3-410c-a32f-edfe5e96bc0e",
  "subject_name": "django/db/models/functions/text::PostgreSQLSHAMixin.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection, **extra_context)"
}
```
