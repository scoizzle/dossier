# Fact 1a97ba72

Store id: 81b5b970-e0e5-4159-b4a5-3faaac06eb87

## Text

```text
contains function PROTECT
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
  - target: [django/db/models/deletion::PROTECT](../../django-db-models-deletion-protect/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":34,"symbol":"PROTECT"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "81b5b970-e0e5-4159-b4a5-3faaac06eb87",
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
        "line": 34,
        "symbol": "PROTECT"
      },
      "rel": "contains",
      "target": "fa59e2eb-4a8d-454c-979b-8e2699123cfc"
    }
  ],
  "status": "live",
  "subject_id": "64ffe9c5-9ade-4b8f-a82d-b80d0ea921ae",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:function"
  ],
  "text": "contains function PROTECT"
}
```
