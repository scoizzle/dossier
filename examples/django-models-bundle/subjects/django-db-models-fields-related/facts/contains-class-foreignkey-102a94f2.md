# Fact 102a94f2

Store id: 06ca3bf3-ddb6-499f-bd02-a5b5fcbf1905

## Text

```text
contains class ForeignKey
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
  - target: [django/db/models/fields/related::ForeignKey](../../django-db-models-fields-related-foreignkey/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":970,"symbol":"ForeignKey"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "06ca3bf3-ddb6-499f-bd02-a5b5fcbf1905",
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
        "line": 970,
        "symbol": "ForeignKey"
      },
      "rel": "contains",
      "target": "9490d863-d07c-4a45-8d2d-299f799f141f"
    }
  ],
  "status": "live",
  "subject_id": "2dd9aa9c-962a-42d5-9466-04fc4602083a",
  "subject_name": "django/db/models/fields/related",
  "tags": [
    "entity:class"
  ],
  "text": "contains class ForeignKey"
}
```
