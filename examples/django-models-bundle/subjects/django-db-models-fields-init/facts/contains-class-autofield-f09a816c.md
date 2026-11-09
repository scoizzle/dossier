# Fact f09a816c

Store id: b3b0b70c-2ea3-4fd2-a756-624a8714fd6f

## Text

```text
contains class AutoField
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
  - target: [django/db/models/fields/__init__::AutoField](../../django-db-models-fields-init-autofield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2963,"symbol":"AutoField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "b3b0b70c-2ea3-4fd2-a756-624a8714fd6f",
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
        "line": 2963,
        "symbol": "AutoField"
      },
      "rel": "contains",
      "target": "8908ccbf-fd13-4a7c-875b-18d27776b03d"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class AutoField"
}
```
