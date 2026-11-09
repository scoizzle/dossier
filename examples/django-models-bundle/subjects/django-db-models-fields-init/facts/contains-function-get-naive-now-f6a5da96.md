# Fact f6a5da96

Store id: f4fced62-88b1-4f58-9f82-1ced350c31d1

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
- posted_at: `2026-11-09T22:39:42.7718540+00:00`

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
  "id": "f4fced62-88b1-4f58-9f82-1ced350c31d1",
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
        "line": 1387,
        "symbol": "_get_naive_now"
      },
      "rel": "contains",
      "target": "f5f50baa-5311-4afe-bf96-8b81fb36adaf"
    }
  ],
  "status": "live",
  "subject_id": "f1f51ac6-feb8-4290-a64b-e2496c526c27",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:function"
  ],
  "text": "contains function _get_naive_now"
}
```
