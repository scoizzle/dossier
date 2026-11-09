# Fact 276293c9

Store id: 47877a88-ffcf-4813-b974-00635d27b47b

## Text

```text
class RelatedManager(superclass, AltersData)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:44.7857710+00:00`

## Data

```json
{
  "end_line": 1023,
  "entity_kind": "class",
  "parent": "create_reverse_many_to_one_manager",
  "start_line": 722,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":722,"selector":"L722-L1023","symbol":"create_reverse_many_to_one_manager.RelatedManager"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1023,
    "entity_kind": "class",
    "parent": "create_reverse_many_to_one_manager",
    "start_line": 722,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager"
  },
  "id": "47877a88-ffcf-4813-b974-00635d27b47b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7857710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 722,
        "selector": "L722-L1023",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "248ebe8b-fd88-4500-901d-29501dc117a1",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedManager(superclass, AltersData)"
}
```
