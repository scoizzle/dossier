# Fact 6379a5ca

Store id: 9b56e165-c5a3-4ce7-aa85-4d107570c648

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
- posted_at: `2026-11-09T23:44:50.1842330+00:00`

## Data

```json
{
  "end_line": 2290,
  "entity_kind": "method",
  "parent": "IPAddressField",
  "start_line": 2286,
  "symbol": "IPAddressField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2286,"selector":"L2286-L2290","symbol":"IPAddressField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IPAddressField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2290,
    "entity_kind": "method",
    "parent": "IPAddressField",
    "start_line": 2286,
    "symbol": "IPAddressField.get_prep_value"
  },
  "id": "9b56e165-c5a3-4ce7-aa85-4d107570c648",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1842330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2286,
        "selector": "L2286-L2290",
        "symbol": "IPAddressField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "8444edc3-080a-4520-af16-4ac6ecb7a24d",
  "subject_name": "django/db/models/fields/__init__::IPAddressField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
