# Fact c0651895

Store id: 19c8dd68-41f3-4ae3-af47-398571b4d13d

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
- posted_at: `2026-11-09T22:39:41.5749030+00:00`

## Data

```json
{
  "end_line": 1033,
  "entity_kind": "method",
  "parent": "Sliced",
  "start_line": 1029,
  "symbol": "Sliced.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1029,"selector":"L1029-L1033","symbol":"Sliced.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Sliced.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1033,
    "entity_kind": "method",
    "parent": "Sliced",
    "start_line": 1029,
    "symbol": "Sliced.__repr__"
  },
  "id": "19c8dd68-41f3-4ae3-af47-398571b4d13d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5749030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1029,
        "selector": "L1029-L1033",
        "symbol": "Sliced.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "d27eb883-585c-4853-8c2e-b310e00448bd",
  "subject_name": "django/db/models/expressions::Sliced.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
