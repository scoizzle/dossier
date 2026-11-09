# Fact 30e576d0

Store id: 97a303f8-9dc3-48d4-9bda-a8fe6679f96a

## Text

```text
def get_order_dir(field, default="ASC")
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:59.0654020+00:00`

## Data

```json
{
  "end_line": 2805,
  "entity_kind": "function",
  "parent": "query",
  "start_line": 2794,
  "symbol": "get_order_dir"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2794,"selector":"L2794-L2805","symbol":"get_order_dir"}`

## Items

```json
[
  {
    "text": "Return the field name and direction for an order specification. For example, '-foo' is returned as ('foo', 'DESC').",
    "locator": {
      "line": 2795
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::get_order_dir](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2805,
    "entity_kind": "function",
    "parent": "query",
    "start_line": 2794,
    "symbol": "get_order_dir"
  },
  "id": "97a303f8-9dc3-48d4-9bda-a8fe6679f96a",
  "items": [
    {
      "locator": {
        "line": 2795
      },
      "text": "Return the field name and direction for an order specification. For example, '-foo' is returned as ('foo', 'DESC')."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.0654020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2794,
        "selector": "L2794-L2805",
        "symbol": "get_order_dir"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "d5703cb8-6992-45c9-9764-8ce0758c79fe",
  "subject_name": "django/db/models/sql/query::get_order_dir",
  "tags": [
    "entity:function"
  ],
  "text": "def get_order_dir(field, default=\"ASC\")"
}
```
