# Fact 4657e40e

Store id: f502eb0c-6930-403e-aff5-afe9236ce4ee

## Text

```text
def deconstruct(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:44.4651710+00:00`

## Data

```json
{
  "end_line": 1989,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 1949,
  "symbol": "ManyToManyField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1949,"selector":"L1949-L1989","symbol":"ManyToManyField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1989,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 1949,
    "symbol": "ManyToManyField.deconstruct"
  },
  "id": "f502eb0c-6930-403e-aff5-afe9236ce4ee",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4651710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1949,
        "selector": "L1949-L1989",
        "symbol": "ManyToManyField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "db31790f-e1f7-4354-86dd-2e74cea97e4d",
  "subject_name": "django/db/models/fields/related::ManyToManyField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
