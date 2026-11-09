# Fact b30d415b

Store id: d548bc46-952c-467b-8d71-2b8c347e389c

## Text

```text
contains class BinaryField
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
  - target: [django/db/models/fields/__init__::BinaryField](../../django-db-models-fields-init-binaryfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2744,"symbol":"BinaryField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "d548bc46-952c-467b-8d71-2b8c347e389c",
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
        "line": 2744,
        "symbol": "BinaryField"
      },
      "rel": "contains",
      "target": "87f170a2-dea3-4a40-a580-06f31acb6333"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class BinaryField"
}
```
