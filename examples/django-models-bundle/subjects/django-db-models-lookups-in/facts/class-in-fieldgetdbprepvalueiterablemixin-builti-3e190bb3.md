# Fact 3e190bb3

Store id: 67e26898-fbec-4c56-988f-ec986c8d26f3

## Text

```text
class In(FieldGetDbPrepValueIterableMixin, BuiltinLookup)
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
- posted_at: `2026-11-09T23:44:54.9979670+00:00`

## Data

```json
{
  "end_line": 581,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 502,
  "symbol": "In"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":502,"selector":"L502-L581","symbol":"In"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::In](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 581,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 502,
    "symbol": "In"
  },
  "id": "67e26898-fbec-4c56-988f-ec986c8d26f3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.9979670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 502,
        "selector": "L502-L581",
        "symbol": "In"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "7fae107a-3098-4573-94ef-8b2af994ac60",
  "subject_name": "django/db/models/lookups::In",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class In(FieldGetDbPrepValueIterableMixin, BuiltinLookup)"
}
```
