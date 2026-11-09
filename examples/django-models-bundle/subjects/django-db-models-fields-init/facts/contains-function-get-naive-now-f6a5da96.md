# Fact f6a5da96

Store id: c08fb4f0-7bd4-40a2-b1ad-9e4e60d8253d

## Text

```text
contains function _get_naive_now
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
- posted_at: `2026-11-09T23:44:50.3490680+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/__init__::_get_naive_now](../../django-db-models-fields-init-get-naive-now/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1387,"symbol":"_get_naive_now"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "c08fb4f0-7bd4-40a2-b1ad-9e4e60d8253d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3490680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 1387,
        "symbol": "_get_naive_now"
      },
      "rel": "contains",
      "target": "657c4efe-5d50-453e-a669-b62ced6b5105"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:function"
  ],
  "text": "contains function _get_naive_now"
}
```
