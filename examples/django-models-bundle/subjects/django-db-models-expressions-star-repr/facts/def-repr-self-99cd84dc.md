# Fact 99cd84dc

Store id: 2f0097c6-5ccb-4582-b1e6-ffb57f46406a

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
- posted_at: `2026-11-09T23:44:49.5429310+00:00`

## Data

```json
{
  "end_line": 1305,
  "entity_kind": "method",
  "parent": "Star",
  "start_line": 1304,
  "symbol": "Star.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1304,"selector":"L1304-L1305","symbol":"Star.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Star.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1305,
    "entity_kind": "method",
    "parent": "Star",
    "start_line": 1304,
    "symbol": "Star.__repr__"
  },
  "id": "2f0097c6-5ccb-4582-b1e6-ffb57f46406a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5429310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1304,
        "selector": "L1304-L1305",
        "symbol": "Star.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "9507fc5a-7119-4cd0-ae69-8463625c837f",
  "subject_name": "django/db/models/expressions::Star.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
