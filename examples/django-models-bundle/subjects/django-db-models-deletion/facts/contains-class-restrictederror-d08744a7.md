# Fact d08744a7

Store id: 0338246a-60f0-471c-81b0-d175b68260a8

## Text

```text
contains class RestrictedError
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
  - target: [django/db/models/deletion::RestrictedError](../../django-db-models-deletion-restrictederror/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":16,"symbol":"RestrictedError"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "0338246a-60f0-471c-81b0-d175b68260a8",
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
        "line": 16,
        "symbol": "RestrictedError"
      },
      "rel": "contains",
      "target": "038549c6-3872-47c4-b9e8-c2e4c334a88f"
    }
  ],
  "status": "live",
  "subject_id": "c6ec8df1-dcd1-4e95-abda-df3f68ba6875",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:class"
  ],
  "text": "contains class RestrictedError"
}
```
