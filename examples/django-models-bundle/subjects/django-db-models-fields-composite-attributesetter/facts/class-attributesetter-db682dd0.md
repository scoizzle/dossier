# Fact db682dd0

Store id: 138ceb89-4b2e-4009-b625-a88374f33448

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
- posted_at: `2026-11-09T23:31:57.0896680+00:00`

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
  "id": "138ceb89-4b2e-4009-b625-a88374f33448",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.0896680+00:00"
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
  "subject_id": "e9797aa3-be50-4ca7-87fc-d72772ac4a4a",
  "subject_name": "django/db/models/fields/composite::AttributeSetter",
  "tags": [
    "entity:class"
  ],
  "text": "class AttributeSetter"
}
```
