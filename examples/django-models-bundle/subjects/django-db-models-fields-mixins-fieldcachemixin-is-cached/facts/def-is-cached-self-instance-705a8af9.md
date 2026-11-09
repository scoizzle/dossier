# Fact 705a8af9

Store id: 09248371-d036-46db-8400-d792b97c8773

## Text

```text
def is_cached(self, instance)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:58.2266190+00:00`

## Data

```json
{
  "end_line": 28,
  "entity_kind": "method",
  "parent": "FieldCacheMixin",
  "start_line": 27,
  "symbol": "FieldCacheMixin.is_cached"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/mixins.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":27,"selector":"L27-L28","symbol":"FieldCacheMixin.is_cached"}`

## Referenced by

None.

## Subject

[django/db/models/fields/mixins::FieldCacheMixin.is_cached](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 28,
    "entity_kind": "method",
    "parent": "FieldCacheMixin",
    "start_line": 27,
    "symbol": "FieldCacheMixin.is_cached"
  },
  "id": "09248371-d036-46db-8400-d792b97c8773",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.2266190+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 27,
        "selector": "L27-L28",
        "symbol": "FieldCacheMixin.is_cached"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/mixins.py"
    }
  ],
  "status": "live",
  "subject_id": "3af151ad-5057-425c-8f63-7b1d8432b234",
  "subject_name": "django/db/models/fields/mixins::FieldCacheMixin.is_cached",
  "tags": [
    "entity:method"
  ],
  "text": "def is_cached(self, instance)"
}
```
