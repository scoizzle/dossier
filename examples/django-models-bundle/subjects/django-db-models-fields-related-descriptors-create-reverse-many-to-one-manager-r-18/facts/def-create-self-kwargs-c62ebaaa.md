# Fact c62ebaaa

Store id: 568f0365-7f88-481b-9f64-1545af44349e

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
- posted_at: `2026-11-09T23:31:59.2584550+00:00`

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
  "id": "568f0365-7f88-481b-9f64-1545af44349e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.2584550+00:00"
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
  "subject_id": "30cda21d-36e7-40c4-8ddb-db99e348b893",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager.RelatedManager.create",
  "tags": [
    "entity:method"
  ],
  "text": "def create(self, **kwargs)"
}
```
