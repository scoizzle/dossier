# Fact 2c40c71b

Store id: 93d0e6ab-0ea5-4f71-8e84-fc81ef20a3da

## Text

```text
class ContainedBy(FieldGetDbPrepValueMixin, PostgresOperatorLookup)
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
- posted_at: `2026-11-09T23:44:50.9564930+00:00`

## Data

```json
{
  "end_line": 180,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 168,
  "symbol": "ContainedBy"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":168,"selector":"L168-L180","symbol":"ContainedBy"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::ContainedBy](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 180,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 168,
    "symbol": "ContainedBy"
  },
  "id": "93d0e6ab-0ea5-4f71-8e84-fc81ef20a3da",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9564930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 168,
        "selector": "L168-L180",
        "symbol": "ContainedBy"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "8365e3bd-92b0-4e42-88a0-792b70f8e6b9",
  "subject_name": "django/db/models/fields/json::ContainedBy",
  "tags": [
    "entity:class"
  ],
  "text": "class ContainedBy(FieldGetDbPrepValueMixin, PostgresOperatorLookup)"
}
```
