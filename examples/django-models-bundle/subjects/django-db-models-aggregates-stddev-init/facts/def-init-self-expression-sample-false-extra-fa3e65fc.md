# Fact fa3e65fc

Store id: fb68d10b-a89c-4de0-b935-52db79e033c0

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
- posted_at: `2026-11-09T23:31:53.5415350+00:00`

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
  "id": "fb68d10b-a89c-4de0-b935-52db79e033c0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5415350+00:00"
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
  "subject_id": "4bfad9e1-7fae-427f-914c-e4f4850c6b09",
  "subject_name": "django/db/models/aggregates::StdDev.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, sample=False, **extra)"
}
```
