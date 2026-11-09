# Fact 52e827e7

Store id: 97ce7223-719f-48cc-bb31-ecec5ba38662

## Text

```text
def __init__(self, expression, number, **extra)
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
- posted_at: `2026-11-09T22:39:47.1453160+00:00`

## Data

```json
{
  "end_line": 244,
  "entity_kind": "method",
  "parent": "Repeat",
  "start_line": 237,
  "symbol": "Repeat.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":237,"selector":"L237-L244","symbol":"Repeat.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Repeat.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 244,
    "entity_kind": "method",
    "parent": "Repeat",
    "start_line": 237,
    "symbol": "Repeat.__init__"
  },
  "id": "97ce7223-719f-48cc-bb31-ecec5ba38662",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1453160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 237,
        "selector": "L237-L244",
        "symbol": "Repeat.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "d08783b1-dee3-4de0-95f7-72d0d64947eb",
  "subject_name": "django/db/models/functions/text::Repeat.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, number, **extra)"
}
```
