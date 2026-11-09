# Fact bd9c2689

Store id: ac41f0b2-ea4f-45e2-9a44-fbc07ac712a8

## Text

```text
def _generate_next_value_(name, start, count, last_values)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:static_method`, `decorator:staticmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.0488780+00:00`

## Data

```json
{
  "end_line": 79,
  "entity_kind": "static_method",
  "parent": "TextChoices",
  "start_line": 77,
  "symbol": "TextChoices._generate_next_value_"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/enums.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":77,"selector":"L77-L79","symbol":"TextChoices._generate_next_value_"}`

## Referenced by

None.

## Subject

[django/db/models/enums::TextChoices._generate_next_value_](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 79,
    "entity_kind": "static_method",
    "parent": "TextChoices",
    "start_line": 77,
    "symbol": "TextChoices._generate_next_value_"
  },
  "id": "ac41f0b2-ea4f-45e2-9a44-fbc07ac712a8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.0488780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 77,
        "selector": "L77-L79",
        "symbol": "TextChoices._generate_next_value_"
      },
      "rel": "derived_from",
      "target": "django/db/models/enums.py"
    }
  ],
  "status": "live",
  "subject_id": "51c8f513-f03b-43b7-bf04-1fc31d930377",
  "subject_name": "django/db/models/enums::TextChoices._generate_next_value_",
  "tags": [
    "entity:static_method",
    "decorator:staticmethod"
  ],
  "text": "def _generate_next_value_(name, start, count, last_values)"
}
```
