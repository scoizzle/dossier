# Fact 3f4a9716

Store id: 1e2c13a4-3356-451a-8017-fc252b48d434

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
- posted_at: `2026-11-09T23:31:56.7729330+00:00`

## Data

```json
{
  "end_line": 2461,
  "entity_kind": "method",
  "parent": "PositiveIntegerField",
  "start_line": 2460,
  "symbol": "PositiveIntegerField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2460,"selector":"L2460-L2461","symbol":"PositiveIntegerField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::PositiveIntegerField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2461,
    "entity_kind": "method",
    "parent": "PositiveIntegerField",
    "start_line": 2460,
    "symbol": "PositiveIntegerField.get_internal_type"
  },
  "id": "1e2c13a4-3356-451a-8017-fc252b48d434",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7729330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2460,
        "selector": "L2460-L2461",
        "symbol": "PositiveIntegerField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "b585a19e-36ae-458b-8989-a589d31edb72",
  "subject_name": "django/db/models/fields/__init__::PositiveIntegerField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
