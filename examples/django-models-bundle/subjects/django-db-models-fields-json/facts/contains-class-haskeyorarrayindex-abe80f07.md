# Fact abe80f07

Store id: e62f2ef8-fa48-491f-a35c-47155fcbf098

## Text

```text
contains class HasKeyOrArrayIndex
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
- posted_at: `2026-11-09T23:31:58.0480240+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/json::HasKeyOrArrayIndex](../../django-db-models-fields-json-haskeyorarrayindex/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":289,"symbol":"HasKeyOrArrayIndex"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "e62f2ef8-fa48-491f-a35c-47155fcbf098",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.0480240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 289,
        "symbol": "HasKeyOrArrayIndex"
      },
      "rel": "contains",
      "target": "30f5884b-13ef-4f79-b95e-36086e2bca24"
    }
  ],
  "status": "live",
  "subject_id": "d7c21811-3589-45c9-bd5d-3d65ba6227de",
  "subject_name": "django/db/models/fields/json",
  "tags": [
    "entity:class"
  ],
  "text": "contains class HasKeyOrArrayIndex"
}
```
