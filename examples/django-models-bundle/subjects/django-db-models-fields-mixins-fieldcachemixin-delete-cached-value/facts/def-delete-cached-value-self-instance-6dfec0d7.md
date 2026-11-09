# Fact 6dfec0d7

Store id: 10e9fd89-54cb-4dbc-a57e-37cddaca16d6

## Text

```text
def delete_cached_value(self, instance)
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
- posted_at: `2026-11-09T23:44:51.2069030+00:00`

## Data

```json
{
  "end_line": 34,
  "entity_kind": "method",
  "parent": "FieldCacheMixin",
  "start_line": 33,
  "symbol": "FieldCacheMixin.delete_cached_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/mixins.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":33,"selector":"L33-L34","symbol":"FieldCacheMixin.delete_cached_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/mixins::FieldCacheMixin.delete_cached_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 34,
    "entity_kind": "method",
    "parent": "FieldCacheMixin",
    "start_line": 33,
    "symbol": "FieldCacheMixin.delete_cached_value"
  },
  "id": "10e9fd89-54cb-4dbc-a57e-37cddaca16d6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.2069030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 33,
        "selector": "L33-L34",
        "symbol": "FieldCacheMixin.delete_cached_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/mixins.py"
    }
  ],
  "status": "live",
  "subject_id": "446bb752-ff0f-4407-bc71-3cd001dedce3",
  "subject_name": "django/db/models/fields/mixins::FieldCacheMixin.delete_cached_value",
  "tags": [
    "entity:method"
  ],
  "text": "def delete_cached_value(self, instance)"
}
```
