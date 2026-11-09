# Fact 21fb19b6

Store id: fa4d54bc-2dd0-4010-b4f3-31cc2498369a

## Text

```text
def get_cached_value(self, instance, default=NOT_PROVIDED)
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
- posted_at: `2026-11-09T23:31:58.2239360+00:00`

## Data

```json
{
  "end_line": 25,
  "entity_kind": "method",
  "parent": "FieldCacheMixin",
  "start_line": 19,
  "symbol": "FieldCacheMixin.get_cached_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/mixins.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":19,"selector":"L19-L25","symbol":"FieldCacheMixin.get_cached_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/mixins::FieldCacheMixin.get_cached_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 25,
    "entity_kind": "method",
    "parent": "FieldCacheMixin",
    "start_line": 19,
    "symbol": "FieldCacheMixin.get_cached_value"
  },
  "id": "fa4d54bc-2dd0-4010-b4f3-31cc2498369a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.2239360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 19,
        "selector": "L19-L25",
        "symbol": "FieldCacheMixin.get_cached_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/mixins.py"
    }
  ],
  "status": "live",
  "subject_id": "cc3569c5-868a-4882-9aef-aa1340717123",
  "subject_name": "django/db/models/fields/mixins::FieldCacheMixin.get_cached_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_cached_value(self, instance, default=NOT_PROVIDED)"
}
```
