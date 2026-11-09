# Fact 17e35f1f

Store id: b87c7dd8-f27d-4ca8-93fd-c65c0534fa77

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
- posted_at: `2026-11-09T23:44:53.1062680+00:00`

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
  "id": "b87c7dd8-f27d-4ca8-93fd-c65c0534fa77",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.1062680+00:00"
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
  "subject_id": "3f0b4ee9-e3cb-4b97-9f30-acc15625806b",
  "subject_name": "django/db/models/functions/comparison::Cast.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, output_field)"
}
```
