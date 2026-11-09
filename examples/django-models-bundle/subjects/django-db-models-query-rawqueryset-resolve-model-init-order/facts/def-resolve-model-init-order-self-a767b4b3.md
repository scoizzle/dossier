# Fact a767b4b3

Store id: c3790617-1b76-440e-b52b-125fdd953077

## Text

```text
def resolve_model_init_order(self)
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
- posted_at: `2026-11-09T23:32:04.7120210+00:00`

## Data

```json
{
  "end_line": 2456,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2439,
  "symbol": "RawQuerySet.resolve_model_init_order"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2439,"selector":"L2439-L2456","symbol":"RawQuerySet.resolve_model_init_order"}`

## Items

```json
[
  {
    "text": "Resolve the init field names and value positions.",
    "locator": {
      "line": 2440
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.resolve_model_init_order](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2456,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2439,
    "symbol": "RawQuerySet.resolve_model_init_order"
  },
  "id": "c3790617-1b76-440e-b52b-125fdd953077",
  "items": [
    {
      "locator": {
        "line": 2440
      },
      "text": "Resolve the init field names and value positions."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.7120210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2439,
        "selector": "L2439-L2456",
        "symbol": "RawQuerySet.resolve_model_init_order"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "2b54c67b-bd7c-4b94-9c40-dcec3f26439a",
  "subject_name": "django/db/models/query::RawQuerySet.resolve_model_init_order",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_model_init_order(self)"
}
```
