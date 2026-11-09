# Fact 862bc88e

Store id: e3ef89b1-e0e7-447b-83f1-359d192628c1

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
- posted_at: `2026-11-09T22:39:41.3049560+00:00`

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
  "id": "e3ef89b1-e0e7-447b-83f1-359d192628c1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.3049560+00:00"
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
  "subject_id": "69cb8c85-4622-4741-b65b-825eb1f3baea",
  "subject_name": "django/db/models/enums::Choices.label",
  "tags": [
    "entity:method",
    "decorator:enum_property"
  ],
  "text": "def label(self)"
}
```
