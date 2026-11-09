# Fact 30e576d0

Store id: 1c364f05-49a4-4f4e-95a1-88268015ae23

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
- posted_at: `2026-11-09T23:32:07.1571650+00:00`

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
  "id": "1c364f05-49a4-4f4e-95a1-88268015ae23",
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
    "posted_at": "2026-11-09T23:32:07.1571650+00:00"
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
  "subject_id": "9b68c60a-5243-46f6-84e5-1c303ed401b7",
  "subject_name": "django/db/models/sql/query::get_order_dir",
  "tags": [
    "entity:function"
  ],
  "text": "def get_order_dir(field, default=\"ASC\")"
}
```
