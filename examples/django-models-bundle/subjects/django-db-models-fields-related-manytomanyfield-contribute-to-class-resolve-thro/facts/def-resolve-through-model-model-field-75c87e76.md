# Fact 75c87e76

Store id: f0ec5c90-00bb-490e-b129-b6ffede45572

## Text

```text
def resolve_through_model(_, model, field)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:58.8839180+00:00`

## Data

```json
{
  "end_line": 2137,
  "entity_kind": "function",
  "parent": "ManyToManyField.contribute_to_class",
  "start_line": 2136,
  "symbol": "ManyToManyField.contribute_to_class.resolve_through_model"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2136,"selector":"L2136-L2137","symbol":"ManyToManyField.contribute_to_class.resolve_through_model"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.contribute_to_class.resolve_through_model](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2137,
    "entity_kind": "function",
    "parent": "ManyToManyField.contribute_to_class",
    "start_line": 2136,
    "symbol": "ManyToManyField.contribute_to_class.resolve_through_model"
  },
  "id": "f0ec5c90-00bb-490e-b129-b6ffede45572",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.8839180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2136,
        "selector": "L2136-L2137",
        "symbol": "ManyToManyField.contribute_to_class.resolve_through_model"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "1e0cf4bb-aefb-4de6-8172-53158eb6fe87",
  "subject_name": "django/db/models/fields/related::ManyToManyField.contribute_to_class.resolve_through_model",
  "tags": [
    "entity:function"
  ],
  "text": "def resolve_through_model(_, model, field)"
}
```
