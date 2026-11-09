# Fact 276293c9

Store id: 0b135a1a-d34a-4739-9fdc-a4b1927efc36

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
- posted_at: `2026-11-09T23:31:59.2315560+00:00`

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
  "id": "0b135a1a-d34a-4739-9fdc-a4b1927efc36",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2315560+00:00"
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
  "subject_id": "2c7c2a5f-cc8e-4cf8-af7a-d33061e33b6d",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedManager(superclass, AltersData)"
}
```
