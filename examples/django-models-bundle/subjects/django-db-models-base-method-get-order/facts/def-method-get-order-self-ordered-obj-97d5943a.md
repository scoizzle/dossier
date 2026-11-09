# Fact 97d5943a

Store id: 45f6478c-c2d1-4ae3-b6d6-8c010e3b1aea

## Text

```text
def method_get_order(self, ordered_obj)
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
- posted_at: `2026-11-09T22:39:40.3686360+00:00`

## Data

```json
{
  "end_line": 2545,
  "entity_kind": "function",
  "parent": "base",
  "start_line": 2541,
  "symbol": "method_get_order"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2541,"selector":"L2541-L2545","symbol":"method_get_order"}`

## Referenced by

None.

## Subject

[django/db/models/base::method_get_order](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2545,
    "entity_kind": "function",
    "parent": "base",
    "start_line": 2541,
    "symbol": "method_get_order"
  },
  "id": "45f6478c-c2d1-4ae3-b6d6-8c010e3b1aea",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3686360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2541,
        "selector": "L2541-L2545",
        "symbol": "method_get_order"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "dc1a03d3-2fc3-4df1-aacc-15882c372a1d",
  "subject_name": "django/db/models/base::method_get_order",
  "tags": [
    "entity:function"
  ],
  "text": "def method_get_order(self, ordered_obj)"
}
```
