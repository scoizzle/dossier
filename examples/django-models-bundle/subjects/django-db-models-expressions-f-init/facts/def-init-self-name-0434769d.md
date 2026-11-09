# Fact 0434769d

Store id: 75e4c3d4-a730-44cc-bdc8-9aea63900a10

## Text

```text
def __init__(self, name)
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
- posted_at: `2026-11-09T23:44:49.4683660+00:00`

## Data

```json
{
  "end_line": 892,
  "entity_kind": "method",
  "parent": "F",
  "start_line": 887,
  "symbol": "F.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":887,"selector":"L887-L892","symbol":"F.__init__"}`

## Items

```json
[
  {
    "text": "Arguments: * name: the name of the field this expression references",
    "locator": {
      "line": 888
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::F.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 892,
    "entity_kind": "method",
    "parent": "F",
    "start_line": 887,
    "symbol": "F.__init__"
  },
  "id": "75e4c3d4-a730-44cc-bdc8-9aea63900a10",
  "items": [
    {
      "locator": {
        "line": 888
      },
      "text": "Arguments: * name: the name of the field this expression references"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4683660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 887,
        "selector": "L887-L892",
        "symbol": "F.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "4f04e8c1-011a-4254-916f-166fb27a79d0",
  "subject_name": "django/db/models/expressions::F.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, name)"
}
```
