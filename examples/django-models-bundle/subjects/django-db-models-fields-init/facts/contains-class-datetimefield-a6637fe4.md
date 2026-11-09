# Fact a6637fe4

Store id: d67cb20d-d72b-40fc-87f2-e2cf3a3679d5

## Text

```text
contains class DateTimeField
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
  - target: [django/db/models/fields/__init__::DateTimeField](../../django-db-models-fields-init-datetimefield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1599,"symbol":"DateTimeField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "d67cb20d-d72b-40fc-87f2-e2cf3a3679d5",
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
        "line": 1599,
        "symbol": "DateTimeField"
      },
      "rel": "contains",
      "target": "15a81dcd-21ec-42d7-912d-f3af893df2b3"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class DateTimeField"
}
```
