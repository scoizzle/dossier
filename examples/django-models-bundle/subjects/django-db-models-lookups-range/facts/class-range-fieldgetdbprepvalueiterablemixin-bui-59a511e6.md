# Fact 59a511e6

Store id: 0966af5d-e89e-421f-bb5d-7207a59cede4

## Text

```text
class Range(FieldGetDbPrepValueIterableMixin, BuiltinLookup)
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
- posted_at: `2026-11-09T23:44:55.0362690+00:00`

## Data

```json
{
  "end_line": 662,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 657,
  "symbol": "Range"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":657,"selector":"L657-L662","symbol":"Range"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Range](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 662,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 657,
    "symbol": "Range"
  },
  "id": "0966af5d-e89e-421f-bb5d-7207a59cede4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0362690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 657,
        "selector": "L657-L662",
        "symbol": "Range"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "d53f6052-1e91-410e-82fe-50727bec8b0d",
  "subject_name": "django/db/models/lookups::Range",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class Range(FieldGetDbPrepValueIterableMixin, BuiltinLookup)"
}
```
