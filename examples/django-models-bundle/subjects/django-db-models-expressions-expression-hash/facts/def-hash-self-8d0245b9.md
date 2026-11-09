# Fact 8d0245b9

Store id: bf401c49-4d32-478b-83bf-fb0ac5178c98

## Text

```text
def __hash__(self)
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
- posted_at: `2026-11-09T23:31:55.8038230+00:00`

## Data

```json
{
  "end_line": 562,
  "entity_kind": "method",
  "parent": "Expression",
  "start_line": 561,
  "symbol": "Expression.__hash__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":561,"selector":"L561-L562","symbol":"Expression.__hash__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Expression.__hash__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 562,
    "entity_kind": "method",
    "parent": "Expression",
    "start_line": 561,
    "symbol": "Expression.__hash__"
  },
  "id": "bf401c49-4d32-478b-83bf-fb0ac5178c98",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8038230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 561,
        "selector": "L561-L562",
        "symbol": "Expression.__hash__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "dda4990b-513f-47d1-8b85-28cb76e480e1",
  "subject_name": "django/db/models/expressions::Expression.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
