# Fact a3cbf775

Store id: 1aaacf97-5a00-491e-8698-3c23e2a8b6c6

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
- posted_at: `2026-11-09T23:32:03.2706670+00:00`

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
  "id": "1aaacf97-5a00-491e-8698-3c23e2a8b6c6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.2706670+00:00"
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
  "subject_id": "a58f8a2c-155a-406e-bf3b-b3c9916d61a2",
  "subject_name": "django/db/models/lookups::GreaterThanOrEqual",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class GreaterThanOrEqual(FieldGetDbPrepValueMixin, BuiltinLookup)"
}
```
