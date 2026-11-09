# Fact be0114cb

Store id: e59788ba-ea54-402f-8d8d-2a6d4c81872b

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
- posted_at: `2026-11-09T23:44:50.4706080+00:00`

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
  "id": "e59788ba-ea54-402f-8d8d-2a6d4c81872b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.4706080+00:00"
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
  "subject_id": "9c35b70c-0455-4804-81de-88ac760f5c3c",
  "subject_name": "django/db/models/fields/composite::CompositeAttribute",
  "tags": [
    "entity:class"
  ],
  "text": "class CompositeAttribute"
}
```
