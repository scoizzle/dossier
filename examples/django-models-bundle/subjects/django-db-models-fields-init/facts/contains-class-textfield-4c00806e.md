# Fact 4c00806e

Store id: 177d584a-b4d0-414c-87bd-aca10cad30bc

## Text

```text
contains class TextField
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
  - target: [django/db/models/fields/__init__::TextField](../../django-db-models-fields-init-textfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2524,"symbol":"TextField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "177d584a-b4d0-414c-87bd-aca10cad30bc",
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
        "line": 2524,
        "symbol": "TextField"
      },
      "rel": "contains",
      "target": "7a0c4c34-ea50-4dea-a384-624939481b43"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class TextField"
}
```
