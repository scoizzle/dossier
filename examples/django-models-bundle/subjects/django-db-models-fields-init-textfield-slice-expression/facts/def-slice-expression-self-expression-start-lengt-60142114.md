# Fact 60142114

Store id: 0ed56700-9ae7-46eb-ae69-84be07f4f555

## Text

```text
def slice_expression(self, expression, start, length)
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
- posted_at: `2026-11-09T23:44:50.2491160+00:00`

## Data

```json
{
  "end_line": 2598,
  "entity_kind": "method",
  "parent": "TextField",
  "start_line": 2595,
  "symbol": "TextField.slice_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2595,"selector":"L2595-L2598","symbol":"TextField.slice_expression"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TextField.slice_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2598,
    "entity_kind": "method",
    "parent": "TextField",
    "start_line": 2595,
    "symbol": "TextField.slice_expression"
  },
  "id": "0ed56700-9ae7-46eb-ae69-84be07f4f555",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2491160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2595,
        "selector": "L2595-L2598",
        "symbol": "TextField.slice_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "03650ec5-53b5-4a75-959f-c769a50086f7",
  "subject_name": "django/db/models/fields/__init__::TextField.slice_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def slice_expression(self, expression, start, length)"
}
```
