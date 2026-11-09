# Fact 15126800

Store id: 961c9c51-aa7f-42a0-a4bc-f73f1958c5aa

## Text

```text
def unnest(fields)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:43.0227470+00:00`

## Data

```json
{
  "end_line": 177,
  "entity_kind": "function",
  "parent": "composite",
  "start_line": 168,
  "symbol": "unnest"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":168,"selector":"L168-L177","symbol":"unnest"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::unnest](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 177,
    "entity_kind": "function",
    "parent": "composite",
    "start_line": 168,
    "symbol": "unnest"
  },
  "id": "961c9c51-aa7f-42a0-a4bc-f73f1958c5aa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.0227470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 168,
        "selector": "L168-L177",
        "symbol": "unnest"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "9149dc15-2f26-410f-b6de-667708ca1215",
  "subject_name": "django/db/models/fields/composite::unnest",
  "tags": [
    "entity:function"
  ],
  "text": "def unnest(fields)"
}
```
