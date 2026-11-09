# Fact e8db7b5a

Store id: cac24145-3cb4-4eee-86d0-c0a7ddafae42

## Text

```text
class IStartsWith(StartsWith)
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
- posted_at: `2026-11-09T22:39:48.1873880+00:00`

## Data

```json
{
  "end_line": 643,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 641,
  "symbol": "IStartsWith"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":641,"selector":"L641-L643","symbol":"IStartsWith"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IStartsWith](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 643,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 641,
    "symbol": "IStartsWith"
  },
  "id": "cac24145-3cb4-4eee-86d0-c0a7ddafae42",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1873880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 641,
        "selector": "L641-L643",
        "symbol": "IStartsWith"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "77a7fcc7-95f3-4c45-b8ba-08b35375b637",
  "subject_name": "django/db/models/lookups::IStartsWith",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class IStartsWith(StartsWith)"
}
```
