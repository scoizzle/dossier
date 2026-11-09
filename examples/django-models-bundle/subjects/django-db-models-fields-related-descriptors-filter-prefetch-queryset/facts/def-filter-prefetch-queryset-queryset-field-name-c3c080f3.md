# Fact c3c080f3

Store id: 40c8840c-2010-40cf-b8fe-569312f63058

## Text

```text
def _filter_prefetch_queryset(queryset, field_name, instances)
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
- posted_at: `2026-11-09T23:44:51.8159830+00:00`

## Data

```json
{
  "end_line": 117,
  "entity_kind": "function",
  "parent": "related_descriptors",
  "start_line": 96,
  "symbol": "_filter_prefetch_queryset"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":96,"selector":"L96-L117","symbol":"_filter_prefetch_queryset"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::_filter_prefetch_queryset](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 117,
    "entity_kind": "function",
    "parent": "related_descriptors",
    "start_line": 96,
    "symbol": "_filter_prefetch_queryset"
  },
  "id": "40c8840c-2010-40cf-b8fe-569312f63058",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.8159830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 96,
        "selector": "L96-L117",
        "symbol": "_filter_prefetch_queryset"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "30a3abf2-ddc7-4b62-9bb1-490766512f41",
  "subject_name": "django/db/models/fields/related_descriptors::_filter_prefetch_queryset",
  "tags": [
    "entity:function"
  ],
  "text": "def _filter_prefetch_queryset(queryset, field_name, instances)"
}
```
