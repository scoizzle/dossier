# Fact b16d782f

Store id: 5c875e9d-88fb-456b-ad4c-aac6d55228b0

## Text

```text
contains class RawSQL
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
- posted_at: `2026-11-09T23:44:49.6980740+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/expressions::RawSQL](../../django-db-models-expressions-rawsql/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1268,"symbol":"RawSQL"}`

## Referenced by

None.

## Subject

[django/db/models/expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "5c875e9d-88fb-456b-ad4c-aac6d55228b0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6980740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 1268,
        "symbol": "RawSQL"
      },
      "rel": "contains",
      "target": "038242a9-4276-455d-aa7a-142f2df9848e"
    }
  ],
  "status": "live",
  "subject_id": "28327a89-66c3-4156-a323-5c05be9f6cae",
  "subject_name": "django/db/models/expressions",
  "tags": [
    "entity:class"
  ],
  "text": "contains class RawSQL"
}
```
