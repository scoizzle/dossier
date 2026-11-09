# Fact d4c56fcf

Store id: aff7917a-e1ce-4d0d-9f02-5dbb45e2f406

## Text

```text
contains function _empty
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
  - target: [django/db/models/fields/__init__::_empty](../../django-db-models-fields-init-empty/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":117,"symbol":"_empty"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "aff7917a-e1ce-4d0d-9f02-5dbb45e2f406",
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
        "line": 117,
        "symbol": "_empty"
      },
      "rel": "contains",
      "target": "44c6a437-037c-4693-896f-4da6eda54377"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:function"
  ],
  "text": "contains function _empty"
}
```
