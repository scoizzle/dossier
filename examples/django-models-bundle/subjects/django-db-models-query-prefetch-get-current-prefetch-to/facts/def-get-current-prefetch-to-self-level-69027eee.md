# Fact 69027eee

Store id: a761beae-75eb-4d54-a242-5648be0c6c00

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
- posted_at: `2026-11-09T23:44:56.2901310+00:00`

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
  "id": "a761beae-75eb-4d54-a242-5648be0c6c00",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.2901310+00:00"
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
  "subject_id": "53a6b9bd-e539-4843-ba9d-c69f84bb315d",
  "subject_name": "django/db/models/query::Prefetch.get_current_prefetch_to",
  "tags": [
    "entity:method"
  ],
  "text": "def get_current_prefetch_to(self, level)"
}
```
