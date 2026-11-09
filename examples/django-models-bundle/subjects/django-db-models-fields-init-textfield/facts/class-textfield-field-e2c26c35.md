# Fact e2c26c35

Store id: 9041e79c-ce7d-4812-b194-c9916b7fe925

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
- posted_at: `2026-11-09T23:31:56.7920920+00:00`

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
  "id": "9041e79c-ce7d-4812-b194-c9916b7fe925",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7920920+00:00"
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
  "subject_id": "7a0c4c34-ea50-4dea-a384-624939481b43",
  "subject_name": "django/db/models/fields/__init__::TextField",
  "tags": [
    "entity:class"
  ],
  "text": "class TextField(Field)"
}
```
