# Fact 7bde9681

Store id: a2361c5b-d400-4937-b4fa-de7ef92a8d03

## Text

```text
class Repeat(Func)
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
- posted_at: `2026-11-09T22:39:47.1428540+00:00`

## Data

```json
{
  "end_line": 250,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 233,
  "symbol": "Repeat"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":233,"selector":"L233-L250","symbol":"Repeat"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Repeat](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 250,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 233,
    "symbol": "Repeat"
  },
  "id": "a2361c5b-d400-4937-b4fa-de7ef92a8d03",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1428540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 233,
        "selector": "L233-L250",
        "symbol": "Repeat"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "ba416ab0-9e01-40ff-b308-ff9b8d4759b0",
  "subject_name": "django/db/models/functions/text::Repeat",
  "tags": [
    "entity:class"
  ],
  "text": "class Repeat(Func)"
}
```
