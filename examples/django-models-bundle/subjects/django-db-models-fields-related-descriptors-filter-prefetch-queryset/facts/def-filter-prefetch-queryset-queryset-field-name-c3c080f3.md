# Fact c3c080f3

Store id: b485f4cf-5acd-4e26-be69-b877cf7c9658

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
- posted_at: `2026-11-09T23:31:59.1215210+00:00`

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
  "id": "b485f4cf-5acd-4e26-be69-b877cf7c9658",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.1215210+00:00"
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
  "subject_id": "bba6c039-d2f3-42e6-8365-18b67bdea874",
  "subject_name": "django/db/models/fields/related_descriptors::_filter_prefetch_queryset",
  "tags": [
    "entity:function"
  ],
  "text": "def _filter_prefetch_queryset(queryset, field_name, instances)"
}
```
