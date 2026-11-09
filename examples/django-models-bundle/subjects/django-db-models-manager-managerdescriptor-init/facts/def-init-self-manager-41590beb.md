# Fact 41590beb

Store id: c80a292f-273e-46f6-9f38-4b947679288e

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
- posted_at: `2026-11-09T22:39:48.5423350+00:00`

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
  "id": "c80a292f-273e-46f6-9f38-4b947679288e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.5423350+00:00"
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
  "subject_id": "e29709aa-cf60-40c9-94c2-ff61744ea0fc",
  "subject_name": "django/db/models/manager::ManagerDescriptor.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, manager)"
}
```
