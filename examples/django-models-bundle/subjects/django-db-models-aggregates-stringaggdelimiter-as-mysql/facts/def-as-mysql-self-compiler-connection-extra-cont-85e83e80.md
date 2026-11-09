# Fact 85e83e80

Store id: d195e14b-42a4-4667-9aa6-510cdd49583e

## Text

```text
def as_mysql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:44:48.4042560+00:00`

## Data

```json
{
  "end_line": 368,
  "entity_kind": "method",
  "parent": "StringAggDelimiter",
  "start_line": 360,
  "symbol": "StringAggDelimiter.as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":360,"selector":"L360-L368","symbol":"StringAggDelimiter.as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::StringAggDelimiter.as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 368,
    "entity_kind": "method",
    "parent": "StringAggDelimiter",
    "start_line": 360,
    "symbol": "StringAggDelimiter.as_mysql"
  },
  "id": "d195e14b-42a4-4667-9aa6-510cdd49583e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.4042560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 360,
        "selector": "L360-L368",
        "symbol": "StringAggDelimiter.as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "3aad2ab9-43a6-4241-b483-7f28ff9ca156",
  "subject_name": "django/db/models/aggregates::StringAggDelimiter.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
