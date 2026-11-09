# Fact e633bfff

Store id: 9a069e0c-5843-4cc7-be7c-b38e2ad6b6e0

## Text

```text
def __init__(self, alias, target, output_field=None)
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
- posted_at: `2026-11-09T23:44:49.5520020+00:00`

## Data

```json
{
  "end_line": 1359,
  "entity_kind": "method",
  "parent": "Col",
  "start_line": 1355,
  "symbol": "Col.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1355,"selector":"L1355-L1359","symbol":"Col.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Col.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1359,
    "entity_kind": "method",
    "parent": "Col",
    "start_line": 1355,
    "symbol": "Col.__init__"
  },
  "id": "9a069e0c-5843-4cc7-be7c-b38e2ad6b6e0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5520020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1355,
        "selector": "L1355-L1359",
        "symbol": "Col.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "c8a65660-ebf0-4302-bd5a-4e1efaf5cca5",
  "subject_name": "django/db/models/expressions::Col.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, alias, target, output_field=None)"
}
```
