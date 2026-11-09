# Fact e86c0918

Store id: f3c90c71-d741-45c5-be90-1307871d184c

## Text

```text
def add(self, *objs, bulk=True)
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
- posted_at: `2026-11-09T23:31:59.2514880+00:00`

## Data

```json
{
  "end_line": 882,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 847,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.add"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":847,"selector":"L847-L882","symbol":"create_reverse_many_to_one_manager.RelatedManager.add"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.add](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 882,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 847,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.add"
  },
  "id": "f3c90c71-d741-45c5-be90-1307871d184c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2514880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 847,
        "selector": "L847-L882",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.add"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "f4f17943-317a-4e71-8642-78d8a94a5042",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.add",
  "tags": [
    "entity:method"
  ],
  "text": "def add(self, *objs, bulk=True)"
}
```
