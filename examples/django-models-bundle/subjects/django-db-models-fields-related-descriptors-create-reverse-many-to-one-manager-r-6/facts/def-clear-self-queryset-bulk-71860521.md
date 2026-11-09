# Fact 71860521

Store id: 5c8856ab-8434-4007-b11f-c2ec0748e0e4

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
- posted_at: `2026-11-09T23:31:59.2929120+00:00`

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
  "id": "5c8856ab-8434-4007-b11f-c2ec0748e0e4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2929120+00:00"
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
  "subject_id": "e255c090-9403-48f2-81ba-9ff01b6e12f4",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager._clear",
  "tags": [
    "entity:method"
  ],
  "text": "def _clear(self, queryset, bulk)"
}
```
