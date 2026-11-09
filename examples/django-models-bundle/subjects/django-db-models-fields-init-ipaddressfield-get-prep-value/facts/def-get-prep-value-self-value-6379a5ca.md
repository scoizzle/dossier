# Fact 6379a5ca

Store id: 90386fc7-8535-44b2-ae27-c8690003c428

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
- posted_at: `2026-11-09T22:39:42.5668040+00:00`

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
  "id": "90386fc7-8535-44b2-ae27-c8690003c428",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5668040+00:00"
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
  "subject_id": "1b58bf2c-45e6-47a8-9319-afc18392b9bf",
  "subject_name": "django/db/models/fields/__init__::IPAddressField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
