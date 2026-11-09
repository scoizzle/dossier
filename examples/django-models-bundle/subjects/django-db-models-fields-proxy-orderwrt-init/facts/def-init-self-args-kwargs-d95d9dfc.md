# Fact d95d9dfc

Store id: 5e285ea9-86d6-4c05-83ac-6087e2dfa513

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
- posted_at: `2026-11-09T23:31:58.4292650+00:00`

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
  "id": "5e285ea9-86d6-4c05-83ac-6087e2dfa513",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.4292650+00:00"
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
  "subject_id": "296e28cc-13c4-416c-bd63-a0f3db751c5a",
  "subject_name": "django/db/models/fields/proxy::OrderWrt.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
