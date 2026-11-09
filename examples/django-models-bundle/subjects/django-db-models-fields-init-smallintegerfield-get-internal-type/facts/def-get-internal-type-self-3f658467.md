# Fact 3f658467

Store id: 4c2bf2ca-159c-450b-abf7-511e4b5fb58f

## Text

```text
def get_internal_type(self)
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
- posted_at: `2026-11-09T23:44:50.1776160+00:00`

## Data

```json
{
  "end_line": 2262,
  "entity_kind": "method",
  "parent": "SmallIntegerField",
  "start_line": 2261,
  "symbol": "SmallIntegerField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2261,"selector":"L2261-L2262","symbol":"SmallIntegerField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::SmallIntegerField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2262,
    "entity_kind": "method",
    "parent": "SmallIntegerField",
    "start_line": 2261,
    "symbol": "SmallIntegerField.get_internal_type"
  },
  "id": "4c2bf2ca-159c-450b-abf7-511e4b5fb58f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1776160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2261,
        "selector": "L2261-L2262",
        "symbol": "SmallIntegerField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "0a025912-8e4f-4b49-a6e2-c69ec7eda71f",
  "subject_name": "django/db/models/fields/__init__::SmallIntegerField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
