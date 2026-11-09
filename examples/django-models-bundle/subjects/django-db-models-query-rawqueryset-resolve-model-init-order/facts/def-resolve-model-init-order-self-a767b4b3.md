# Fact a767b4b3

Store id: deed3cbd-cf22-4a05-bf1d-040169b25a72

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
- posted_at: `2026-11-09T22:39:49.7734630+00:00`

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
  "id": "deed3cbd-cf22-4a05-bf1d-040169b25a72",
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
    "posted_at": "2026-11-09T22:39:49.7734630+00:00"
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
  "subject_id": "e93636b7-73fa-4a49-9e31-8281ac3d3e06",
  "subject_name": "django/db/models/query::RawQuerySet.resolve_model_init_order",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_model_init_order(self)"
}
```
