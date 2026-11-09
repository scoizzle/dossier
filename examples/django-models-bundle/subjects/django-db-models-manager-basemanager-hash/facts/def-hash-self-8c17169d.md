# Fact 8c17169d

Store id: 254bd064-58c2-4849-9f36-8476c6639f33

## Text

```text
def __hash__(self)
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
- posted_at: `2026-11-09T23:44:55.3084930+00:00`

## Data

```json
{
  "end_line": 173,
  "entity_kind": "method",
  "parent": "BaseManager",
  "start_line": 172,
  "symbol": "BaseManager.__hash__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":172,"selector":"L172-L173","symbol":"BaseManager.__hash__"}`

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager.__hash__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 173,
    "entity_kind": "method",
    "parent": "BaseManager",
    "start_line": 172,
    "symbol": "BaseManager.__hash__"
  },
  "id": "254bd064-58c2-4849-9f36-8476c6639f33",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.3084930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 172,
        "selector": "L172-L173",
        "symbol": "BaseManager.__hash__"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "92f36207-2ec8-40f5-bdc1-be6416803550",
  "subject_name": "django/db/models/manager::BaseManager.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
