# Fact b5d0c8b2

Store id: 2b92309a-d593-4ceb-9fa3-fabef90c0d7e

## Text

```text
def __init__( self, expression, kind, output_field=None, tzinfo=None, **extra, )
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
- posted_at: `2026-11-09T23:32:01.2694560+00:00`

## Data

```json
{
  "end_line": 358,
  "entity_kind": "method",
  "parent": "Trunc",
  "start_line": 349,
  "symbol": "Trunc.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":349,"selector":"L349-L358","symbol":"Trunc.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::Trunc.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 358,
    "entity_kind": "method",
    "parent": "Trunc",
    "start_line": 349,
    "symbol": "Trunc.__init__"
  },
  "id": "2b92309a-d593-4ceb-9fa3-fabef90c0d7e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.2694560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 349,
        "selector": "L349-L358",
        "symbol": "Trunc.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "ebfafca4-0a1c-4035-85c9-9d2dac8eafb3",
  "subject_name": "django/db/models/functions/datetime::Trunc.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, expression, kind, output_field=None, tzinfo=None, **extra, )"
}
```
