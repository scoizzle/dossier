# Fact 3e190bb3

Store id: 16d59fe5-7a51-40ff-af36-6e799938a603

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
- posted_at: `2026-11-09T22:39:48.1495070+00:00`

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
  "id": "16d59fe5-7a51-40ff-af36-6e799938a603",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1495070+00:00"
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
  "subject_id": "4dd50858-2623-4c5d-8b24-ccff9aa26476",
  "subject_name": "django/db/models/lookups::In",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class In(FieldGetDbPrepValueIterableMixin, BuiltinLookup)"
}
```
