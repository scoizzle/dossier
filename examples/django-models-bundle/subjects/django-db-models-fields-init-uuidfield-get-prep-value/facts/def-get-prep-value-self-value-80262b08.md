# Fact 80262b08

Store id: b31d6f8a-34fc-4b2d-a684-a999d6c76e92

## Text

```text
def get_prep_value(self, value)
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
- posted_at: `2026-11-09T23:31:56.8827990+00:00`

## Data

```json
{
  "end_line": 2840,
  "entity_kind": "method",
  "parent": "UUIDField",
  "start_line": 2838,
  "symbol": "UUIDField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2838,"selector":"L2838-L2840","symbol":"UUIDField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::UUIDField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2840,
    "entity_kind": "method",
    "parent": "UUIDField",
    "start_line": 2838,
    "symbol": "UUIDField.get_prep_value"
  },
  "id": "b31d6f8a-34fc-4b2d-a684-a999d6c76e92",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8827990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2838,
        "selector": "L2838-L2840",
        "symbol": "UUIDField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "b7d75eb5-7043-49d5-b8f2-0eabbd66930b",
  "subject_name": "django/db/models/fields/__init__::UUIDField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
