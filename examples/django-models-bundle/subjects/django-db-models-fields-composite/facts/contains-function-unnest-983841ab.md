# Fact 983841ab

Store id: 37132d9c-c09e-4279-961e-7f9c76f44177

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
- posted_at: `2026-11-09T23:31:57.1501670+00:00`

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
  "id": "37132d9c-c09e-4279-961e-7f9c76f44177",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.1501670+00:00"
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
      "target": "4d8ccf57-2293-4b4d-82a9-fb5f5fcae52f"
    }
  ],
  "status": "live",
  "subject_id": "491ed372-374e-4a6d-8e01-91b4c3f9a27f",
  "subject_name": "django/db/models/fields/composite",
  "tags": [
    "entity:function"
  ],
  "text": "contains function unnest"
}
```
