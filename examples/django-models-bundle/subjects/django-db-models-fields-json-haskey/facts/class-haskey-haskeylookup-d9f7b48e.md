# Fact d9f7b48e

Store id: 87888246-11ac-4b27-9bb4-2392fab32b57

## Text

```text
class HasKey(HasKeyLookup)
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
- posted_at: `2026-11-09T22:39:43.6535780+00:00`

## Data

```json
{
  "end_line": 271,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 268,
  "symbol": "HasKey"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":268,"selector":"L268-L271","symbol":"HasKey"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::HasKey](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 271,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 268,
    "symbol": "HasKey"
  },
  "id": "87888246-11ac-4b27-9bb4-2392fab32b57",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6535780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 268,
        "selector": "L268-L271",
        "symbol": "HasKey"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "3caac406-5076-421c-aec8-3549d3c8b174",
  "subject_name": "django/db/models/fields/json::HasKey",
  "tags": [
    "entity:class"
  ],
  "text": "class HasKey(HasKeyLookup)"
}
```
