# Fact 49645632

Store id: 1bda0d6d-4ca3-4d90-8ab3-42afc6dd6754

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
- posted_at: `2026-11-09T23:44:49.5528440+00:00`

## Data

```json
{
  "end_line": 1364,
  "entity_kind": "method",
  "parent": "Col",
  "start_line": 1361,
  "symbol": "Col.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1361,"selector":"L1361-L1364","symbol":"Col.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Col.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1364,
    "entity_kind": "method",
    "parent": "Col",
    "start_line": 1361,
    "symbol": "Col.__repr__"
  },
  "id": "1bda0d6d-4ca3-4d90-8ab3-42afc6dd6754",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5528440+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1361,
        "selector": "L1361-L1364",
        "symbol": "Col.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "e7a21f61-7551-4244-a066-85ebf5823880",
  "subject_name": "django/db/models/expressions::Col.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
