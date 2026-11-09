# Fact d84741b5

Store id: e7a15225-b90b-4bc5-9f89-a4d6234a48c3

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
- posted_at: `2026-11-09T22:39:42.5642620+00:00`

## Data

```json
{
  "end_line": 2284,
  "entity_kind": "method",
  "parent": "IPAddressField",
  "start_line": 2281,
  "symbol": "IPAddressField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2281,"selector":"L2281-L2284","symbol":"IPAddressField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IPAddressField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2284,
    "entity_kind": "method",
    "parent": "IPAddressField",
    "start_line": 2281,
    "symbol": "IPAddressField.deconstruct"
  },
  "id": "e7a15225-b90b-4bc5-9f89-a4d6234a48c3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5642620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2281,
        "selector": "L2281-L2284",
        "symbol": "IPAddressField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "982592e5-2e0d-466b-96bf-35685998e699",
  "subject_name": "django/db/models/fields/__init__::IPAddressField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
