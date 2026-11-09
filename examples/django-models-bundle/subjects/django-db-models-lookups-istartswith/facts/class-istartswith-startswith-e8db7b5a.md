# Fact e8db7b5a

Store id: 8770a442-8630-4d82-a96c-36fbad711ab3

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
- posted_at: `2026-11-09T23:44:55.0293240+00:00`

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
  "id": "8770a442-8630-4d82-a96c-36fbad711ab3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0293240+00:00"
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
  "subject_id": "3fa65551-ffc6-4c89-a01a-c4579dbe399f",
  "subject_name": "django/db/models/lookups::IStartsWith",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class IStartsWith(StartsWith)"
}
```
