# Fact 93f4266d

Store id: 079e9099-4c44-4d22-95c5-3b6e66891173

## Text

```text
class Regex(BuiltinLookup)
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
- posted_at: `2026-11-09T22:39:48.2075610+00:00`

## Data

```json
{
  "end_line": 704,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 691,
  "symbol": "Regex"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":691,"selector":"L691-L704","symbol":"Regex"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Regex](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 704,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 691,
    "symbol": "Regex"
  },
  "id": "079e9099-4c44-4d22-95c5-3b6e66891173",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.2075610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 691,
        "selector": "L691-L704",
        "symbol": "Regex"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "c16794c3-7902-446b-bd5e-7ff620c081e5",
  "subject_name": "django/db/models/lookups::Regex",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class Regex(BuiltinLookup)"
}
```
