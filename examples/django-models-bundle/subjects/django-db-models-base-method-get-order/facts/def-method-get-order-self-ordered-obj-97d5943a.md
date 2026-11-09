# Fact 97d5943a

Store id: 68aa866a-4216-495a-a109-75ea15e2da91

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
- posted_at: `2026-11-09T23:44:48.5569810+00:00`

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
  "id": "68aa866a-4216-495a-a109-75ea15e2da91",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5569810+00:00"
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
  "subject_id": "0e6d830f-951e-4e98-9bf2-50cff895d4fb",
  "subject_name": "django/db/models/base::method_get_order",
  "tags": [
    "entity:function"
  ],
  "text": "def method_get_order(self, ordered_obj)"
}
```
