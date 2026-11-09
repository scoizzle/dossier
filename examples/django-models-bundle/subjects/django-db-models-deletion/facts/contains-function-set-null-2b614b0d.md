# Fact 2b614b0d

Store id: a4963d2f-4ce8-45f3-aad7-44c3aa406546

## Text

```text
contains function SET_NULL
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
  - target: [django/db/models/deletion::SET_NULL](../../django-db-models-deletion-set-null/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":69,"symbol":"SET_NULL"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "a4963d2f-4ce8-45f3-aad7-44c3aa406546",
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
        "line": 69,
        "symbol": "SET_NULL"
      },
      "rel": "contains",
      "target": "df6ab8b7-a190-40a3-8b19-e53b3db58249"
    }
  ],
  "status": "live",
  "subject_id": "64ffe9c5-9ade-4b8f-a82d-b80d0ea921ae",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function SET_NULL"
}
```
