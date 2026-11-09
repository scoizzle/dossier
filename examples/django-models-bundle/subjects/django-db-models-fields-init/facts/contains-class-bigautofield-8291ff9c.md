# Fact 8291ff9c

Store id: 42e0aa4a-a1ad-4168-aba9-6c9300398b2f

## Text

```text
contains class BigAutoField
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
  - target: [django/db/models/fields/__init__::BigAutoField](../../django-db-models-fields-init-bigautofield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2971,"symbol":"BigAutoField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "42e0aa4a-a1ad-4168-aba9-6c9300398b2f",
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
        "line": 2971,
        "symbol": "BigAutoField"
      },
      "rel": "contains",
      "target": "8d16b83d-2240-45ed-922e-d3f0362aaf0c"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class BigAutoField"
}
```
