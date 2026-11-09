# Fact a632ee77

Store id: 2c21016e-a10c-4b3f-9419-7b6d3ad51b61

## Text

```text
class TextChoices(Choices, StrEnum)
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
- posted_at: `2026-11-09T23:31:55.5108490+00:00`

## Data

```json
{
  "end_line": 79,
  "entity_kind": "class",
  "parent": "enums",
  "start_line": 74,
  "symbol": "TextChoices"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/enums.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":74,"selector":"L74-L79","symbol":"TextChoices"}`

## Items

```json
[
  {
    "text": "Class for creating enumerated string choices.",
    "locator": {
      "line": 75
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/enums::TextChoices](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 79,
    "entity_kind": "class",
    "parent": "enums",
    "start_line": 74,
    "symbol": "TextChoices"
  },
  "id": "2c21016e-a10c-4b3f-9419-7b6d3ad51b61",
  "items": [
    {
      "locator": {
        "line": 75
      },
      "text": "Class for creating enumerated string choices."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.5108490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 74,
        "selector": "L74-L79",
        "symbol": "TextChoices"
      },
      "rel": "derived_from",
      "target": "django/db/models/enums.py"
    }
  ],
  "status": "live",
  "subject_id": "a9317c21-8a9a-4b39-8b2e-ad93d6751756",
  "subject_name": "django/db/models/enums::TextChoices",
  "tags": [
    "entity:class"
  ],
  "text": "class TextChoices(Choices, StrEnum)"
}
```
