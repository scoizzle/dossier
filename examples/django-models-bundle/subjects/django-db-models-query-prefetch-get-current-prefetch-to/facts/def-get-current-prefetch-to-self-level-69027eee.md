# Fact 69027eee

Store id: cb51e933-cac6-4127-af15-d3923904b5a7

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
- posted_at: `2026-11-09T23:32:04.7984320+00:00`

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
  "id": "cb51e933-cac6-4127-af15-d3923904b5a7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.7984320+00:00"
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
  "subject_id": "ef6f8cd9-480d-47ba-a6f6-263ab0b98369",
  "subject_name": "django/db/models/query::Prefetch.get_current_prefetch_to",
  "tags": [
    "entity:method"
  ],
  "text": "def get_current_prefetch_to(self, level)"
}
```
