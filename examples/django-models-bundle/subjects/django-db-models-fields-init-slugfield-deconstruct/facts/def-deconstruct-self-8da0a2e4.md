# Fact 8da0a2e4

Store id: 12d2ca08-9ee1-48f6-9a13-8ae6c98cb9e5

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
- posted_at: `2026-11-09T22:39:42.6259440+00:00`

## Data

```json
{
  "end_line": 2509,
  "entity_kind": "method",
  "parent": "SlugField",
  "start_line": 2499,
  "symbol": "SlugField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2499,"selector":"L2499-L2509","symbol":"SlugField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::SlugField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2509,
    "entity_kind": "method",
    "parent": "SlugField",
    "start_line": 2499,
    "symbol": "SlugField.deconstruct"
  },
  "id": "12d2ca08-9ee1-48f6-9a13-8ae6c98cb9e5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6259440+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2499,
        "selector": "L2499-L2509",
        "symbol": "SlugField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "465e7e72-39ff-4ea1-ab5d-59b08e5eac56",
  "subject_name": "django/db/models/fields/__init__::SlugField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
