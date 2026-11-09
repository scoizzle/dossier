# Fact 8c17169d

Store id: ced6e385-a1ce-4aef-96b9-57f7a81bb1b3

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
- posted_at: `2026-11-09T23:32:03.7104940+00:00`

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
  "id": "ced6e385-a1ce-4aef-96b9-57f7a81bb1b3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.7104940+00:00"
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
  "subject_id": "8d4faf5b-3cd0-412b-93ca-b8717a125ffb",
  "subject_name": "django/db/models/manager::BaseManager.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
