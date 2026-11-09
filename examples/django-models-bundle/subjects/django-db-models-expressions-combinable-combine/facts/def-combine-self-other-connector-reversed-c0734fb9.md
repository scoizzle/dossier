# Fact c0734fb9

Store id: 1bb2b87e-e943-49db-81b2-74863111957f

## Text

```text
def _combine(self, other, connector, reversed)
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
- posted_at: `2026-11-09T23:31:55.7243210+00:00`

## Data

```json
{
  "end_line": 70,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 63,
  "symbol": "Combinable._combine"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":63,"selector":"L63-L70","symbol":"Combinable._combine"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable._combine](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 70,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 63,
    "symbol": "Combinable._combine"
  },
  "id": "1bb2b87e-e943-49db-81b2-74863111957f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7243210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 63,
        "selector": "L63-L70",
        "symbol": "Combinable._combine"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "4a0dd972-fc1d-42dd-8902-d17f61a35d9c",
  "subject_name": "django/db/models/expressions::Combinable._combine",
  "tags": [
    "entity:method"
  ],
  "text": "def _combine(self, other, connector, reversed)"
}
```
