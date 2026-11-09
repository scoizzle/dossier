# Fact 8311f0d5

Store id: 2928ae31-269e-44c7-ba75-78f097bde0bb

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
- posted_at: `2026-11-09T23:31:56.9379270+00:00`

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
  "id": "2928ae31-269e-44c7-ba75-78f097bde0bb",
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
        "line": 2719,
        "symbol": "URLField"
      },
      "rel": "contains",
      "target": "e58bdd34-ecd1-47fa-b3b3-b6b96ffc801d"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class URLField"
}
```
