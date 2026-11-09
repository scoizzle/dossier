# Fact 8311f0d5

Store id: 4e95e549-5e45-438f-b382-7e4cf6f5a365

## Text

```text
contains class URLField
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
  - target: [django/db/models/fields/__init__::URLField](../../django-db-models-fields-init-urlfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2719,"symbol":"URLField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "4e95e549-5e45-438f-b382-7e4cf6f5a365",
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
        "line": 2719,
        "symbol": "URLField"
      },
      "rel": "contains",
      "target": "92219de1-b0f8-4018-a780-b1f829ad800d"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class URLField"
}
```
