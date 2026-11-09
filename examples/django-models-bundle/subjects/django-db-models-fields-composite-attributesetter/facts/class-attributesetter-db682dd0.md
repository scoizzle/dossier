# Fact db682dd0

Store id: 5f8dffc2-13f3-424b-bbcb-0cc8c289ae90

## Text

```text
class AttributeSetter
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
- posted_at: `2026-11-09T22:39:42.9670210+00:00`

## Data

```json
{
  "end_line": 20,
  "entity_kind": "class",
  "parent": "composite",
  "start_line": 18,
  "symbol": "AttributeSetter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":18,"selector":"L18-L20","symbol":"AttributeSetter"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::AttributeSetter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 20,
    "entity_kind": "class",
    "parent": "composite",
    "start_line": 18,
    "symbol": "AttributeSetter"
  },
  "id": "5f8dffc2-13f3-424b-bbcb-0cc8c289ae90",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.9670210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 18,
        "selector": "L18-L20",
        "symbol": "AttributeSetter"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "f114eae3-edaa-4754-a8d0-42497e5b82f1",
  "subject_name": "django/db/models/fields/composite::AttributeSetter",
  "tags": [
    "entity:class"
  ],
  "text": "class AttributeSetter"
}
```
