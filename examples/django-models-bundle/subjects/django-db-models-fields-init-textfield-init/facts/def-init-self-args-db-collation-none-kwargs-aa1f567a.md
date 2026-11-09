# Fact aa1f567a

Store id: 0c8c3559-7ba6-4e90-a35f-a585c2fc4750

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
- posted_at: `2026-11-09T23:31:56.7939090+00:00`

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
  "id": "0c8c3559-7ba6-4e90-a35f-a585c2fc4750",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7939090+00:00"
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
  "subject_id": "93901b96-9e2a-4d37-9efe-1e2a919fff5a",
  "subject_name": "django/db/models/fields/__init__::TextField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, db_collation=None, **kwargs)"
}
```
