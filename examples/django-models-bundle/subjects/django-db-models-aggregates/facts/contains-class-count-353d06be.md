# Fact 353d06be

Store id: 2c9884f1-e91a-4edc-9f8e-2a72655cd1ac

## Text

```text
contains class Count
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
- posted_at: `2026-11-09T22:39:40.0505810+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/aggregates::Count](../../django-db-models-aggregates-count/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":295,"symbol":"Count"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "2c9884f1-e91a-4edc-9f8e-2a72655cd1ac",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0505810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 295,
        "symbol": "Count"
      },
      "rel": "contains",
      "target": "9523552e-5bf3-41e9-9520-28b03320621b"
    }
  ],
  "status": "live",
  "subject_id": "d72d5420-abde-4439-aadc-c9ebfdcfd755",
  "subject_name": "django/db/models/aggregates",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Count"
}
```
