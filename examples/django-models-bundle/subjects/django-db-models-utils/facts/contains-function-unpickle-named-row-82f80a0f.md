# Fact 82f80a0f

Store id: 86c5f79c-6a3a-4675-9bd3-573c45a8079e

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
- posted_at: `2026-11-09T23:45:00.0778950+00:00`

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
  "id": "86c5f79c-6a3a-4675-9bd3-573c45a8079e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:45:00.0778950+00:00"
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
      "target": "b845d95c-745c-4b1b-8e79-54e14fa0244f"
    }
  ],
  "status": "live",
  "subject_id": "3a2f8b91-5e76-4523-aac0-4f1c8c9f9145",
  "subject_name": "django/db/models/utils",
  "tags": [
    "entity:function"
  ],
  "text": "contains function unpickle_named_row"
}
```
