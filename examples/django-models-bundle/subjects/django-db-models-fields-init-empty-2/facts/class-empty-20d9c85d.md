# Fact 20d9c85d

Store id: 8743027f-c272-44c0-823c-b190d11a9b61

## Text

```text
class Empty
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
- posted_at: `2026-11-09T23:44:49.9377740+00:00`

## Data

```json
{
  "end_line": 81,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 80,
  "symbol": "Empty"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":80,"selector":"L80-L81","symbol":"Empty"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Empty](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 81,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 80,
    "symbol": "Empty"
  },
  "id": "8743027f-c272-44c0-823c-b190d11a9b61",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9377740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 80,
        "selector": "L80-L81",
        "symbol": "Empty"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "73495a18-c24b-41ea-acde-7dd1fa681024",
  "subject_name": "django/db/models/fields/__init__::Empty",
  "tags": [
    "entity:class"
  ],
  "text": "class Empty"
}
```
