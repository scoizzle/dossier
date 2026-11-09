# Fact d9f0ce90

Store id: dc2f8016-14f3-430f-928e-c429c8e398cc

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
- posted_at: `2026-11-09T23:44:54.0410900+00:00`

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
  "id": "dc2f8016-14f3-430f-928e-c429c8e398cc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.0410900+00:00"
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
  "subject_id": "aed275af-30c7-4618-8c29-f2e87fde2935",
  "subject_name": "django/db/models/functions/text::PostgreSQLSHAMixin.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection, **extra_context)"
}
```
