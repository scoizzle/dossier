# Fact 8da0a2e4

Store id: 2eebbbf8-0f07-4337-bac4-8bb6cb5be502

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
- posted_at: `2026-11-09T23:31:56.7862430+00:00`

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
  "id": "2eebbbf8-0f07-4337-bac4-8bb6cb5be502",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7862430+00:00"
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
  "subject_id": "ca258350-3b1c-4c59-97c2-13395b489c26",
  "subject_name": "django/db/models/fields/__init__::SlugField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
