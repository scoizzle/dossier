# Fact 0434769d

Store id: 75532b83-8b02-416e-9898-d9db49f93bc3

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
- posted_at: `2026-11-09T22:39:41.5570520+00:00`

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
  "id": "75532b83-8b02-416e-9898-d9db49f93bc3",
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
    "posted_at": "2026-11-09T22:39:41.5570520+00:00"
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
  "subject_id": "fee9ce7f-5cab-45d3-9a91-ab83eb0acc90",
  "subject_name": "django/db/models/expressions::F.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, name)"
}
```
