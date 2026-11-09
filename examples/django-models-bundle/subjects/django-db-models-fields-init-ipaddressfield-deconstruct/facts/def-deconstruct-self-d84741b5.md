# Fact d84741b5

Store id: 2394e178-e4fa-4616-b4ac-b344dca35f2c

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
- posted_at: `2026-11-09T23:44:50.1827190+00:00`

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
  "id": "2394e178-e4fa-4616-b4ac-b344dca35f2c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1827190+00:00"
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
  "subject_id": "79f4d0f5-3c3c-4d3e-b3e5-5b0b73b1db7c",
  "subject_name": "django/db/models/fields/__init__::IPAddressField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
