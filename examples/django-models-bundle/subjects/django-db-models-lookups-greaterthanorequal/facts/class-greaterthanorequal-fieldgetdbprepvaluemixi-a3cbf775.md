# Fact a3cbf775

Store id: d37cb91f-2d6a-4732-afb8-43fd3c7dac71

## Text

```text
class GreaterThanOrEqual(FieldGetDbPrepValueMixin, BuiltinLookup)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:Field.register_lookup`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:54.9672210+00:00`

## Data

```json
{
  "end_line": 432,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 430,
  "symbol": "GreaterThanOrEqual"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":430,"selector":"L430-L432","symbol":"GreaterThanOrEqual"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::GreaterThanOrEqual](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 432,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 430,
    "symbol": "GreaterThanOrEqual"
  },
  "id": "d37cb91f-2d6a-4732-afb8-43fd3c7dac71",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.9672210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 430,
        "selector": "L430-L432",
        "symbol": "GreaterThanOrEqual"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "871985d4-60df-4014-9f93-b3e6ab07ad3b",
  "subject_name": "django/db/models/lookups::GreaterThanOrEqual",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class GreaterThanOrEqual(FieldGetDbPrepValueMixin, BuiltinLookup)"
}
```
