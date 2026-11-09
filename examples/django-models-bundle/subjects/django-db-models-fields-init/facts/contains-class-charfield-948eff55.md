# Fact 948eff55

Store id: 5de46d28-c174-4839-84cc-7f1848021c69

## Text

```text
contains class CharField
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
  - target: [django/db/models/fields/__init__::CharField](../../django-db-models-fields-init-charfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1246,"symbol":"CharField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "5de46d28-c174-4839-84cc-7f1848021c69",
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
        "line": 1246,
        "symbol": "CharField"
      },
      "rel": "contains",
      "target": "6e4fa724-7ad2-4b16-a555-2487fe0c72c6"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class CharField"
}
```
