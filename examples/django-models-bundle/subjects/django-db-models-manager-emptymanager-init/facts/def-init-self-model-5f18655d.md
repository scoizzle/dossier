# Fact 5f18655d

Store id: 74c5f27a-1052-47dd-b2a4-9330dfec6c4b

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
- posted_at: `2026-11-09T22:39:48.5522600+00:00`

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
  "id": "74c5f27a-1052-47dd-b2a4-9330dfec6c4b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.5522600+00:00"
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
  "subject_id": "11509bd5-d69b-4c48-b2e6-b481ab3bec9e",
  "subject_name": "django/db/models/manager::EmptyManager.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, model)"
}
```
