# Fact c4a3fa02

Store id: b4b41098-18ef-4ab7-b4b4-70aaf7d375b6

## Text

```text
contains class OneToOneField
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
- posted_at: `2026-11-09T23:31:58.9119250+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/related::OneToOneField](../../django-db-models-fields-related-onetoonefield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1351,"symbol":"OneToOneField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "b4b41098-18ef-4ab7-b4b4-70aaf7d375b6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.9119250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 1351,
        "symbol": "OneToOneField"
      },
      "rel": "contains",
      "target": "4c1565a5-e2f3-4fc2-b4f0-ffaa30e720a4"
    }
  ],
  "status": "live",
  "subject_id": "2dd9aa9c-962a-42d5-9466-04fc4602083a",
  "subject_name": "django/db/models/fields/related",
  "tags": [
    "entity:class"
  ],
  "text": "contains class OneToOneField"
}
```
