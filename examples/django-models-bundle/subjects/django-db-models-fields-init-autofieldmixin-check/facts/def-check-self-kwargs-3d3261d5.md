# Fact 3d3261d5

Store id: 025bc623-2788-474e-8b0b-cd28bf5d46a6

## Text

```text
def check(self, **kwargs)
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
- posted_at: `2026-11-09T23:31:56.8933800+00:00`

## Data

```json
{
  "end_line": 2885,
  "entity_kind": "method",
  "parent": "AutoFieldMixin",
  "start_line": 2881,
  "symbol": "AutoFieldMixin.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2881,"selector":"L2881-L2885","symbol":"AutoFieldMixin.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoFieldMixin.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2885,
    "entity_kind": "method",
    "parent": "AutoFieldMixin",
    "start_line": 2881,
    "symbol": "AutoFieldMixin.check"
  },
  "id": "025bc623-2788-474e-8b0b-cd28bf5d46a6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8933800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2881,
        "selector": "L2881-L2885",
        "symbol": "AutoFieldMixin.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "65cf3c82-db91-4d71-b62b-6c6a6340ba0f",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
