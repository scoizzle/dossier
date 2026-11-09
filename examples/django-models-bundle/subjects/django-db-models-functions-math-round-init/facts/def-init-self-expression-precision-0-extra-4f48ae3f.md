# Fact 4f48ae3f

Store id: 4d01f3bb-ac7f-48ae-a144-e9b12323a856

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
- posted_at: `2026-11-09T23:32:01.7609400+00:00`

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
  "id": "4d01f3bb-ac7f-48ae-a144-e9b12323a856",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.7609400+00:00"
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
  "subject_id": "7c72c11a-9aab-4eea-b545-83f6faf3de92",
  "subject_name": "django/db/models/functions/math::Round.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, precision=0, **extra)"
}
```
