# Fact 7da2d43c

Store id: bb6026ec-4f58-445a-89ca-4337cd32a866

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
- posted_at: `2026-11-09T23:44:49.6676450+00:00`

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
  "id": "bb6026ec-4f58-445a-89ca-4337cd32a866",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6676450+00:00"
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
  "subject_id": "17a9d1ad-df27-4221-9c2c-f554d22fc8da",
  "subject_name": "django/db/models/expressions::Window.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, expression, partition_by=None, order_by=None, frame=None, output_field=None, )"
}
```
