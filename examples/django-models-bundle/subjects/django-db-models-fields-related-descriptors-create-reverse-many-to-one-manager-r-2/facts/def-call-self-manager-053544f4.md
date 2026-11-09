# Fact 053544f4

Store id: 7cb7d31c-235c-4db3-b882-fe0406ffadcb

## Text

```text
def __call__(self, *, manager)
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
- posted_at: `2026-11-09T23:31:59.2358010+00:00`

## Data

```json
{
  "end_line": 735,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 732,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.__call__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":732,"selector":"L732-L735","symbol":"create_reverse_many_to_one_manager.RelatedManager.__call__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.__call__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 735,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 732,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.__call__"
  },
  "id": "7cb7d31c-235c-4db3-b882-fe0406ffadcb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2358010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 732,
        "selector": "L732-L735",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.__call__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "ec6af710-9110-4a92-9e1d-98af149ff8fb",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.__call__",
  "tags": [
    "entity:method"
  ],
  "text": "def __call__(self, *, manager)"
}
```
