# Fact bd9c2689

Store id: 2f909d38-f79c-4817-af2b-f80e9f456177

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
- posted_at: `2026-11-09T23:31:55.5129160+00:00`

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
  "id": "2f909d38-f79c-4817-af2b-f80e9f456177",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.5129160+00:00"
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
  "subject_id": "f2fe0c25-5128-4d48-af3a-ce8b7910c39d",
  "subject_name": "django/db/models/enums::TextChoices._generate_next_value_",
  "tags": [
    "entity:static_method",
    "decorator:staticmethod"
  ],
  "text": "def _generate_next_value_(name, start, count, last_values)"
}
```
