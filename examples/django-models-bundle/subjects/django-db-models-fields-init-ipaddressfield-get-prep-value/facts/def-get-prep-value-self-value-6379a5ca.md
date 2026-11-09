# Fact 6379a5ca

Store id: effa73bc-0684-439f-b720-bedbd91cbd40

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
- posted_at: `2026-11-09T23:31:56.7262870+00:00`

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
  "id": "effa73bc-0684-439f-b720-bedbd91cbd40",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7262870+00:00"
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
  "subject_id": "1a75b768-2f75-461d-a59f-22128ca454a9",
  "subject_name": "django/db/models/fields/__init__::IPAddressField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
