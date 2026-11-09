# Fact de9d60ac

Store id: f9a6d159-eb11-4aae-b525-714052a72d0b

## Text

```text
def __init__(self, obj, subscript)
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
- posted_at: `2026-11-09T23:44:49.5018830+00:00`

## Data

```json
{
  "end_line": 1027,
  "entity_kind": "method",
  "parent": "Sliced",
  "start_line": 1004,
  "symbol": "Sliced.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1004,"selector":"L1004-L1027","symbol":"Sliced.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Sliced.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1027,
    "entity_kind": "method",
    "parent": "Sliced",
    "start_line": 1004,
    "symbol": "Sliced.__init__"
  },
  "id": "f9a6d159-eb11-4aae-b525-714052a72d0b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5018830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1004,
        "selector": "L1004-L1027",
        "symbol": "Sliced.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "1cb7c942-bd04-491a-993b-8b9de7d2a033",
  "subject_name": "django/db/models/expressions::Sliced.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, obj, subscript)"
}
```
