# Fact f3a5d537

Store id: 67e90c3d-b0c7-490e-bbae-c1f4a4b783d8

## Text

```text
contains class ProtectedError
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
- posted_at: `2026-11-09T23:31:55.1285340+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/deletion::ProtectedError](../../django-db-models-deletion-protectederror/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":10,"symbol":"ProtectedError"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "67e90c3d-b0c7-490e-bbae-c1f4a4b783d8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.1285340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 10,
        "symbol": "ProtectedError"
      },
      "rel": "contains",
      "target": "68010fea-7d3f-467d-938b-d7b6801910c8"
    }
  ],
  "status": "live",
  "subject_id": "c6ec8df1-dcd1-4e95-abda-df3f68ba6875",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:class"
  ],
  "text": "contains class ProtectedError"
}
```
