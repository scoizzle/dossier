# Fact 82f80a0f

Store id: b4e9da5c-6f8a-4d6c-a3d9-444ebbce7ad9

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
- posted_at: `2026-11-09T23:32:07.9512730+00:00`

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
  "id": "b4e9da5c-6f8a-4d6c-a3d9-444ebbce7ad9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.9512730+00:00"
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
      "target": "8038e670-20f5-41b8-8454-810262771598"
    }
  ],
  "status": "live",
  "subject_id": "8d25c560-4eac-44c9-a77d-da20cef77164",
  "subject_name": "django/db/models/utils",
  "tags": [
    "entity:function"
  ],
  "text": "contains function unpickle_named_row"
}
```
