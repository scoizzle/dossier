# Fact b95a0e97

Store id: 58fd3db2-cfbd-41ba-a5ac-e6b4a0054b08

## Text

```text
def get_queryset(self)
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
- posted_at: `2026-11-09T23:31:59.2458060+00:00`

## Data

```json
{
  "end_line": 812,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 797,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.get_queryset"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":797,"selector":"L797-L812","symbol":"create_reverse_many_to_one_manager.RelatedManager.get_queryset"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.get_queryset](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 812,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 797,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.get_queryset"
  },
  "id": "58fd3db2-cfbd-41ba-a5ac-e6b4a0054b08",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2458060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 797,
        "selector": "L797-L812",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.get_queryset"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "a29bde21-3361-47a4-b0a1-24bac3002b59",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.get_queryset",
  "tags": [
    "entity:method"
  ],
  "text": "def get_queryset(self)"
}
```
