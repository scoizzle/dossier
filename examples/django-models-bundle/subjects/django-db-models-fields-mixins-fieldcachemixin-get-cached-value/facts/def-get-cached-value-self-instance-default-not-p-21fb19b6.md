# Fact 21fb19b6

Store id: 5b2e832f-a0d7-4816-b9ec-9ab03d63774d

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
- posted_at: `2026-11-09T23:44:51.2017340+00:00`

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
  "id": "5b2e832f-a0d7-4816-b9ec-9ab03d63774d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.2017340+00:00"
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
  "subject_id": "7556c468-07d3-469a-a8fd-ca7661f7bef8",
  "subject_name": "django/db/models/fields/mixins::FieldCacheMixin.get_cached_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_cached_value(self, instance, default=NOT_PROVIDED)"
}
```
