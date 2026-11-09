# Fact 1b45e419

Store id: b411d334-0bc2-459f-8e13-72fec5db1d22

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
- posted_at: `2026-11-09T22:39:40.0396380+00:00`

## Data

```json
{
  "end_line": 237,
  "entity_kind": "method",
  "parent": "AnyValue",
  "start_line": 232,
  "symbol": "AnyValue.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":232,"selector":"L232-L237","symbol":"AnyValue.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::AnyValue.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 237,
    "entity_kind": "method",
    "parent": "AnyValue",
    "start_line": 232,
    "symbol": "AnyValue.as_sql"
  },
  "id": "b411d334-0bc2-459f-8e13-72fec5db1d22",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0396380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 232,
        "selector": "L232-L237",
        "symbol": "AnyValue.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "0bb7df4e-3743-4a25-9c5f-d314d72b3f7b",
  "subject_name": "django/db/models/aggregates::AnyValue.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, **extra_context)"
}
```
