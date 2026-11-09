# Fact 701b72704d9d85a3

Store id: ced17b68-1083-4541-a290-4691fe9fde91

## Text

```text
contains class Empty
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
- posted_at: `2026-11-09T22:39:42.7718540+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/__init__::Empty](../../django-db-models-fields-init-empty-2/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":80,"symbol":"Empty"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "ced17b68-1083-4541-a290-4691fe9fde91",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7718540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 80,
        "symbol": "Empty"
      },
      "rel": "contains",
      "target": "716ae9f9-445b-4902-a4cd-70c5895b62ca"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Empty"
}
```
