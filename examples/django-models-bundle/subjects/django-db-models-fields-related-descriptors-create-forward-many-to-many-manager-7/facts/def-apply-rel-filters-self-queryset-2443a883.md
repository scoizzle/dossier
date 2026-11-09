# Fact 2443a883

Store id: 6eae53dc-b97a-413d-87e9-fd28673256d6

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
- posted_at: `2026-11-09T22:39:44.8622300+00:00`

## Data

```json
{
  "end_line": 1173,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1163,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._apply_rel_filters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1163,"selector":"L1163-L1173","symbol":"create_forward_many_to_many_manager.ManyRelatedManager._apply_rel_filters"}`

## Items

```json
[
  {
    "text": "Filter the queryset for the instance this manager is bound to.",
    "locator": {
      "line": 1164
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._apply_rel_filters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1173,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1163,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._apply_rel_filters"
  },
  "id": "6eae53dc-b97a-413d-87e9-fd28673256d6",
  "items": [
    {
      "locator": {
        "line": 1164
      },
      "text": "Filter the queryset for the instance this manager is bound to."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8622300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1163,
        "selector": "L1163-L1173",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._apply_rel_filters"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "127eb204-abe8-4cf7-af0e-26d9b9485e55",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._apply_rel_filters",
  "tags": [
    "entity:method"
  ],
  "text": "def _apply_rel_filters(self, queryset)"
}
```
