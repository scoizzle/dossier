# Fact b2d32519

Store id: 7045c361-f100-4dba-be1f-e7fca5f7399f

## Text

```text
contains class BooleanField
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:42.7718540+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/__init__::BooleanField](../../django-db-models-fields-init-booleanfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1200,"symbol":"BooleanField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "7045c361-f100-4dba-be1f-e7fca5f7399f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7718540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 1200,
        "symbol": "BooleanField"
      },
      "rel": "contains",
      "target": "95e67432-77b2-4dcc-ac82-a68c274fddfb"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class BooleanField"
}
```
