# Fact 983841ab

Store id: 72846293-ce3b-4f8f-a450-c2a63983f607

## Text

```text
contains function unnest
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
- posted_at: `2026-11-09T22:39:43.0254600+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/composite::unnest](../../django-db-models-fields-composite-unnest/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":168,"symbol":"unnest"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "72846293-ce3b-4f8f-a450-c2a63983f607",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.0254600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 168,
        "symbol": "unnest"
      },
      "rel": "contains",
      "target": "9149dc15-2f26-410f-b6de-667708ca1215"
    }
  ],
  "status": "live",
  "subject_id": "bc7d2f02-df5f-4f9e-a0c3-51945dbf8415",
  "subject_name": "django/db/models/fields/composite",
  "tags": [
    "entity:function"
  ],
  "text": "contains function unnest"
}
```
