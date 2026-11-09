# Fact 9b481f34

Store id: 8cbf8d41-ab0b-4ccb-8fea-5ade9de69cde

## Text

```text
contains class TimeField
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
  - target: [django/db/models/fields/__init__::TimeField](../../django-db-models-fields-init-timefield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2601,"symbol":"TimeField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "8cbf8d41-ab0b-4ccb-8fea-5ade9de69cde",
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
        "line": 2601,
        "symbol": "TimeField"
      },
      "rel": "contains",
      "target": "b16787ae-9e08-4c43-b8b6-1e829a6c73db"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class TimeField"
}
```
