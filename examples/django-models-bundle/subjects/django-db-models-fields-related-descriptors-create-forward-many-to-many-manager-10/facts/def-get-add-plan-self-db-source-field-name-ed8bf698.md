# Fact ed8bf698

Store id: 5a881ae0-17e5-4b64-8a75-f1d66948fc40

## Text

```text
def _get_add_plan(self, db, source_field_name)
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
- posted_at: `2026-11-09T22:39:44.9420940+00:00`

## Data

```json
{
  "end_line": 1580,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1549,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._get_add_plan"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1549,"selector":"L1549-L1580","symbol":"create_forward_many_to_many_manager.ManyRelatedManager._get_add_plan"}`

## Items

```json
[
  {
    "text": "Return a boolean triple of the way the add should be performed.",
    "locator": {
      "line": 1550
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._get_add_plan](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1580,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1549,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._get_add_plan"
  },
  "id": "5a881ae0-17e5-4b64-8a75-f1d66948fc40",
  "items": [
    {
      "locator": {
        "line": 1550
      },
      "text": "Return a boolean triple of the way the add should be performed."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.9420940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1549,
        "selector": "L1549-L1580",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager._get_add_plan"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "cc3bc27b-291f-4691-96fc-4dc331892f67",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._get_add_plan",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_add_plan(self, db, source_field_name)"
}
```
