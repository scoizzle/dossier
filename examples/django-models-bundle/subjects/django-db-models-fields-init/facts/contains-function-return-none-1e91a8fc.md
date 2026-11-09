# Fact 1e91a8fc

Store id: 8707354b-8e93-4350-b3ae-c8a5601e89f6

## Text

```text
contains function return_None
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:56.9379270+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/__init__::return_None](../../django-db-models-fields-init-return-none/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":123,"symbol":"return_None"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "8707354b-8e93-4350-b3ae-c8a5601e89f6",
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
        "line": 123,
        "symbol": "return_None"
      },
      "rel": "contains",
      "target": "20a8667a-0c3e-41af-b36a-1f633bdced87"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:function"
  ],
  "text": "contains function return_None"
}
```
