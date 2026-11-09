# Fact 1897bad3

Store id: a6d5541f-9ef6-439c-a66c-59035d735d77

## Text

```text
class IntegerChoices(Choices, IntEnum)
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
- posted_at: `2026-11-09T23:31:55.5084880+00:00`

## Data

```json
{
  "end_line": 71,
  "entity_kind": "class",
  "parent": "enums",
  "start_line": 68,
  "symbol": "IntegerChoices"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/enums.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":68,"selector":"L68-L71","symbol":"IntegerChoices"}`

## Items

```json
[
  {
    "text": "Class for creating enumerated integer choices.",
    "locator": {
      "line": 69
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/enums::IntegerChoices](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 71,
    "entity_kind": "class",
    "parent": "enums",
    "start_line": 68,
    "symbol": "IntegerChoices"
  },
  "id": "a6d5541f-9ef6-439c-a66c-59035d735d77",
  "items": [
    {
      "locator": {
        "line": 69
      },
      "text": "Class for creating enumerated integer choices."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.5084880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 68,
        "selector": "L68-L71",
        "symbol": "IntegerChoices"
      },
      "rel": "derived_from",
      "target": "django/db/models/enums.py"
    }
  ],
  "status": "live",
  "subject_id": "322ad7b4-0b16-4b13-a8bd-3481267b07b9",
  "subject_name": "django/db/models/enums::IntegerChoices",
  "tags": [
    "entity:class"
  ],
  "text": "class IntegerChoices(Choices, IntEnum)"
}
```
