# Fact 41590beb

Store id: 28c156d5-b57c-4c52-a826-71f24de9cf0c

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
- posted_at: `2026-11-09T23:44:55.3165330+00:00`

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
  "id": "28c156d5-b57c-4c52-a826-71f24de9cf0c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.3165330+00:00"
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
  "subject_id": "56d65547-4055-49bb-81f1-1965821642ba",
  "subject_name": "django/db/models/manager::ManagerDescriptor.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, manager)"
}
```
