# Fact d0480ca6

Store id: 51677878-bdb2-4e6b-b1cc-3f89388cd417

## Text

```text
contains class EmailField
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
  - target: [django/db/models/fields/__init__::EmailField](../../django-db-models-fields-init-emailfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1997,"symbol":"EmailField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "51677878-bdb2-4e6b-b1cc-3f89388cd417",
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
        "line": 1997,
        "symbol": "EmailField"
      },
      "rel": "contains",
      "target": "86349baa-9006-4bc7-8a4c-82406d3e39eb"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class EmailField"
}
```
