# Fact c9d7927d

Store id: 62fdec42-c82f-44ad-b2d2-199ff267bff6

## Text

```text
contains class PositiveIntegerField
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
  - target: [django/db/models/fields/__init__::PositiveIntegerField](../../django-db-models-fields-init-positiveintegerfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2457,"symbol":"PositiveIntegerField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "62fdec42-c82f-44ad-b2d2-199ff267bff6",
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
        "line": 2457,
        "symbol": "PositiveIntegerField"
      },
      "rel": "contains",
      "target": "0244abf2-ef0f-4f3f-991a-d0ec08ae6fb8"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class PositiveIntegerField"
}
```
