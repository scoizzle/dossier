# Fact a767b4b3

Store id: 5eab86c8-c87b-407c-bf7c-2ac8e079f8b7

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
- posted_at: `2026-11-09T23:44:56.2179520+00:00`

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
  "id": "5eab86c8-c87b-407c-bf7c-2ac8e079f8b7",
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
    "posted_at": "2026-11-09T23:44:56.2179520+00:00"
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
  "subject_id": "1f21a91b-1970-4480-84ba-69889ecfee87",
  "subject_name": "django/db/models/query::RawQuerySet.resolve_model_init_order",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_model_init_order(self)"
}
```
