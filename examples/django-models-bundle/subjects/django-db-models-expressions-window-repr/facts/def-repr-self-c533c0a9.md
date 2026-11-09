# Fact c533c0a9

Store id: b65d9802-d29d-4683-97ac-37884386a8c7

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T22:39:41.7666200+00:00`

## Data

```json
{
  "end_line": 2116,
  "entity_kind": "method",
  "parent": "Window",
  "start_line": 2115,
  "symbol": "Window.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2115,"selector":"L2115-L2116","symbol":"Window.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Window.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2116,
    "entity_kind": "method",
    "parent": "Window",
    "start_line": 2115,
    "symbol": "Window.__repr__"
  },
  "id": "b65d9802-d29d-4683-97ac-37884386a8c7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7666200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2115,
        "selector": "L2115-L2116",
        "symbol": "Window.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "902cb718-f564-45d9-860b-a7b950e1626f",
  "subject_name": "django/db/models/expressions::Window.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
