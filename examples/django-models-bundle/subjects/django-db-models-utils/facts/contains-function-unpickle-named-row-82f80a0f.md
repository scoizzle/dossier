# Fact 82f80a0f

Store id: 130f73cd-b2d6-4fc3-af78-c7e1dcf2ba76

## Text

```text
contains function unpickle_named_row
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
- posted_at: `2026-11-09T22:39:52.1602360+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/utils::unpickle_named_row](../../django-db-models-utils-unpickle-named-row/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":37,"symbol":"unpickle_named_row"}`

## Referenced by

None.

## Subject

[django/db/models/utils](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "130f73cd-b2d6-4fc3-af78-c7e1dcf2ba76",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:52.1602360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 37,
        "symbol": "unpickle_named_row"
      },
      "rel": "contains",
      "target": "60d69f6c-fb7a-458c-a459-e4fb3f3b6769"
    }
  ],
  "status": "live",
  "subject_id": "f5e83459-87b7-40dd-8dc8-0296e557a739",
  "subject_name": "django/db/models/utils",
  "tags": [
    "entity:function"
  ],
  "text": "contains function unpickle_named_row"
}
```
