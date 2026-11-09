# Fact aa1f567a

Store id: 4fd6237b-eb95-4795-baf8-403d7b65d030

## Text

```text
def __init__(self, *args, db_collation=None, **kwargs)
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
- posted_at: `2026-11-09T23:44:50.2354210+00:00`

## Data

```json
{
  "end_line": 2529,
  "entity_kind": "method",
  "parent": "TextField",
  "start_line": 2527,
  "symbol": "TextField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2527,"selector":"L2527-L2529","symbol":"TextField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TextField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2529,
    "entity_kind": "method",
    "parent": "TextField",
    "start_line": 2527,
    "symbol": "TextField.__init__"
  },
  "id": "4fd6237b-eb95-4795-baf8-403d7b65d030",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2354210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2527,
        "selector": "L2527-L2529",
        "symbol": "TextField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "e2793bd2-c585-414c-a861-959bf2089a77",
  "subject_name": "django/db/models/fields/__init__::TextField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, db_collation=None, **kwargs)"
}
```
