# Fact 69027eee

Store id: 366d200d-a481-482b-b97b-9eed756426a7

## Text

```text
def get_current_prefetch_to(self, level)
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
- posted_at: `2026-11-09T22:39:49.8510110+00:00`

## Data

```json
{
  "end_line": 2609,
  "entity_kind": "method",
  "parent": "Prefetch",
  "start_line": 2608,
  "symbol": "Prefetch.get_current_prefetch_to"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2608,"selector":"L2608-L2609","symbol":"Prefetch.get_current_prefetch_to"}`

## Referenced by

None.

## Subject

[django/db/models/query::Prefetch.get_current_prefetch_to](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2609,
    "entity_kind": "method",
    "parent": "Prefetch",
    "start_line": 2608,
    "symbol": "Prefetch.get_current_prefetch_to"
  },
  "id": "366d200d-a481-482b-b97b-9eed756426a7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.8510110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2608,
        "selector": "L2608-L2609",
        "symbol": "Prefetch.get_current_prefetch_to"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "63abac74-ae76-45d2-a49d-bc43a8dcb3be",
  "subject_name": "django/db/models/query::Prefetch.get_current_prefetch_to",
  "tags": [
    "entity:method"
  ],
  "text": "def get_current_prefetch_to(self, level)"
}
```
