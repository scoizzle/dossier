# Fact fa3e65fc

Store id: 6391cfdf-2a5c-434d-a764-859c67219774

## Text

```text
def __init__(self, expression, sample=False, **extra)
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
- posted_at: `2026-11-09T23:44:48.4028800+00:00`

## Data

```json
{
  "end_line": 346,
  "entity_kind": "method",
  "parent": "StdDev",
  "start_line": 344,
  "symbol": "StdDev.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":344,"selector":"L344-L346","symbol":"StdDev.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::StdDev.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 346,
    "entity_kind": "method",
    "parent": "StdDev",
    "start_line": 344,
    "symbol": "StdDev.__init__"
  },
  "id": "6391cfdf-2a5c-434d-a764-859c67219774",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.4028800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 344,
        "selector": "L344-L346",
        "symbol": "StdDev.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "c8e40b1d-d234-4fe4-85c5-eb858b9ad0d2",
  "subject_name": "django/db/models/aggregates::StdDev.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, sample=False, **extra)"
}
```
