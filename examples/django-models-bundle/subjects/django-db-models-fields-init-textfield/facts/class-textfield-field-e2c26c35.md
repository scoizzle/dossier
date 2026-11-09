# Fact e2c26c35

Store id: 9a6c74e4-680f-4b11-9c5c-25b62ddc4f32

## Text

```text
class TextField(Field)
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
- posted_at: `2026-11-09T23:44:50.2338700+00:00`

## Data

```json
{
  "end_line": 2598,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2524,
  "symbol": "TextField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2524,"selector":"L2524-L2598","symbol":"TextField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TextField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2598,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2524,
    "symbol": "TextField"
  },
  "id": "9a6c74e4-680f-4b11-9c5c-25b62ddc4f32",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2338700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2524,
        "selector": "L2524-L2598",
        "symbol": "TextField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "e26468f2-4084-4093-baf5-9c7b8bbfafbe",
  "subject_name": "django/db/models/fields/__init__::TextField",
  "tags": [
    "entity:class"
  ],
  "text": "class TextField(Field)"
}
```
