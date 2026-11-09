# Fact c3c080f3

Store id: 5e13d8c6-0c13-4183-9951-8d5f9abe88c7

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
- posted_at: `2026-11-09T22:39:44.6871010+00:00`

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
  "id": "5e13d8c6-0c13-4183-9951-8d5f9abe88c7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.6871010+00:00"
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
  "subject_id": "b1664099-2dd5-4838-8f95-ed343dfee2f4",
  "subject_name": "django/db/models/fields/related_descriptors::_filter_prefetch_queryset",
  "tags": [
    "entity:function"
  ],
  "text": "def _filter_prefetch_queryset(queryset, field_name, instances)"
}
```
