# Fact 7468a364

Store id: dd6f79d3-d285-4e2d-ab8e-182b62a5e483

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
- posted_at: `2026-11-09T22:39:48.5305210+00:00`

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
  "id": "dd6f79d3-d285-4e2d-ab8e-182b62a5e483",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.5305210+00:00"
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
  "subject_id": "dce0f058-5086-406f-9e2b-084ac94b5a5b",
  "subject_name": "django/db/models/manager::BaseManager.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
