# Fact fd28f6c4

Store id: bd17c994-aeeb-4e5e-bb11-a7621f5a992e

## Text

```text
class GenericIPAddressField(Field)
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
- posted_at: `2026-11-09T22:39:42.5723890+00:00`

## Data

```json
{
  "end_line": 2384,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2296,
  "symbol": "GenericIPAddressField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2296,"selector":"L2296-L2384","symbol":"GenericIPAddressField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::GenericIPAddressField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2384,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2296,
    "symbol": "GenericIPAddressField"
  },
  "id": "bd17c994-aeeb-4e5e-bb11-a7621f5a992e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5723890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2296,
        "selector": "L2296-L2384",
        "symbol": "GenericIPAddressField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "75733c98-e09c-4bc5-8eb7-07f0734e7133",
  "subject_name": "django/db/models/fields/__init__::GenericIPAddressField",
  "tags": [
    "entity:class"
  ],
  "text": "class GenericIPAddressField(Field)"
}
```
