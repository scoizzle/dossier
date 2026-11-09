# Fact d0480ca6

Store id: 398ced14-2d81-4b00-add9-5474d50d941c

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
- posted_at: `2026-11-09T23:44:50.3490680+00:00`

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
  "id": "398ced14-2d81-4b00-add9-5474d50d941c",
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
        "line": 1997,
        "symbol": "EmailField"
      },
      "rel": "contains",
      "target": "f5122cf5-0e4c-47bb-8eae-b2ef65cc2360"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class EmailField"
}
```
