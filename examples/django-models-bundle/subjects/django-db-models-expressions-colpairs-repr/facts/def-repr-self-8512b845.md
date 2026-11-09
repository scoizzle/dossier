# Fact 8512b845

Store id: 0dc03e84-d3df-496f-8ee1-1b3618f82ec3

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
- posted_at: `2026-11-09T22:39:41.6407640+00:00`

## Data

```json
{
  "end_line": 1407,
  "entity_kind": "method",
  "parent": "ColPairs",
  "start_line": 1403,
  "symbol": "ColPairs.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1403,"selector":"L1403-L1407","symbol":"ColPairs.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ColPairs.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1407,
    "entity_kind": "method",
    "parent": "ColPairs",
    "start_line": 1403,
    "symbol": "ColPairs.__repr__"
  },
  "id": "0dc03e84-d3df-496f-8ee1-1b3618f82ec3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6407640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1403,
        "selector": "L1403-L1407",
        "symbol": "ColPairs.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "21b5d9c4-7c0b-4d2d-8a3c-ec4368fb649d",
  "subject_name": "django/db/models/expressions::ColPairs.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
