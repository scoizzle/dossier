# Fact 2871a0a1

Store id: 0542b8c4-eda0-4824-a0e6-bd0758184892

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
- posted_at: `2026-11-09T22:39:44.4292130+00:00`

## Data

```json
{
  "end_line": 1379,
  "entity_kind": "method",
  "parent": "OneToOneField",
  "start_line": 1375,
  "symbol": "OneToOneField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1375,"selector":"L1375-L1379","symbol":"OneToOneField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::OneToOneField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1379,
    "entity_kind": "method",
    "parent": "OneToOneField",
    "start_line": 1375,
    "symbol": "OneToOneField.deconstruct"
  },
  "id": "0542b8c4-eda0-4824-a0e6-bd0758184892",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4292130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1375,
        "selector": "L1375-L1379",
        "symbol": "OneToOneField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "7644a428-d0fc-41e5-b40e-87cdbd5bf349",
  "subject_name": "django/db/models/fields/related::OneToOneField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
