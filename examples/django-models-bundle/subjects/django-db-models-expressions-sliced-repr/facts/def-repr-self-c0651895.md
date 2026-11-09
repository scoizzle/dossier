# Fact c0651895

Store id: 0ff31c37-1635-4644-8a59-732991d87787

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
- posted_at: `2026-11-09T23:44:49.5026520+00:00`

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
  "id": "0ff31c37-1635-4644-8a59-732991d87787",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5026520+00:00"
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
  "subject_id": "94b89648-e0b0-4eec-9d6f-cb1eb27867fc",
  "subject_name": "django/db/models/expressions::Sliced.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
