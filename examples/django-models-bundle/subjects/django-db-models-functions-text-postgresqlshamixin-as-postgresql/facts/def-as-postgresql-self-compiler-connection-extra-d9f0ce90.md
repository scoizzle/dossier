# Fact d9f0ce90

Store id: 603b3bd7-12c3-4603-8979-6df8d72e4f2e

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
- posted_at: `2026-11-09T22:39:47.0504980+00:00`

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
  "id": "603b3bd7-12c3-4603-8979-6df8d72e4f2e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.0504980+00:00"
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
  "subject_id": "bdf34a29-0401-40c9-8f51-e2ffe42d97c7",
  "subject_name": "django/db/models/functions/text::PostgreSQLSHAMixin.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection, **extra_context)"
}
```
