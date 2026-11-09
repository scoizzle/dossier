# Fact 4f48ae3f

Store id: 833bf9ec-8652-4cd9-947a-5b3f331c6e8a

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
- posted_at: `2026-11-09T23:44:53.7636680+00:00`

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
  "id": "833bf9ec-8652-4cd9-947a-5b3f331c6e8a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.7636680+00:00"
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
  "subject_id": "ba005c5a-602b-4c1d-afd3-d72d225caf32",
  "subject_name": "django/db/models/functions/math::Round.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, precision=0, **extra)"
}
```
