# Fact 467308a3

Store id: ff64aefb-c7df-4283-afc7-c1da3921953d

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
- posted_at: `2026-11-09T23:31:59.2411660+00:00`

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
  "id": "ff64aefb-c7df-4283-afc7-c1da3921953d",
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
    "posted_at": "2026-11-09T23:31:59.2411660+00:00"
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
  "subject_id": "d78a60cc-cb88-4341-a08e-8c9f21aec75e",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager._apply_rel_filters",
  "tags": [
    "entity:method"
  ],
  "text": "def _apply_rel_filters(self, queryset)"
}
```
