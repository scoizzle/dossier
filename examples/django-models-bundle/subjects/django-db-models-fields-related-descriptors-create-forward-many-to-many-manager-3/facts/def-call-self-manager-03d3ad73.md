# Fact 03d3ad73

Store id: 7c4a6742-24cb-4ea8-b89e-6d717a416e8e

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
- posted_at: `2026-11-09T23:44:51.9645010+00:00`

## Data

```json
{
  "end_line": 1139,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1134,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.__call__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1134,"selector":"L1134-L1139","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.__call__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.__call__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1139,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1134,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.__call__"
  },
  "id": "7c4a6742-24cb-4ea8-b89e-6d717a416e8e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9645010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1134,
        "selector": "L1134-L1139",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.__call__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "acbab0c6-9733-4cb9-8ba4-008edf26cfda",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.__call__",
  "tags": [
    "entity:method"
  ],
  "text": "def __call__(self, *, manager)"
}
```
