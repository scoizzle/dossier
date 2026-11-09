# Fact 71860521

Store id: e6bfa3cd-d982-4946-8e95-0c9a4c0a95ce

## Text

```text
def _clear(self, queryset, bulk)
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
- posted_at: `2026-11-09T23:44:51.9444230+00:00`

## Data

```json
{
  "end_line": 988,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 977,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager._clear"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":977,"selector":"L977-L988","symbol":"create_reverse_many_to_one_manager.RelatedManager._clear"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager._clear](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 988,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 977,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager._clear"
  },
  "id": "e6bfa3cd-d982-4946-8e95-0c9a4c0a95ce",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9444230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 977,
        "selector": "L977-L988",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager._clear"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "c1e6edfa-e3d7-4055-b899-8a381d5016c2",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager._clear",
  "tags": [
    "entity:method"
  ],
  "text": "def _clear(self, queryset, bulk)"
}
```
