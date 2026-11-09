# Fact 053544f4

Store id: 2bff6349-133b-4f8b-a5f1-71f1ad3c4c97

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
- posted_at: `2026-11-09T22:39:44.7902550+00:00`

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
  "id": "2bff6349-133b-4f8b-a5f1-71f1ad3c4c97",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7902550+00:00"
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
  "subject_id": "57c7ddc3-60dd-476f-8c3c-cdd96ff08768",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.__call__",
  "tags": [
    "entity:method"
  ],
  "text": "def __call__(self, *, manager)"
}
```
