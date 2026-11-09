# Fact 793f5388

Store id: 33b79c81-847d-43b1-a6ac-e118e199a68e

## Text

```text
contains function _load_field
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
- posted_at: `2026-11-09T23:44:50.3490680+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/__init__::_load_field](../../django-db-models-fields-init-load-field/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":97,"symbol":"_load_field"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "33b79c81-847d-43b1-a6ac-e118e199a68e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3490680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 97,
        "symbol": "_load_field"
      },
      "rel": "contains",
      "target": "6d314da2-7eae-40bd-bb48-dd85dafbfc04"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:function"
  ],
  "text": "contains function _load_field"
}
```
