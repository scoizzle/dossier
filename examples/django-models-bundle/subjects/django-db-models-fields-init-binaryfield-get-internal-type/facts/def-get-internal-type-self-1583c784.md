# Fact 1583c784

Store id: dc4dcfda-72eb-468f-91a2-9855413c94c0

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
- posted_at: `2026-11-09T22:39:42.6955460+00:00`

## Data

```json
{
  "end_line": 2781,
  "entity_kind": "method",
  "parent": "BinaryField",
  "start_line": 2780,
  "symbol": "BinaryField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2780,"selector":"L2780-L2781","symbol":"BinaryField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BinaryField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2781,
    "entity_kind": "method",
    "parent": "BinaryField",
    "start_line": 2780,
    "symbol": "BinaryField.get_internal_type"
  },
  "id": "dc4dcfda-72eb-468f-91a2-9855413c94c0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6955460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2780,
        "selector": "L2780-L2781",
        "symbol": "BinaryField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "cee3f1ca-5ffa-4e16-992a-ef3fcd11428a",
  "subject_name": "django/db/models/fields/__init__::BinaryField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
