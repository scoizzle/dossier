# Fact dee436ff

Store id: 270d2994-4666-47bc-ba47-e1a0158e9bbd

## Text

```text
class BuiltinLookup(Lookup)
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
- posted_at: `2026-11-09T23:44:54.9216140+00:00`

## Data

```json
{
  "end_line": 251,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 234,
  "symbol": "BuiltinLookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":234,"selector":"L234-L251","symbol":"BuiltinLookup"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::BuiltinLookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 251,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 234,
    "symbol": "BuiltinLookup"
  },
  "id": "270d2994-4666-47bc-ba47-e1a0158e9bbd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.9216140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 234,
        "selector": "L234-L251",
        "symbol": "BuiltinLookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "b095d2ab-eb26-4135-a659-a017adeb5256",
  "subject_name": "django/db/models/lookups::BuiltinLookup",
  "tags": [
    "entity:class"
  ],
  "text": "class BuiltinLookup(Lookup)"
}
```
