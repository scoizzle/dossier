# Fact 6fb2b904

Store id: 0221f473-5f3d-4abd-a9e0-f3463a2f4a68

## Text

```text
def clear(self, *, bulk=True)
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
- posted_at: `2026-11-09T22:39:44.8293590+00:00`

## Data

```json
{
  "end_line": 968,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 966,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.clear"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":966,"selector":"L966-L968","symbol":"create_reverse_many_to_one_manager.RelatedManager.clear"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.clear](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 968,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 966,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.clear"
  },
  "id": "0221f473-5f3d-4abd-a9e0-f3463a2f4a68",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8293590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 966,
        "selector": "L966-L968",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.clear"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "216ffca2-50d7-4f50-a3c2-6eb7ed01f4ae",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.clear",
  "tags": [
    "entity:method"
  ],
  "text": "def clear(self, *, bulk=True)"
}
```
