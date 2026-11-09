# Fact d0480ca6

Store id: 65bdd11d-70ac-4b9a-8c0f-62cbc2ac1784

## Text

```text
contains class EmailField
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
  - target: [django/db/models/fields/__init__::EmailField](../../django-db-models-fields-init-emailfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1997,"symbol":"EmailField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "65bdd11d-70ac-4b9a-8c0f-62cbc2ac1784",
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
        "line": 1997,
        "symbol": "EmailField"
      },
      "rel": "contains",
      "target": "6fe67d0d-d0f5-4a93-9afb-61ac3bbf6dd2"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class EmailField"
}
```
