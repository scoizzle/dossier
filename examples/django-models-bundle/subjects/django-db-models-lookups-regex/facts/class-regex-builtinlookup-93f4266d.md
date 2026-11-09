# Fact 93f4266d

Store id: 525a9cb5-6033-4e9d-8efc-ca00029518ac

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
- posted_at: `2026-11-09T23:44:55.0461470+00:00`

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
  "id": "525a9cb5-6033-4e9d-8efc-ca00029518ac",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0461470+00:00"
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
  "subject_id": "781db6c0-d34e-4784-813e-0f38fe460c91",
  "subject_name": "django/db/models/lookups::Regex",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class Regex(BuiltinLookup)"
}
```
