# Fact 889ecdab

Store id: 61513a4b-6a64-45a9-adfa-21182bbc2d08

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
- posted_at: `2026-11-09T22:39:41.6509100+00:00`

## Data

```json
{
  "end_line": 1458,
  "entity_kind": "method",
  "parent": "Ref",
  "start_line": 1457,
  "symbol": "Ref.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1457,"selector":"L1457-L1458","symbol":"Ref.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Ref.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1458,
    "entity_kind": "method",
    "parent": "Ref",
    "start_line": 1457,
    "symbol": "Ref.__repr__"
  },
  "id": "61513a4b-6a64-45a9-adfa-21182bbc2d08",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6509100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1457,
        "selector": "L1457-L1458",
        "symbol": "Ref.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ff596ce8-e86e-40d2-92f6-586d1f147cf2",
  "subject_name": "django/db/models/expressions::Ref.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
