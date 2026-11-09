# Fact 7468a364

Store id: 79091f8f-1051-470d-9370-0b7aab46644d

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T23:32:03.7078180+00:00`

## Data

```json
{
  "end_line": 170,
  "entity_kind": "method",
  "parent": "BaseManager",
  "start_line": 166,
  "symbol": "BaseManager.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":166,"selector":"L166-L170","symbol":"BaseManager.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 170,
    "entity_kind": "method",
    "parent": "BaseManager",
    "start_line": 166,
    "symbol": "BaseManager.__eq__"
  },
  "id": "79091f8f-1051-470d-9370-0b7aab46644d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.7078180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 166,
        "selector": "L166-L170",
        "symbol": "BaseManager.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "dcbb03a8-0e36-465a-a56c-8e0a38f7a460",
  "subject_name": "django/db/models/manager::BaseManager.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
