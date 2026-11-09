# Fact b30d415b

Store id: c0151bcd-3ab7-41b8-9885-cbb1d88173da

## Text

```text
contains class BinaryField
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
- posted_at: `2026-11-09T23:44:50.3490680+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/__init__::BinaryField](../../django-db-models-fields-init-binaryfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2744,"symbol":"BinaryField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "c0151bcd-3ab7-41b8-9885-cbb1d88173da",
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
        "line": 2744,
        "symbol": "BinaryField"
      },
      "rel": "contains",
      "target": "d8a9e00c-74fa-462d-99af-c10d0ada74a1"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class BinaryField"
}
```
