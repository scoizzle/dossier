# Fact 104099ed

Store id: 7fd7cb25-6f71-4ab3-8d5d-553cb8b612bc

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T22:39:48.4712270+00:00`

## Data

```json
{
  "end_line": 77,
  "entity_kind": "method",
  "parent": "BaseManager",
  "start_line": 42,
  "symbol": "BaseManager.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":42,"selector":"L42-L77","symbol":"BaseManager.deconstruct"}`

## Items

```json
[
  {
    "text": "Return a 5-tuple of the form (as_manager (True), manager_class, queryset_class, args, kwargs).",
    "locator": {
      "line": 43
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 77,
    "entity_kind": "method",
    "parent": "BaseManager",
    "start_line": 42,
    "symbol": "BaseManager.deconstruct"
  },
  "id": "7fd7cb25-6f71-4ab3-8d5d-553cb8b612bc",
  "items": [
    {
      "locator": {
        "line": 43
      },
      "text": "Return a 5-tuple of the form (as_manager (True), manager_class, queryset_class, args, kwargs)."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.4712270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 42,
        "selector": "L42-L77",
        "symbol": "BaseManager.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "ce917370-cf21-4907-ad44-faf5d169ddfe",
  "subject_name": "django/db/models/manager::BaseManager.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
