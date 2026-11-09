# Fact d95d9dfc

Store id: 420cb429-807f-4f8b-a1f0-dde2d80159c5

## Text

```text
def __init__(self, *args, **kwargs)
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
- posted_at: `2026-11-09T23:44:51.3327900+00:00`

## Data

```json
{
  "end_line": 18,
  "entity_kind": "method",
  "parent": "OrderWrt",
  "start_line": 15,
  "symbol": "OrderWrt.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/proxy.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":15,"selector":"L15-L18","symbol":"OrderWrt.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/proxy::OrderWrt.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 18,
    "entity_kind": "method",
    "parent": "OrderWrt",
    "start_line": 15,
    "symbol": "OrderWrt.__init__"
  },
  "id": "420cb429-807f-4f8b-a1f0-dde2d80159c5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.3327900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 15,
        "selector": "L15-L18",
        "symbol": "OrderWrt.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/proxy.py"
    }
  ],
  "status": "live",
  "subject_id": "46c38e26-36d7-4cd1-ba3f-ab214f026e76",
  "subject_name": "django/db/models/fields/proxy::OrderWrt.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
