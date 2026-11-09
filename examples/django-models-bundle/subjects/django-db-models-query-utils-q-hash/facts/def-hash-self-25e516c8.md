# Fact 25e516c8

Store id: c4140db9-84ff-47ca-a0e7-5638760a88a9

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
- posted_at: `2026-11-09T22:39:50.1037460+00:00`

## Data

```json
{
  "end_line": 234,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 233,
  "symbol": "Q.__hash__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":233,"selector":"L233-L234","symbol":"Q.__hash__"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.__hash__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 234,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 233,
    "symbol": "Q.__hash__"
  },
  "id": "c4140db9-84ff-47ca-a0e7-5638760a88a9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.1037460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 233,
        "selector": "L233-L234",
        "symbol": "Q.__hash__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "b27f8004-c924-4f42-b053-348a616d5d26",
  "subject_name": "django/db/models/query_utils::Q.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
