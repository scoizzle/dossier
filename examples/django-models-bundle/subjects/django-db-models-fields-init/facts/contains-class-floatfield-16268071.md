# Fact 16268071

Store id: 506a345e-6619-427b-8f6b-6a9e2470495d

## Text

```text
contains class FloatField
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
  - target: [django/db/models/fields/__init__::FloatField](../../django-db-models-fields-init-floatfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2099,"symbol":"FloatField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "506a345e-6619-427b-8f6b-6a9e2470495d",
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
        "line": 2099,
        "symbol": "FloatField"
      },
      "rel": "contains",
      "target": "424c4d3e-a9e3-47f0-9747-6fd5ad1c7ff9"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class FloatField"
}
```
