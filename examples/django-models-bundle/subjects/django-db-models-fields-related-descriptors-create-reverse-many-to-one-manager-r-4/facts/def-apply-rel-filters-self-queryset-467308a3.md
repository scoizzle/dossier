# Fact 467308a3

Store id: c8d287d9-6e59-472a-a9cb-b220b209c617

## Text

```text
def _apply_rel_filters(self, queryset)
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
- posted_at: `2026-11-09T23:44:51.9092380+00:00`

## Data

```json
{
  "end_line": 787,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 747,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager._apply_rel_filters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":747,"selector":"L747-L787","symbol":"create_reverse_many_to_one_manager.RelatedManager._apply_rel_filters"}`

## Items

```json
[
  {
    "text": "Filter the queryset for the instance this manager is bound to.",
    "locator": {
      "line": 748
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager._apply_rel_filters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 787,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 747,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager._apply_rel_filters"
  },
  "id": "c8d287d9-6e59-472a-a9cb-b220b209c617",
  "items": [
    {
      "locator": {
        "line": 748
      },
      "text": "Filter the queryset for the instance this manager is bound to."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9092380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 747,
        "selector": "L747-L787",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager._apply_rel_filters"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "418372fe-ca3b-4a21-a7b7-0e77761968bc",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager._apply_rel_filters",
  "tags": [
    "entity:method"
  ],
  "text": "def _apply_rel_filters(self, queryset)"
}
```
