# Fact ed8bf698

Store id: 4a56ee98-0384-4324-a69d-5a0e84e31986

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
- posted_at: `2026-11-09T23:44:52.0221380+00:00`

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
  "id": "4a56ee98-0384-4324-a69d-5a0e84e31986",
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
    "posted_at": "2026-11-09T23:44:52.0221380+00:00"
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
  "subject_id": "6f1d7993-2912-4fae-b800-8d47d9f3af4e",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager._get_add_plan",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_add_plan(self, db, source_field_name)"
}
```
