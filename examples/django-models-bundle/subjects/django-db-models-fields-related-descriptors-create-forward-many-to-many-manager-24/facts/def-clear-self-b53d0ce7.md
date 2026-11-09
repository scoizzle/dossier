# Fact b53d0ce7

Store id: d55f9816-b422-460b-ab9e-645aad7c17d5

## Text

```text
def clear(self)
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
- posted_at: `2026-11-09T22:39:44.9033210+00:00`

## Data

```json
{
  "end_line": 1385,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1382,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.clear"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1382,"selector":"L1382-L1385","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.clear"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.clear](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1385,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1382,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.clear"
  },
  "id": "d55f9816-b422-460b-ab9e-645aad7c17d5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.9033210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1382,
        "selector": "L1382-L1385",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.clear"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "bd6d4e68-5b62-42ed-ac9c-10df5fbc7738",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.clear",
  "tags": [
    "entity:method"
  ],
  "text": "def clear(self)"
}
```
