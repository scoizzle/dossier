# Fact 7da2d43c

Store id: a6d11f63-6868-4f87-b935-9ac5c41a74ef

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
- posted_at: `2026-11-09T23:31:55.9998320+00:00`

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
  "id": "a6d11f63-6868-4f87-b935-9ac5c41a74ef",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9998320+00:00"
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
  "subject_id": "42bbe2f8-ed16-442b-9358-01f497dea27d",
  "subject_name": "django/db/models/expressions::Window.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, expression, partition_by=None, order_by=None, frame=None, output_field=None, )"
}
```
