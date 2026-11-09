# Fact 7bde9681

Store id: 82f4b28c-4fc1-4c9d-b2a8-bfb4dcc67e26

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
- posted_at: `2026-11-09T23:44:54.1167820+00:00`

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
  "id": "82f4b28c-4fc1-4c9d-b2a8-bfb4dcc67e26",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1167820+00:00"
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
  "subject_id": "3e91e6da-ad01-4358-b27f-92239c9da460",
  "subject_name": "django/db/models/functions/text::Repeat",
  "tags": [
    "entity:class"
  ],
  "text": "class Repeat(Func)"
}
```
