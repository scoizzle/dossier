# Fact a41e48b1

Store id: 300d9dc8-7ebe-4b99-b8ad-a18f5234db58

## Text

```text
contains class UniqueConstraint
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
- posted_at: `2026-11-09T23:31:54.3332080+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/constraints::UniqueConstraint](../../django-db-models-constraints-uniqueconstraint/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":269,"symbol":"UniqueConstraint"}`

## Referenced by

None.

## Subject

[django/db/models/constraints](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "300d9dc8-7ebe-4b99-b8ad-a18f5234db58",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.3332080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 269,
        "symbol": "UniqueConstraint"
      },
      "rel": "contains",
      "target": "9c99d040-c978-4adc-b829-e8d26a1e998e"
    }
  ],
  "status": "live",
  "subject_id": "4329b994-d768-4016-b0c5-b696dac271e3",
  "subject_name": "django/db/models/constraints",
  "tags": [
    "entity:class"
  ],
  "text": "contains class UniqueConstraint"
}
```
