# Fact 57084b8b

Store id: 75393684-e64d-4dec-bd05-ed562c632aac

## Text

```text
contains function DO_NOTHING
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
- posted_at: `2026-11-09T23:44:48.9179750+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/deletion::DO_NOTHING](../../django-db-models-deletion-do-nothing/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":80,"symbol":"DO_NOTHING"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "75393684-e64d-4dec-bd05-ed562c632aac",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.9179750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 80,
        "symbol": "DO_NOTHING"
      },
      "rel": "contains",
      "target": "b362266c-fd46-4081-a387-0dfca0088dd3"
    }
  ],
  "status": "live",
  "subject_id": "64ffe9c5-9ade-4b8f-a82d-b80d0ea921ae",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function DO_NOTHING"
}
```
