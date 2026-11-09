# Fact d8bb0675

Store id: 1f6e88e0-ab8c-4f90-94b3-9e4aa49a2430

## Text

```text
def get_or_create(self, *, through_defaults=None, **kwargs)
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
- posted_at: `2026-11-09T22:39:44.9246670+00:00`

## Data

```json
{
  "end_line": 1467,
  "entity_kind": "method",
  "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
  "start_line": 1458,
  "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.get_or_create"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1458,"selector":"L1458-L1467","symbol":"create_forward_many_to_many_manager.ManyRelatedManager.get_or_create"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.get_or_create](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1467,
    "entity_kind": "method",
    "parent": "create_forward_many_to_many_manager.ManyRelatedManager",
    "start_line": 1458,
    "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.get_or_create"
  },
  "id": "1f6e88e0-ab8c-4f90-94b3-9e4aa49a2430",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.9246670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1458,
        "selector": "L1458-L1467",
        "symbol": "create_forward_many_to_many_manager.ManyRelatedManager.get_or_create"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "6275cad6-6481-4375-843a-333c6185a2d3",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager.ManyRelatedManager.get_or_create",
  "tags": [
    "entity:method"
  ],
  "text": "def get_or_create(self, *, through_defaults=None, **kwargs)"
}
```
