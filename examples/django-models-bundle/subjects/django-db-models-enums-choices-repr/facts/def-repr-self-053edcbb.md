# Fact 053edcbb

Store id: 4b6cde5e-2863-4ec8-8505-1cd1d2fdff1e

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T22:39:41.3056860+00:00`

## Data

```json
{
  "end_line": 65,
  "entity_kind": "method",
  "parent": "Choices",
  "start_line": 64,
  "symbol": "Choices.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/enums.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":64,"selector":"L64-L65","symbol":"Choices.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/enums::Choices.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 65,
    "entity_kind": "method",
    "parent": "Choices",
    "start_line": 64,
    "symbol": "Choices.__repr__"
  },
  "id": "4b6cde5e-2863-4ec8-8505-1cd1d2fdff1e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.3056860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 64,
        "selector": "L64-L65",
        "symbol": "Choices.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/enums.py"
    }
  ],
  "status": "live",
  "subject_id": "f3a8f5af-30ad-488b-9a93-1799cd54bd58",
  "subject_name": "django/db/models/enums::Choices.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
