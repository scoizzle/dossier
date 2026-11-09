# Fact f6a5da96

Store id: 95df35c4-91fd-4226-8cb5-04188321f6bf

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
- posted_at: `2026-11-09T23:31:56.9379270+00:00`

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
  "id": "95df35c4-91fd-4226-8cb5-04188321f6bf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.9379270+00:00"
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
      "target": "f604c656-bdb3-4c4a-af07-c5e42b5bc07a"
    }
  ],
  "status": "live",
  "subject_id": "29a60662-6c79-46a0-bd42-f90eed9c7d70",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:function"
  ],
  "text": "contains function _get_naive_now"
}
```
