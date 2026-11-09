# Fact b5d0c8b2

Store id: e85da42a-339d-4253-806a-b48c7d4a74b9

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
- posted_at: `2026-11-09T22:39:46.1881000+00:00`

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
  "id": "e85da42a-339d-4253-806a-b48c7d4a74b9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1881000+00:00"
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
  "subject_id": "6d78fc40-0f37-449c-b20f-78d59ce184a2",
  "subject_name": "django/db/models/functions/datetime::Trunc.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, expression, kind, output_field=None, tzinfo=None, **extra, )"
}
```
