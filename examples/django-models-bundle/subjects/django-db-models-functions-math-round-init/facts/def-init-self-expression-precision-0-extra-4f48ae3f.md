# Fact 4f48ae3f

Store id: 32f03828-7dab-4f4c-b8b7-6d19c1ead9f2

## Text

```text
def __init__(self, expression, precision=0, **extra)
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
- posted_at: `2026-11-09T22:39:46.6711360+00:00`

## Data

```json
{
  "end_line": 184,
  "entity_kind": "method",
  "parent": "Round",
  "start_line": 183,
  "symbol": "Round.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":183,"selector":"L183-L184","symbol":"Round.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Round.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 184,
    "entity_kind": "method",
    "parent": "Round",
    "start_line": 183,
    "symbol": "Round.__init__"
  },
  "id": "32f03828-7dab-4f4c-b8b7-6d19c1ead9f2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6711360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 183,
        "selector": "L183-L184",
        "symbol": "Round.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "54f2ae28-e76e-414c-9034-fd945858bebe",
  "subject_name": "django/db/models/functions/math::Round.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, precision=0, **extra)"
}
```
