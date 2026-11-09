# Fact 20d9c85d

Store id: 9c4a01e6-513c-48fa-b6c0-650b5a8ed613

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
- posted_at: `2026-11-09T22:39:42.2285580+00:00`

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
  "id": "9c4a01e6-513c-48fa-b6c0-650b5a8ed613",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.2285580+00:00"
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
  "subject_id": "716ae9f9-445b-4902-a4cd-70c5895b62ca",
  "subject_name": "django/db/models/fields/__init__::Empty",
  "tags": [
    "entity:class"
  ],
  "text": "class Empty"
}
```
