# Fact 05494c1f

Store id: a0ef68b9-e11a-4777-99a4-89a6d36fbea3

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
- posted_at: `2026-11-09T23:31:56.8810720+00:00`

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
  "id": "a0ef68b9-e11a-4777-99a4-89a6d36fbea3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8810720+00:00"
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
  "subject_id": "cba59bb5-fd53-4d48-a877-9e75bd449362",
  "subject_name": "django/db/models/fields/__init__::UUIDField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
