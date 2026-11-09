# Fact 992ee45b

Store id: d703e7ee-5a90-45c4-91d6-3b95042eede0

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
- posted_at: `2026-11-09T23:44:50.1857980+00:00`

## Data

```json
{
  "end_line": 2293,
  "entity_kind": "method",
  "parent": "IPAddressField",
  "start_line": 2292,
  "symbol": "IPAddressField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2292,"selector":"L2292-L2293","symbol":"IPAddressField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IPAddressField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2293,
    "entity_kind": "method",
    "parent": "IPAddressField",
    "start_line": 2292,
    "symbol": "IPAddressField.get_internal_type"
  },
  "id": "d703e7ee-5a90-45c4-91d6-3b95042eede0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1857980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2292,
        "selector": "L2292-L2293",
        "symbol": "IPAddressField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "1c8bd37e-cb65-442c-893d-9cde2065b6ba",
  "subject_name": "django/db/models/fields/__init__::IPAddressField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
