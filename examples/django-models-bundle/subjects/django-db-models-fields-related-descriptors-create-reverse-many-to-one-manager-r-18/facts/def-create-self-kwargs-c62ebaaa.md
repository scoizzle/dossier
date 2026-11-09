# Fact c62ebaaa

Store id: 63d53c4e-9fbe-4f8b-8035-054c0585a46f

## Text

```text
def create(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:44.8112400+00:00`

## Data

```json
{
  "end_line": 896,
  "entity_kind": "method",
  "parent": "create_reverse_many_to_one_manager.RelatedManager",
  "start_line": 891,
  "symbol": "create_reverse_many_to_one_manager.RelatedManager.create"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":891,"selector":"L891-L896","symbol":"create_reverse_many_to_one_manager.RelatedManager.create"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.create](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 896,
    "entity_kind": "method",
    "parent": "create_reverse_many_to_one_manager.RelatedManager",
    "start_line": 891,
    "symbol": "create_reverse_many_to_one_manager.RelatedManager.create"
  },
  "id": "63d53c4e-9fbe-4f8b-8035-054c0585a46f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8112400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 891,
        "selector": "L891-L896",
        "symbol": "create_reverse_many_to_one_manager.RelatedManager.create"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "38344bc1-e0c7-48e7-9d2e-a65b38845bca",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.create",
  "tags": [
    "entity:method"
  ],
  "text": "def create(self, **kwargs)"
}
```
