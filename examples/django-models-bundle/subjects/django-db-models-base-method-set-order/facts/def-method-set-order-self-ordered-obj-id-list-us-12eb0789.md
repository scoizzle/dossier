# Fact 12eb0789

Store id: e96a5857-c0c9-4eeb-a018-7da039bc9ed2

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
- posted_at: `2026-11-09T22:39:40.3682290+00:00`

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
  "id": "e96a5857-c0c9-4eeb-a018-7da039bc9ed2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3682290+00:00"
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
  "subject_id": "f59ff884-167b-423c-b085-2c13f147d4a0",
  "subject_name": "django/db/models/base::method_set_order",
  "tags": [
    "entity:function"
  ],
  "text": "def method_set_order(self, ordered_obj, id_list, using=None)"
}
```
