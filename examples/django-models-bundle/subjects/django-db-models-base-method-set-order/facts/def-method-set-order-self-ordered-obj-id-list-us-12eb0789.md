# Fact 12eb0789

Store id: feaf7c7d-0cbd-468e-9520-810cd71c9ec1

## Text

```text
def method_set_order(self, ordered_obj, id_list, using=None)
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
- posted_at: `2026-11-09T23:44:48.5565720+00:00`

## Data

```json
{
  "end_line": 2538,
  "entity_kind": "function",
  "parent": "base",
  "start_line": 2532,
  "symbol": "method_set_order"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2532,"selector":"L2532-L2538","symbol":"method_set_order"}`

## Referenced by

None.

## Subject

[django/db/models/base::method_set_order](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2538,
    "entity_kind": "function",
    "parent": "base",
    "start_line": 2532,
    "symbol": "method_set_order"
  },
  "id": "feaf7c7d-0cbd-468e-9520-810cd71c9ec1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5565720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2532,
        "selector": "L2532-L2538",
        "symbol": "method_set_order"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "b23c09d5-cae9-42d6-bfc6-cb580d3c9919",
  "subject_name": "django/db/models/base::method_set_order",
  "tags": [
    "entity:function"
  ],
  "text": "def method_set_order(self, ordered_obj, id_list, using=None)"
}
```
