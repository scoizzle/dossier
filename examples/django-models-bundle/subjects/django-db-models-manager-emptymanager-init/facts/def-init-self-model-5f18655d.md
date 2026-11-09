# Fact 5f18655d

Store id: 8f50dfef-999b-4a8a-b228-386ab9c547a0

## Text

```text
def __init__(self, model)
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
- posted_at: `2026-11-09T23:44:55.3245700+00:00`

## Data

```json
{
  "end_line": 210,
  "entity_kind": "method",
  "parent": "EmptyManager",
  "start_line": 208,
  "symbol": "EmptyManager.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":208,"selector":"L208-L210","symbol":"EmptyManager.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/manager::EmptyManager.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 210,
    "entity_kind": "method",
    "parent": "EmptyManager",
    "start_line": 208,
    "symbol": "EmptyManager.__init__"
  },
  "id": "8f50dfef-999b-4a8a-b228-386ab9c547a0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.3245700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 208,
        "selector": "L208-L210",
        "symbol": "EmptyManager.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "c9a94d58-0934-4b93-b281-7aef37ab09fe",
  "subject_name": "django/db/models/manager::EmptyManager.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, model)"
}
```
