# Fact 7da2d43c

Store id: 7bea244c-fa3c-42be-a14b-b94dd5e74405

## Text

```text
def __init__( self, expression, partition_by=None, order_by=None, frame=None, output_field=None, )
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
- posted_at: `2026-11-09T22:39:41.7552260+00:00`

## Data

```json
{
  "end_line": 2053,
  "entity_kind": "method",
  "parent": "Window",
  "start_line": 2028,
  "symbol": "Window.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2028,"selector":"L2028-L2053","symbol":"Window.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Window.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2053,
    "entity_kind": "method",
    "parent": "Window",
    "start_line": 2028,
    "symbol": "Window.__init__"
  },
  "id": "7bea244c-fa3c-42be-a14b-b94dd5e74405",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7552260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2028,
        "selector": "L2028-L2053",
        "symbol": "Window.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "c190a581-a947-46c6-aa4d-f8d74b5bc13c",
  "subject_name": "django/db/models/expressions::Window.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, expression, partition_by=None, order_by=None, frame=None, output_field=None, )"
}
```
