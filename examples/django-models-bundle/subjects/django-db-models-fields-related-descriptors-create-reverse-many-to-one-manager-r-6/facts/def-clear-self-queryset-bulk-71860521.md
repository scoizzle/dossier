# Fact 71860521

Store id: 85a60912-9c3b-46cf-a785-0f0987ab96b3

## Text

```text
def _clear(self, queryset, bulk)
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
- posted_at: `2026-11-09T22:39:44.8335870+00:00`

## Data

```json
{
  "end_line": 988,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 977,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager._clear"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":977,"selector":"L977-L988","symbol":"create_reverse_many_to_one_manager.RelatedManager._clear"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager._clear](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 988,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 977,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager._clear"
  },
  "id": "85a60912-9c3b-46cf-a785-0f0987ab96b3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8335870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 977,
        "selector": "L977-L988",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager._clear"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "93164f6b-ed91-41a3-8e51-e28df45fa0cf",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager._clear",
  "tags": [
    "entity:method"
  ],
  "text": "def _clear(self, queryset, bulk)"
}
```
