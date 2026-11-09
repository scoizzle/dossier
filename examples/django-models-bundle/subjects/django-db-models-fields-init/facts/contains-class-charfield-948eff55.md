# Fact 948eff55

Store id: d189fc4a-404e-49b4-a73c-b8a027fe3fdd

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
- posted_at: `2026-11-09T23:31:56.9379270+00:00`

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
  "id": "d189fc4a-404e-49b4-a73c-b8a027fe3fdd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.9379270+00:00"
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
      "target": "528759d7-69dd-4c50-ab76-6c5f9e088b54"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class CharField"
}
```
