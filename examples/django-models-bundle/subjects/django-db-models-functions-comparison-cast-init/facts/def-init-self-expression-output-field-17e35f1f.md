# Fact 17e35f1f

Store id: 49b2c836-8144-4e67-a933-eb4bbc398a4b

## Text

```text
def __init__(self, expression, output_field)
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
- posted_at: `2026-11-09T23:32:00.9465110+00:00`

## Data

```json
{
  "end_line": 14,
  "entity_kind": "method",
  "parent": "Cast",
  "start_line": 13,
  "symbol": "Cast.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":13,"selector":"L13-L14","symbol":"Cast.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Cast.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 14,
    "entity_kind": "method",
    "parent": "Cast",
    "start_line": 13,
    "symbol": "Cast.__init__"
  },
  "id": "49b2c836-8144-4e67-a933-eb4bbc398a4b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.9465110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 13,
        "selector": "L13-L14",
        "symbol": "Cast.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "3b4dfbc0-23ab-44cf-bc80-c5d1ca026350",
  "subject_name": "django/db/models/functions/comparison::Cast.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, output_field)"
}
```
