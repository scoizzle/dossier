# Fact 8fb6cc67

Store id: 0dcd39ea-cafa-4b9c-a7a3-a86cdeff24cd

## Text

```text
contains class ManyToManyField
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
  - target: [django/db/models/fields/related::ManyToManyField](../../django-db-models-fields-related-manytomanyfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1458,"symbol":"ManyToManyField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "0dcd39ea-cafa-4b9c-a7a3-a86cdeff24cd",
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
        "line": 1458,
        "symbol": "ManyToManyField"
      },
      "rel": "contains",
      "target": "42ef2b96-d5fa-431c-82a6-55ba4fa22ede"
    }
  ],
  "status": "live",
  "subject_id": "2dd9aa9c-962a-42d5-9466-04fc4602083a",
  "subject_name": "django/db/models/fields/related",
  "tags": [
    "entity:class"
  ],
  "text": "contains class ManyToManyField"
}
```
