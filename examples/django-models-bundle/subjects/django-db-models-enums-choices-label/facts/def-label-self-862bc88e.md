# Fact 862bc88e

Store id: 4b30fdd9-5b97-4621-8098-fe1dd0c2a3a7

## Text

```text
def label(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:enum_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.0460010+00:00`

## Data

```json
{
  "end_line": 61,
  "entity_kind": "method",
  "parent": "Choices",
  "start_line": 59,
  "symbol": "Choices.label"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/enums.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":59,"selector":"L59-L61","symbol":"Choices.label"}`

## Referenced by

None.

## Subject

[django/db/models/enums::Choices.label](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 61,
    "entity_kind": "method",
    "parent": "Choices",
    "start_line": 59,
    "symbol": "Choices.label"
  },
  "id": "4b30fdd9-5b97-4621-8098-fe1dd0c2a3a7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.0460010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 59,
        "selector": "L59-L61",
        "symbol": "Choices.label"
      },
      "rel": "derived_from",
      "target": "django/db/models/enums.py"
    }
  ],
  "status": "live",
  "subject_id": "c5b02e0b-06a3-4198-bd9f-9c66eda3cd8e",
  "subject_name": "django/db/models/enums::Choices.label",
  "tags": [
    "entity:method",
    "decorator:enum_property"
  ],
  "text": "def label(self)"
}
```
