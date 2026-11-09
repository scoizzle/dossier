# Fact 59c50a22

Store id: 5691a1ea-0a87-47f2-bf98-5e51d3263416

## Text

```text
contains class NullBooleanField
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
  - target: [django/db/models/fields/__init__::NullBooleanField](../../django-db-models-fields-init-nullbooleanfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2387,"symbol":"NullBooleanField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "5691a1ea-0a87-47f2-bf98-5e51d3263416",
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
        "line": 2387,
        "symbol": "NullBooleanField"
      },
      "rel": "contains",
      "target": "8897c3b8-2bef-413e-ade8-0faa2980ac3e"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class NullBooleanField"
}
```
