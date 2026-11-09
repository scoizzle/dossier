# Fact 05494c1f

Store id: 3151538f-9958-4906-8d24-6ecef771ac59

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
- posted_at: `2026-11-09T22:39:42.7133220+00:00`

## Data

```json
{
  "end_line": 2836,
  "entity_kind": "method",
  "parent": "UUIDField",
  "start_line": 2835,
  "symbol": "UUIDField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2835,"selector":"L2835-L2836","symbol":"UUIDField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::UUIDField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2836,
    "entity_kind": "method",
    "parent": "UUIDField",
    "start_line": 2835,
    "symbol": "UUIDField.get_internal_type"
  },
  "id": "3151538f-9958-4906-8d24-6ecef771ac59",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7133220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2835,
        "selector": "L2835-L2836",
        "symbol": "UUIDField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "fa7cd68a-064a-4ae1-a3c5-a9efaf261fcc",
  "subject_name": "django/db/models/fields/__init__::UUIDField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
