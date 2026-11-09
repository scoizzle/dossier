# Fact 7bde9681

Store id: b44a19b0-a633-4f94-be84-c9abe5a59f93

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
- posted_at: `2026-11-09T23:32:02.2364180+00:00`

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
  "id": "b44a19b0-a633-4f94-be84-c9abe5a59f93",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.2364180+00:00"
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
  "subject_id": "10b0c4e7-691a-441e-93c3-e7cb53e84205",
  "subject_name": "django/db/models/functions/text::Repeat",
  "tags": [
    "entity:class"
  ],
  "text": "class Repeat(Func)"
}
```
