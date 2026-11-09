# Fact 51fb5fd8

Store id: 2355c854-b254-4af8-88eb-a33cbdc2970f

## Text

```text
contains function _to_naive
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:56.9379270+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/__init__::_to_naive](../../django-db-models-fields-init-to-naive/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1381,"symbol":"_to_naive"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "2355c854-b254-4af8-88eb-a33cbdc2970f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.9379270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 1381,
        "symbol": "_to_naive"
      },
      "rel": "contains",
      "target": "bd18f222-4b2f-4a06-b30d-9c12a0098527"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:function"
  ],
  "text": "contains function _to_naive"
}
```
