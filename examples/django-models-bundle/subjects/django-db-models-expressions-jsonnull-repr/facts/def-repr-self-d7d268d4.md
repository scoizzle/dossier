# Fact d7d268d4

Store id: 51845457-b3d3-4ead-b94c-180c3a57410d

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
- posted_at: `2026-11-09T22:39:41.6040940+00:00`

## Data

```json
{
  "end_line": 1254,
  "entity_kind": "method",
  "parent": "JSONNull",
  "start_line": 1253,
  "symbol": "JSONNull.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1253,"selector":"L1253-L1254","symbol":"JSONNull.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::JSONNull.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1254,
    "entity_kind": "method",
    "parent": "JSONNull",
    "start_line": 1253,
    "symbol": "JSONNull.__repr__"
  },
  "id": "51845457-b3d3-4ead-b94c-180c3a57410d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6040940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1253,
        "selector": "L1253-L1254",
        "symbol": "JSONNull.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ab5a78d5-ab7d-4729-b26f-41d3ffb41f5c",
  "subject_name": "django/db/models/expressions::JSONNull.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
