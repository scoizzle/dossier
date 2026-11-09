# Fact 41590beb

Store id: d399d1b6-4da8-4d0c-bf1c-3ade4565c484

## Text

```text
def __init__(self, manager)
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
- posted_at: `2026-11-09T23:32:03.7192940+00:00`

## Data

```json
{
  "end_line": 182,
  "entity_kind": "method",
  "parent": "ManagerDescriptor",
  "start_line": 181,
  "symbol": "ManagerDescriptor.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":181,"selector":"L181-L182","symbol":"ManagerDescriptor.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/manager::ManagerDescriptor.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 182,
    "entity_kind": "method",
    "parent": "ManagerDescriptor",
    "start_line": 181,
    "symbol": "ManagerDescriptor.__init__"
  },
  "id": "d399d1b6-4da8-4d0c-bf1c-3ade4565c484",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.7192940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 181,
        "selector": "L181-L182",
        "symbol": "ManagerDescriptor.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "bf18f164-10c2-4ad5-8b0e-b4582a835c72",
  "subject_name": "django/db/models/manager::ManagerDescriptor.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, manager)"
}
```
