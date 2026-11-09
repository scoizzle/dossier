# Fact e633bfff

Store id: 732360f0-7169-401c-8d72-fe22aa3b502c

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
- posted_at: `2026-11-09T22:39:41.6290130+00:00`

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
  "id": "732360f0-7169-401c-8d72-fe22aa3b502c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6290130+00:00"
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
  "subject_id": "e743fb65-8a25-40e2-b294-1f6f34885fa1",
  "subject_name": "django/db/models/expressions::Col.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, alias, target, output_field=None)"
}
```
