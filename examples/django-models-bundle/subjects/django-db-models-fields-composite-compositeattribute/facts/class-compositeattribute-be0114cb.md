# Fact be0114cb

Store id: eb6664d5-1ed9-4d70-a4c3-a453769a63eb

## Text

```text
class CompositeAttribute
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
- posted_at: `2026-11-09T22:39:42.9799750+00:00`

## Data

```json
{
  "end_line": 47,
  "entity_kind": "class",
  "parent": "composite",
  "start_line": 23,
  "symbol": "CompositeAttribute"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":23,"selector":"L23-L47","symbol":"CompositeAttribute"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositeAttribute](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 47,
    "entity_kind": "class",
    "parent": "composite",
    "start_line": 23,
    "symbol": "CompositeAttribute"
  },
  "id": "eb6664d5-1ed9-4d70-a4c3-a453769a63eb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.9799750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 23,
        "selector": "L23-L47",
        "symbol": "CompositeAttribute"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "939c6046-e28c-4eec-92c6-10dc09dd4cf4",
  "subject_name": "django/db/models/fields/composite::CompositeAttribute",
  "tags": [
    "entity:class"
  ],
  "text": "class CompositeAttribute"
}
```
