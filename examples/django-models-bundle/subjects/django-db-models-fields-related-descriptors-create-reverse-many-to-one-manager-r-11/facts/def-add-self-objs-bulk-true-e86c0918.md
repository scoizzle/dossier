# Fact e86c0918

Store id: bdf81e4f-e7b8-432a-af4e-4352f385055b

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
- posted_at: `2026-11-09T23:44:51.9180550+00:00`

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
  "id": "bdf81e4f-e7b8-432a-af4e-4352f385055b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9180550+00:00"
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
  "subject_id": "a05216ca-3bf7-40c6-9070-1c717d830533",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.add",
  "tags": [
    "entity:method"
  ],
  "text": "def add(self, *objs, bulk=True)"
}
```
