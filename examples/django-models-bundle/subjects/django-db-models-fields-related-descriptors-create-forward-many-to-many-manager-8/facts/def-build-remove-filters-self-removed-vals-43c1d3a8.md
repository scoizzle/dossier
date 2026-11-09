# Fact 43c1d3a8

Store id: d2108afb-64ae-4901-b9d6-ed7daeb607c0

## Text

```text
def _build_remove_filters(self, removed_vals)
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
- posted_at: `2026-11-09T22:39:44.8600590+00:00`

## Data

```json
{
  "end_line": 1161,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1143,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._build_remove_filters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1143,"selector":"L1143-L1161","symbol":"create_forward_many_to_many_manager.ManyRelatedManager._build_remove_filters"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._build_remove_filters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1161,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1143,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._build_remove_filters"
  },
  "id": "d2108afb-64ae-4901-b9d6-ed7daeb607c0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8600590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1143,
        "selector": "L1143-L1161",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._build_remove_filters"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "1f7321bb-75e7-4616-b3d8-0bb855d1b03e",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._build_remove_filters",
  "tags": [
    "entity:method"
  ],
  "text": "def _build_remove_filters(self, removed_vals)"
}
```
